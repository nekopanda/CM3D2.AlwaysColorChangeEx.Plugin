CM3D2.AlwaysColorChangeEx.Plugin
---

パーツごとに色変更やパラメータ調整を可能とするプラグインです。  
まだまだ不具合が残っている可能性があります。

オリジナル作者である[kf-cm3d2](https://github.com/kf-cm3d2) さんとは別人による改造版です。  
[オリジナル](https://github.com/kf-cm3d2/CM3D2.AlwaysColorChange.Plugin)から改造しすぎたため、拡張版として別プロジェクト化しました。  

---
## ■ 導入
#### ◇前提条件  
UnityInjectorが導入済みであること

#### ◇動作確認環境
  **1.23**

#### ◇インストール  

[Releases](https://github.com/trzr/CM3D2.AlwaysColorChangeEx.Plugin/releases)ページから、対応するバージョンのzipファイルをダウンロードし、  
解凍後、UnityInjectorフォルダ以下をプラグインフォルダにコピーしてください。

#### ◇自分でコンパイルする場合  
compile.batをサンプルで用意しています。  
レジストリが正しく設定されていればそのままコンパイルできます。  
もし、レジストリの状態と異なるCM3D2ディレクトリを使いたい場合は、  
cmpile.batファイルの以下の環境変数のパスを設定して、バッチを実行してください。
* CM3D2_DIR=C:\KISS\CM3D2  

## ■ 機能概要
#### ◇対象シーン
 * メイドエディット
 * 男エディット  (**New!**)
 * 夜伽
 * ダンス
 * ADVパート
 * イベント回想

で動作します。

★ 撮影モードや他プラグインで操作対象のメイドを非表示にした場合、  
　強制的に **メイド選択画面** になります。

##### ◇機能説明（概要）
* **メイド選択**  
  操作対象のメイドを選択します。  
  撮影モードや他プラグインで複数メイドを表示した場合に利用してください。
* **マスク選択**  
  maskItemで消去されているアイテムを表示させることができます。  
   マスクアイテム選択画面で、各スロットのマスクの有無を指定してください。  
  「適用」ボタンで反映します。
* **表示ノード選択**   
  ノード（身体の部位）の表示・非表示を切り替えられます。  
  「適用」ボタンで反映します。
* **プリセット保存**  
  現在の衣装・設定値をプリセットとして保存します。  
  プリセット適用で呼び出すことがます。  
  - マスククリアを有効にする  
    プリセット適用時、マスククリアを適用するようにします  
    （個々のマスク状態は未対応）
  - 身体も保存する  
    髪型・顔等も保存します。（プリセットの服／体と同等）
* **プリセット適用**  
  保存したプリセットを選択・適用します。
* **menueエクスポート**  
  現在の選択スロットのアイテムをエクスポートします。  
  関連するめくれやずらしmodelなどにも対応
* **テクスチャ変更**  
  テクスチャファイル選択による変更と、スライダーによる色変更が可能です。  
  - ファイル選択によるテクスチャ変更  
    CM3D2のarcに同梱されているtexファイル、あるいはMODに登録されているtexファイルは、    
    テキストフィールドにファイル名を指定する事で適用できます(.tex省略可能)  
    それ以外のファイルは、「...」ボタンから参照してください。  
    「...」ボタンからファイル参照画面が表示されるので、対象ファイルを選択して、「選択」ボタンを押下することでテクスチャが適用されます。  

    ※　texファイルはMODフォルダ以下など、CM3D2から読み込めるパスに存在する必要あり。  
    pngはダイアログで選択できればパスは任意  
    *対応形式* :.tex, .png
  - スライダーによる色変更  
    freeカラー選択時は変更できません。  
   「保存」ボタンでテクスチャ出力に対応(0.0.5.1～)

## ■ 使用方法
##### ◇メニュー操作
F12キーでメニューが開きます。  
キーを変更したい場合は、
* Config/AlwaysColroChangeEx.ini

のToggleWindowキーで指定してください。  
iniファイルの詳細は[wiki](https://github.com/trzr/CM3D2.AlwaysColorChangeEx.Plugin/wiki/ini%E3%83%95%E3%82%A1%E3%82%A4%E3%83%AB)を参照

![GUI](http://i.imgur.com/sMm5lo9.jpg  "GUI")

### ■ [画面説明](https://github.com/trzr/CM3D2.AlwaysColorChangeEx.Plugin/wiki/%E7%94%BB%E9%9D%A2%E8%AA%AC%E6%98%8E)

### ■ [既知の問題](https://github.com/trzr/CM3D2.AlwaysColorChangeEx.Plugin/wiki/Known-Issue)

### ■ [TODO](https://github.com/trzr/CM3D2.AlwaysColorChangeEx.Plugin/wiki/TODO)

## ■ 権利

* オリジナルの作者である[kf-cm3d2](https://github.com/kf-cm3d2)さんの
意向である以下に従ってください。  
(オリジナルの[プロジェクト](https://github.com/kf-cm3d2/CM3D2.AlwaysColorChange.Plugin)READMEに記載)
~~~
ソースの改変・再配布等は自由にしていただいてかまいません。  
むしろやりたいこと・それを超える機能を実装してくれる人歓迎。  
~~~

## ■ 更新履歴
#### 0.1.1.1 (最新版)
 * 機能拡張 (**Enhance**)
  * 男エディット画面を動作対象に追加
  * メイド選択画面で、男を選択可能に
  * スロット名の表記を英字に切替えるトグルを追加
 * 修正 (**Fixed**)
  * 色変更スライダーのα値の範囲ミスを修正
    - 正：0～1
    - 誤：0～2
  * テクスチャ変更画面
    png出力時の例外発生を抑制
  * ファイル参照ダイアログのホイール誤作動を修正
 * その他 (**Misc**)
  * README修正


#### 以前の更新履歴
 * [Releases](https://github.com/trzr/CM3D2.AlwaysColorChangeEx.Plugin/Releases)を参照
 * プロジェクトリネーム( **0.1.0.0** )以前の履歴は、[旧プロジェクト](https://github.com/trzr/CM3D2.AlwaysColorChange.Plugin#-%E6%9B%B4%E6%96%B0%E5%B1%A5%E6%AD%B4)を参照
