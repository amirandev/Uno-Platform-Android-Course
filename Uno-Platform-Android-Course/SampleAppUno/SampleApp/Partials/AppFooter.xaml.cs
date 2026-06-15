namespace SampleApp.Partials;

public sealed partial class AppFooter : UserControl
{
    public AppFooter()
    {
        this.InitializeComponent();
    }

    void OnHomeTapped(object sender, TappedRoutedEventArgs e) { }
    void OnSearchTapped(object sender, TappedRoutedEventArgs e) { }
    void OnFavoritesTapped(object sender, TappedRoutedEventArgs e) { }
    void OnProfileTapped(object sender, TappedRoutedEventArgs e) { }
}
