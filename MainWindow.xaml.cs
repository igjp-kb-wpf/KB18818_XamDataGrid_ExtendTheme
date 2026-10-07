using System.Windows;

namespace XamDataGrid_ExtendTheme;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
}
