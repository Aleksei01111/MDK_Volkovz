using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace MDK_Volkov.Practice_4;

public partial class WinStartMain
{
    private bool _isMenuOpen;
    public WinStartMain()
    {
        InitializeComponent();
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(new PageStartMenu());
    }

    private void CloseMenu_MouseLeave(object sender, MouseEventArgs e)
    {
        if (!_isMenuOpen)
            return;
        
        var closeMenuAnimation = new ThicknessAnimation
        {
            Duration = new Duration(TimeSpan.FromMilliseconds(500)),
            To = new Thickness(-180, 0, 0, 0),
            From = new Thickness(0, 0, 0, 0),
            EasingFunction = new CubicEase { EasingMode = EasingMode.EaseInOut }
        };

        closeMenuAnimation.Completed += (o, args) =>
        {
            _isMenuOpen = false;
        };
        Menu.BeginAnimation(FrameworkElement.MarginProperty, closeMenuAnimation);
    }

    private void OpenMenu_MouseEnter(object sender, MouseEventArgs e)
    {
        if (_isMenuOpen)
            return;
        
        var openMenuAnimation = new ThicknessAnimation
        {
            Duration = new Duration(TimeSpan.FromMilliseconds(200)),
            To = new Thickness(0, 0, 0, 0),
            From = new Thickness(-180, 0, 0, 0),
            EasingFunction = new CubicEase { EasingMode = EasingMode.EaseIn }
        };

        openMenuAnimation.Completed += (o, args) =>
        {
            _isMenuOpen = true;
        };
        Menu.BeginAnimation(FrameworkElement.MarginProperty, openMenuAnimation);
        
    }
}