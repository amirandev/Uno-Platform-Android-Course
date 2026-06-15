namespace SampleApp.Partials;

public sealed partial class AppLayout : UserControl
{
    public AppLayout()
    {
        this.InitializeComponent();
    }

    public object BodyContent
    {
        get => GetValue(BodyContentProperty);
        set => SetValue(BodyContentProperty, value);
    }

    public static readonly DependencyProperty BodyContentProperty =
        DependencyProperty.Register(nameof(BodyContent), typeof(object), typeof(AppLayout), new PropertyMetadata(null));
}
