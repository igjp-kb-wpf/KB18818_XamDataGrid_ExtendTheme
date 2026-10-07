using Infragistics.Themes;

namespace XamDataGrid_ExtendTheme;

/// <summary>
/// Office2013テーマを継承し、XamDataGridの定義ファイルだけを自前のもの
/// (BrandOffice2013Theme.xaml)に差し替えた「社内標準」テーマ。
/// それ以外のコントロールは、基底のOffice2013Themeの設定がそのまま使われる。
/// </summary>
public class BrandOffice2013Theme : Office2013Theme
{
    protected override void ConfigureControlMappings()
    {
        // まず基底クラスの実装を呼び、Office2013Themeの全コントロール分の
        // マッピングを設定しておく。
        base.ConfigureControlMappings();

        // XamDataGridのマッピングだけを自前のリソースディクショナリに差し替える。
        var assemblyFullName = typeof(BrandOffice2013Theme).Assembly.FullName;
        Mappings[ControlMappingKeys.XamDataGrid] =
            ThemeBase.BuildLocationString(assemblyFullName, @"/BrandOffice2013Theme.xaml");
    }
}
