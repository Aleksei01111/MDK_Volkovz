using System.Windows;

namespace MDK_Volkov.Practice_4;

public partial class WinStartMain : Window
{
    public WinStartMain()
    {
        InitializeComponent();
        
        MainFrame.Navigate(new PageStartMenu());
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        MainFrame.Visibility = Visibility.Visible;
    }
}