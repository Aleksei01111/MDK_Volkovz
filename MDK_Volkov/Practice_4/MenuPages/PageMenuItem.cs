using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace MDK_Volkov.Practice_4;

public class MenuContext : INotifyPropertyChanged
{
    private Page _selectedItem;
    
    public List<Page> MenuItems { get; init; } = new();

    public Page SelectedItem
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