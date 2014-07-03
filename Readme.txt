NikonikoプラグインはTracでニコニコカレンダーを提供します。
ニコニコカレンダーの説明は下記を参照してください。
http://www.geocities.jp/nikonikocalendar/index_ja.html

もともとは Brett Smith氏がTrac0.10系で作成したプラグインです。
http://trac-hacks.org/wiki/NikoNikoPlugin

それを元に0.12系に移行しました。
Tracは0.11よりTemplateエンジンにGenshiを採用しました。
今回の修正はそれに対応するものです。
また、著者の独断と偏見により、キャラクターにはやる夫を採用しております。


なお、噴出しのCSSは下記のページを参考にしました。
http://www.k5.dion.ne.jp/~i-araki/css/popup.html

[導入方法]
1. 任意のバージョンのフォルダに移動して下記のコマンドを実行します。
  python setup.py install

2. Apachを起動します。

3. Tracの管理者権限でログインして管理メニューを開きます。

4. プラグインの追加でNIKONIKOを選択します。

5. 初めて、Nikonikoプラグインを選択した場合、エラーがでます。
　これはNikoNikoプラグインで使用しているDBが存在しないからです。
　そこで、プログラムメニューのTrac中にあるコマンドプロンプトを立ち上げ、
　Trac-Adminを使用してDBのアップグレードをします。
　以下のコマンドを実行してください。この際、Apachを一旦停止しておきましょう。
　
　 Trac-Admin "プロジェクトのFullPath" upgrade 

6. 各ユーザーに下記の権限を割り当てます。
　　NIKONIKO_CHANGE
    NIKONIKO_VIEW

7. やったね、やる夫、ニコニコカレンダーがつかえるよ！
