using System.Collections.ObjectModel;
using SampleApp.Models;

namespace SampleApp.Screens;

public sealed partial class HomePage : Page
{
    public HomePage()
    {
        this.InitializeComponent();
        LoadItems();
    }

    void LoadItems()
    {
        var items = new ObservableCollection<GridItem>
        {
            new() { Title = "Documents", Icon = "\uE8A5" },
            new() { Title = "Pictures", Icon = "\uEB9F" },
            new() { Title = "Music", Icon = "\uEC4F" },
            new() { Title = "Videos", Icon = "\uE714" },
            new() { Title = "Downloads", Icon = "\uE896" },
            new() { Title = "Settings", Icon = "\uE713" },
            new() { Title = "Favorites", Icon = "\uE113" },
            new() { Title = "Cloud", Icon = "\uE753" },
        };
        ItemsGrid.ItemsSource = items;
    }

    void OnItemClick(object sender, ItemClickEventArgs e)
    {
        var item = e.ClickedItem as GridItem;
    }
}
