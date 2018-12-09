namespace Shuriken
{
    using UnityEditor;
    using UnityEngine;

    /**
     * Assetsで画像を選択の上、
     * Asets>Shuriken ChangeTexture > "設定する 押下でVRChat用に画像をワールドに貼る用の設定に一括変更するUnityエディタ拡張
     * This File licensed under the terms of the MIT license
     * Copyright (c) 2018 vrshuriken
     * <version>1.0.0</version>
     */
    public class ShurikenChangeTexture : EditorWindow
    {
        const int PRIORITY = 10002;

        const int DEFAULT_MAX_TEXTURE_SIZE = 2048;
        const int SPRITE_MAX_TEXTURE_SIZE = 512;

        /**
         * 設定値
         */
        TextureImporterType textureType = TextureImporterType.Sprite;
        int maxTextureSize = SPRITE_MAX_TEXTURE_SIZE;
        SpriteImportMode spriteImportMode = SpriteImportMode.Single;


        [MenuItem("Assets/Shuriken ChangeTexture", false, PRIORITY)]
        static void Open()
        {
            EditorWindow.GetWindow<ShurikenChangeTexture>("ShurikenChangeTexture");
        }

        // Windowのクライアント領域のGUI処理を記述
        void OnGUI()
        {
            textureType = (TextureImporterType)EditorGUILayout.EnumPopup("Texture Type", textureType);
            maxTextureSize = EditorGUILayout.IntField("Max Size", maxTextureSize);
            spriteImportMode = (SpriteImportMode)EditorGUILayout.EnumPopup("Sprite Mode", spriteImportMode);

            EditorGUILayout.Space();

            // ボタンをGUIに配置、ボタン押下でオブジェクト作成する
            if (GUILayout.Button("デフォルト値ロード"))
            {
                SetDefaultValue();
            }
            // ボタンをGUIに配置、ボタン押下でオブジェクト作成する
            if (GUILayout.Button("スプライト用設定値ロード"))
            {
                SetValueForSprite();
            }

            EditorGUILayout.Space();

            // ボタンをGUIに配置、ボタン押下でオブジェクト作成する
            if (GUILayout.Button("設定する"))
            {
                ChangeTextureType();
            }
        }

        private void SetValueForSprite()
        {
            textureType = TextureImporterType.Sprite;
            maxTextureSize = SPRITE_MAX_TEXTURE_SIZE;
            spriteImportMode = SpriteImportMode.Single;
            GUI.FocusControl("");
        }

        private void SetDefaultValue()
        {
            textureType = TextureImporterType.Default;
            maxTextureSize = DEFAULT_MAX_TEXTURE_SIZE;
            spriteImportMode = SpriteImportMode.Single;
            GUI.FocusControl("");
        }


        void ChangeTextureType()
        {
            foreach (UnityEngine.Object obj in Selection.objects)
            {
                if (obj == null) { continue; }
                var path = AssetDatabase.GetAssetPath(obj);

                TextureImporter textureImporter = AssetImporter.GetAtPath(path) as TextureImporter;
                if (textureImporter == null) { continue; }

                textureImporter.textureType = textureType;
                textureImporter.maxTextureSize = maxTextureSize;
                textureImporter.spriteImportMode = spriteImportMode;
                textureImporter.SaveAndReimport();
            }
        }
    }
}