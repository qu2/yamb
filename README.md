# yamb
ミナコイが使えるブラウザです。  
  yet another minakoi browser の頭文字をとって命名しました。  
    読み方は"やむ"です。  
      開発言語はC#です。  
  Genesisという開発チームを立ち上げて作成しています。
## Download
[ダウンロードはこちら](http://ux.getuploader.com/djlipton/download/174/yamb.exe "Download")からできます。  
  パスワードは114514です。
## Version
1.0.0 - beta 2.1
## How To
### 機能(F)
##### 荒らし
連投や自動で対象ルームに居座ること(駐屯)ができます。  
  現バージョンではループ処理ができず、うまく動かないです。  
    後述するProModeをオンにすると使用できるようになります。(動くとは言ってない)
##### 魚拓
archive.isを開き、魚拓を取ることができます。  
  URL Inputを押すとルームIDを除いたURLがフォームに自動入力されます。
#### UserAgent
UserAgentを偽装することができるようになる予定です。  
  予定なので機能自体が無くなる可能性がとても高いです。
##### ルーム作成
ミナコイのルーム作成ページに飛びます。
### ルーム移動(R)
この項目内にある各項目に飛ぶことができます。ルブルはまだ調整が完全ではないのでyamb上では使わないことを推奨しますが使用したい場合は後述するProModeをオンにしてください。
### yamb(Y)
##### Developers
製作者の情報を見ることができます。特に意味はないです。
#### Source
yambのソースコードが見れます。このページのことです。
### ProMode
オンにすることで不安定や未完全などの理由で通常使用できない機能を開放することができますが、案の定不具合も多いのであまりおすすめはしません。yamb自体を閉じるとオフになります。
## What's New?
・ 起動時のTwitter起動を廃止しました。  
  ・ 小学生ルームへのリンクを追加しました。
## Features
・ 連投、駐屯機能の修正  
  ・ Twitter機能の最適化  
    ・ スクショの範囲と画質や出力形式等の最適化  
      ・ その他起こりうる例外の修正
## Existing Bugs
#### FraudButtons (ID:1)
・ ルブルを開いた状態でTopやルーム作成を押すとミナコイに飛ばされる。  
  → それぞれの箇所に`browser.Url = new Uri("http://www.3751chat.com/");`と`browser.Url = new Uri("http://www.3751chat.com/RoomMake");`が割り当てられている為。修正はするかもしれない。
#### crash_urlBox (ID:2)
・ URL欄にhttp://やhttps://から始まる文字列以外や日本語を入力した時などにyamb本体が強制終了する。  
  → 不明(要検証)
## Support
バグを発見した場合やソースをこうしたらいいのでは？等々の意見は[Twitter(@Lv470)](https://twitter.com/Lv470/ "Twitter")までお願いします。  
  また、ソースの改変等は構いませんが許可なく再配布などを行うことは禁止でお願いします。
## Copyright
&copy; 2016 [@Lv470](https://twitter.com/Lv470/ "Twitter") All Rights Reserved.  
  Author by Genesis Dev Team
