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