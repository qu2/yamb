# yamb
ミナコイが使えるブラウザです。  
  yet another minakoi browser の頭文字をとって命名しました。  
    読み方は"やむ"です。  
      開発言語はC#です。
## Download
[ダウンロードはこちら](http://ux.getuploader.com/exe_exe/download/92/yamb.exe "Download")からできます。  
  パスワードは114514です。
## Version
1.0.0 - beta 1.1
## How To
### 機能(F)
##### 荒らし
連投や自動で対象ルームに居座ること(駐屯)ができます。  
  現バージョンではループ処理ができず、うまく動かないです。
##### 魚拓
archive.isを開き、魚拓を取ることができます。  
  URL Inputを押すとルームIDを除いたURLがフォームに自動入力されます。
##### ルーム作成
ミナコイのルーム作成ページに飛びます。
### ルーム移動(R)
この項目内にある各項目に飛ぶことができます。ルブルはまだ調整が完全ではないのでyamb上では使わないことを推奨します。
### yamb(Y)
##### Developers
製作者の情報を見ることができます。特に意味はないです。
## What's New?
・ プロジェクトチームGenesisの仕様に対応
## Features
・ 連投、駐屯機能の修正  
  ・ Twitter連携のようなもの  
    ・ スクショの範囲と画質や出力形式等の最適化  
      ・ その他起こりうる例外の修正
## Existing Bugs
・ ルブルを開いた状態でTopやルーム作成を押すとミナコイに飛ばされる。  
  → それぞれの箇所に`browser.Url = new Uri("http://www.3751chat.com/");`と`browser.Url = new Uri("http://www.3751chat.com/RoomMake");`が割り当てられている為。修正はするかもしれない。
## Support
バグを発見した場合やソースをこうしたらいいのでは？等々の意見は[Twitter(@Lv470)](https://twitter.com/Lv470/ "Twitter")までお願いします。  
  また、ソースの改変等は構いませんが許可なく再配布などを行うことは禁止でお願いします。
## Copyright
&copy; 2016 [@Lv470](https://twitter.com/Lv470/ "Twitter") All Rights Reserved.
