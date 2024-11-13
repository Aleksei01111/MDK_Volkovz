using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace MDK_Volkov.Practice_4;

public interface IPageMenuItem
{
    string Title { get; }
    Page Page { get; }
}

public class PageMenuItem(string title, Page page) : IPageMenuItem
{
    public string Title { get; } = title;
    public Page Page { get; } = page;
}

public class MenuContext : INotifyPropertyChanged
{
    private IPageMenuItem _selectedItem;
    
    public List<IPageMenuItem> MenuItems { get; init; } = new();

    public IPageMenuItem SelectedItem
    {
        get => _selectedItem;
        set
        {
            _selectedItem = value;
            OnPropertyChanged();
        }
    }
    
    public event PropertyChangedEventHandler? PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}