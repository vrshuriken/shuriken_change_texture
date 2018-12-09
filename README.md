# shuriken_change_texture
Unity Extending the Editor. Easily change texture type.

## できること
Assets以下に置いた画像をVRChatでワールドに画像を配置するための設定に一括で変更できます。  
画像サイズを減らしスプライトに設定します。

## 動作確認環境
Unity 5.6.3p1

## 導入方法
Editor/ShurikenChangeTexture.cs  
をEditorフォルダごとUnityのAssets直下にコピーしてください。  
UnityのAssets > (画像ファイル選択し)右クリックメニュー に「Shuriken ChangeTexture」が追加されます。

## 利用方法
### 1
この設定が以下手順で変更されます。  
![2018-12-09 4](https://user-images.githubusercontent.com/45710234/49694462-ee51b600-fbcd-11e8-9b78-dbf93e8a9b6f.png)  
![2018-12-09 7](https://user-images.githubusercontent.com/45710234/49694465-f7db1e00-fbcd-11e8-97ff-1242a1a5cf91.png)  
Assets以下に置いた画像（複数可能）を右クリックし「Shuriken ChangeTexture」選択。  

### 2
![2018-12-09 5](https://user-images.githubusercontent.com/45710234/49694477-19d4a080-fbce-11e8-98d5-41673042f3b1.png)  
「設定する」を押下。  

### 3
画像の設定が変わります。  
![2018-12-09 8](https://user-images.githubusercontent.com/45710234/49694480-3b358c80-fbce-11e8-914e-2eab21860181.png)  
![2018-12-09 9](https://user-images.githubusercontent.com/45710234/49694483-4983a880-fbce-11e8-9102-10fbc0d50c04.png)  

### 4
画像はHierarchy上にD&Dすればワールドに表示できます。  
![2018-12-09 11](https://user-images.githubusercontent.com/45710234/49694503-b72fd480-fbce-11e8-97db-6e8ddc64f1b4.png)  
表示サイズはScaleを変更してください。
