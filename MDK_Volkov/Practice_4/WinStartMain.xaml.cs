using System.Windows;

namespace MDK_Volkov.Practice_4;

public partial class WinStartMain : Window
{
    public WinStartMain()
    {
        InitializeComponent();

        FrameApp.FieldFrameApp = MainFrame;
        MainFrame.Navigate(new PageStartMenu());
    }
}