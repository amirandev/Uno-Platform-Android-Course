using SampleApp.Screens;

namespace SampleApp.Screens.Auth;

public sealed partial class LoginPage : Page
{
    public LoginPage()
    {
        this.InitializeComponent();
    }

    void OnLoginClicked(object sender, RoutedEventArgs e)
    {
        var username = UsernameBox.Text;
        var password = PasswordBox.Password;

        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            return;

        Frame.Navigate(typeof(HomePage));
    }
}
