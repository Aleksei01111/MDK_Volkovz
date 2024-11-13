using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace MDK_Volkov.Practice_4;

public partial class WinStartMain
{
    private readonly ThicknessAnimation _menuAnimation = new()
    {
        Duration = TimeSpan.FromMilliseconds(200),
        EasingFunction = new QuadraticEase { EasingMode = EasingMode.EaseInOut }
    };
    private readonly Thickness _openedMenuThickness;
    private readonly Thickness _closedMenuThickness;
    
    private bool _isMenuOpen;
    
    public WinStartMain()
    {
        InitializeComponent();
        
        _closedMenuThickness = Menu.Margin;
        _openedMenuThickness = new Thickness(0, Menu.Margin.Top, Menu.Margin.Right, Menu.Margin.Bottom);
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        MainFrame.Navigate(new PageStartMenu());
    }

    private void CloseMenu_MouseLeave(object sender, MouseEventArgs e)
    {
        if (!_isMenuOpen)
            return;
        
        _menuAnimation.From = _openedMenuThickness;
        _menuAnimation.To = _closedMenuThickness;
        Menu.BeginAnimation(FrameworkElement.MarginProperty, _menuAnimation);
        
        _isMenuOpen = false;
    }

    private void OpenMenu_OnClick(object sender, RoutedEventArgs e)
    {
        if (_isMenuOpen)
            return;
        
        _menuAnimation.From = _closedMenuThickness;
        _menuAnimation.To = _openedMenuThickness;
        Menu.BeginAnimation(FrameworkElement.MarginProperty, _menuAnimation);
        
        _isMenuOpen = true;
    }
}