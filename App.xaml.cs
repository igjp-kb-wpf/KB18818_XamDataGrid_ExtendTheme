using System.Windows;

namespace XamDataGrid_ExtendTheme;

/// <summary>
/// このサンプルでは、標準テーマと拡張テーマを同じ画面で見比べられるよう、
/// ThemeManager.ApplicationTheme(アプリ全体)ではなく、
/// 画面内の領域ごとに ThemeManager.Theme 添付プロパティでテーマを適用している。
/// アプリ全体に適用する場合は OnStartup で
/// ThemeManager.ApplicationTheme = new BrandOffice2013Theme(); とする。
/// </summary>
public partial class App : Application
{
}
