# PaelsWingFix

修复《杀戮尖塔 2》0.111.0 Beta 中多个佩尔之翼导致卡牌奖励无法打开的问题。每次献祭分别结算各个翅膀。无需 RitsuLib 或新三国。

将 PaelsWingFix.dll 和 PaelsWingFix.json 放入游戏目录下的 mods/PaelsWingFix 文件夹。

使用 .NET SDK 构建。Sts2DataDir 指向游戏目录中的 data_sts2_windows_x86_64。

```powershell
dotnet build -c Release "-p:Sts2DataDir=<游戏程序集目录>"
```
