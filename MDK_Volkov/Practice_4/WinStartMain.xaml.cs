using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace MDK_Volkov.Practice_4;

public partial class WinStartMain
{
    private readonly List<Page> _menuItems = new();
    
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
        
        _menuItems.Add(new PageStartMenu());
        DataContext = new MenuContext {MenuItems = _menuItems};
        
        _closedMenuThickness = MenuBox.Margin;
        _openedMenuThickness = new Thickness(0, MenuBox.Margin.Top, MenuBox.Margin.Right, MenuBox.Margin.Bottom);
    }

    private void CloseMenu_MouseLeave(object sender, MouseEventArgs e)
    {
        if (!_isMenuOpen)
            return;
        
        _menuAnimation.From = _openedMenuThickness;
        _menuAnimation.To = _closedMenuThickness;
        MenuBox.BeginAnimation(FrameworkElement.MarginProperty, _menuAnimation);
        
        _isMenuOpen = false;
    }

    private void OpenMenu_OnClick(object sender, RoutedEventArgs e)
    {
        if (_isMenuOpen)
            return;
        
        _menuAnimation.From = _closedMenuThickness;
        _menuAnimation.To = _openedMenuThickness;
        MenuBox.BeginAnimation(FrameworkElement.MarginProperty, _menuAnimation);
        
        _isMenuOpen = true;
    }
}