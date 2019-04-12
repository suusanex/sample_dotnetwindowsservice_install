# 概要

.NETで作成したWindowsサービスをインストールする上で、InstallUtil.exeもWindowsインストーラも使わずにインストールする方法のサンプルコード。

.NET Framework 4.5.2を使用した。

# 説明

TestServiceInstallApp.exeとTestService1.exeを同じフォルダに置き、TestServiceInstallApp.exeを実行します。

Installボタンでインストールし、Uninstallボタンでアンインストールします。

ログはそれぞれInstallLog.txt、UnInstallLog.txtに出力され、エラー発生時のコールスタックも出力されます。
