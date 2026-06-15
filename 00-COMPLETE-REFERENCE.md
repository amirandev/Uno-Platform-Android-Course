# Uno Platform / WinUI 3 — Complete Reference

---

## 1. ALL UI COMPONENTS (Controls Catalog)

### Layout Containers
| Control | Description | Key Props |
|---------|-------------|-----------|
| `Grid` | Table-like rows/cols | `RowDefinitions`, `ColumnDefinitions`, `Grid.Row`, `Grid.Column` |
| `StackPanel` | Vertical/horizontal stack | `Orientation`, `Spacing` |
| `FlexPanel` | Flexbox-like wrap | `Wrap`, `JustifyContent`, `AlignItems`, `Gap` |
| `RelativePanel` | Relative positioning | `RelativePanel.LeftOf`, `RelativePanel.Below`, etc. |
| `Canvas` | Absolute positioning | `Canvas.Left`, `Canvas.Top` |
| `ScrollViewer` | Scrollable content | `HorizontalScrollMode`, `VerticalScrollMode`, `ZoomMode` |
| `Border` | Single-child container with decoration | `Background`, `BorderBrush`, `BorderThickness`, `CornerRadius`, `Padding` |
| `Viewbox` | Scale content | `Stretch`, `StretchDirection` |
| `VariableSizedWrapGrid` | Tiled grid | `ItemWidth`, `ItemHeight`, `MaximumRowsOrColumns` |
| `ItemsRepeater` | Lightweight list | `ItemsSource`, `ItemTemplate`, `Layout` |

### Content Controls
| Control | Description | Key Props |
|---------|-------------|-----------|
| `ContentControl` | Single content item | `Content`, `ContentTemplate` |
| `ContentPresenter` | Content placeholder in templates | `Content`, `ContentTemplate` |
| `Frame` | Navigation host | `SourcePageType`, `BackStack`, `ForwardStack` |
| `UserControl` | Custom composable control | — |
| `Page` | Navigation page | `Frame`, `NavigationCacheMode` |
| `AppBar` | Top command bar | `Content`, `IsOpen`, `IsSticky` |
| `CommandBar` | App bar with commands | `PrimaryCommands`, `SecondaryCommands` |
| `ToolTip` | Hover tooltip | `Content`, `Placement` |
| `Flyout` | Lightweight popup | `Content`, `Placement` |
| `Popup` | Modal overlay | `Child`, `IsOpen`, `IsLightDismissEnabled` |
| `ContentDialog` | Modal dialog | `Title`, `Content`, `PrimaryButtonText`, `CloseButtonText` |

### Text Controls
| Control | Description | Key Props |
|---------|-------------|-----------|
| `TextBlock` | Read-only text | `Text`, `FontSize`, `FontWeight`, `Foreground`, `TextWrapping`, `TextTrimming`, `LineHeight`, `TextAlignment`, `Padding` |
| `TextBox` | Editable text | `Text`, `PlaceholderText`, `MaxLength`, `AcceptsReturn`, `TextWrapping`, `IsReadOnly`, `CornerRadius`, `Header`, `PlaceholderForeground`, `SelectionHighlightColor` |
| `PasswordBox` | Password input | `Password`, `PlaceholderText`, `IsPasswordRevealModeEnabled`, `PasswordChar`, `CornerRadius` |
| `RichEditBox` | Rich text editor | `Document`, `IsReadOnly`, `AcceptsReturn` |
| `AutoSuggestBox` | Search with suggestions | `Text`, `ItemsSource`, `PlaceholderText`, `TextChanged`, `SuggestionChosen`, `QueryIcon` |
| `NumberBox` | Numeric input | `Value`, `Minimum`, `Maximum`, `SmallChange`, `LargeChange`, `SpinButtonPlacementMode`, `NumberFormatter` |
| `RichTextBlock` | Rich text display | `Blocks`, `OverflowContentTarget` |
| `Label` | Simple label (rare) | `Content`, `Target` |

### Button Controls
| Control | Description | Key Props |
|---------|-------------|-----------|
| `Button` | Standard click button | `Content`, `Click`, `Command`, `CommandParameter`, `CornerRadius`, `Background`, `Foreground`, `BorderBrush`, `BorderThickness`, `Padding`, `HorizontalAlignment`, `VerticalAlignment`, `FontSize`, `FontWeight`, `Height`, `Width`, `MinWidth`, `MinHeight`, `MaxWidth`, `MaxHeight`, `IsEnabled`, `Visibility`, `Opacity`, `RenderTransform`, `TabIndex`, `IsTabStop`, `ToolTipService.ToolTip`, `AutomationProperties.AutomationId` |
| `HyperlinkButton` | Text link | `NavigateUri`, `Content` |
| `RepeatButton` | Fires repeatedly while held | `Interval`, `Delay` |
| `ToggleButton` | On/off state | `IsChecked`, `IsThreeState` |
| `ToggleSplitButton` | Split button with toggle | `IsChecked`, `Command` |
| `DropDownButton` | Button with dropdown | `Flyout` |
| `SplitButton` | Action + dropdown | `Command`, `Flyout` |
| `AppBarButton` | Toolbar button | `Label`, `Icon`, `IsCompact`, `IsToggleButton` |
| `AppBarToggleButton` | Toggle toolbar button | `IsChecked`, `Label`, `Icon` |
| `RadioButton` | Single-select option | `IsChecked`, `GroupName` |
| `CheckBox` | Multi-select option | `IsChecked`, `IsThreeState`, `Content` |
| `ToggleSwitch` | Toggle on/off | `IsOn`, `OnContent`, `OffContent`, `Header` |
| `RatingControl` | Star rating | `Value`, `MaxRating`, `PlaceholderValue`, `IsReadOnly`, `ItemInfo` |

### Item Controls
| Control | Description | Key Props |
|---------|-------------|-----------|
| `ListView` | Vertical list (virtualized) | `ItemsSource`, `ItemTemplate`, `SelectionMode`, `IsItemClickEnabled`, `ItemClick`, `Header`, `Footer`, `GroupStyle`, `DataFetchSize`, `IncrementalLoadingThreshold`, `IncrementalLoadingTrigger` |
| `GridView` | Grid layout (virtualized) | Same as ListView + `DesiredWidth` |
| `ComboBox` | Dropdown list | `ItemsSource`, `SelectedItem`, `SelectedIndex`, `PlaceholderText`, `IsEditable` |
| `ListBox` | Selectable list (non-virtualized) | `ItemsSource`, `SelectedItem`, `SelectionMode` |
| `FlipView` | Swipeable gallery | `ItemsSource`, `SelectedItem`, `UseTouchAnimationsForAllNavigation` |
| `ItemsControl` | Basic items host | `ItemsSource`, `ItemTemplate` |
| `Pivot` | Tab-like pages | `ItemsSource`, `SelectedIndex`, `LeftHeader`, `RightHeader`, `PivotItem.Header` |
| `TabView` | Browser-like tabs | `TabItems`, `TabStripPlacement`, `CanDragTabs`, `CanReorderTabs`, `AddTabButtonCommand` |
| `MenuBar` | Desktop menu | `Items` |
| `TreeView` | Hierarchical tree | `ItemsSource`, `SelectionMode`, `CanDragItems`, `CanReorderItems` |
| `InfoBar` | Severity message | `Title`, `Message`, `Severity` (Information/Warning/Error/Success), `IsOpen`, `IsClosable`, `ActionButton` |

### Media Controls
| Control | Description | Key Props |
|---------|-------------|-----------|
| `Image` | Display image | `Source`, `Stretch`, `StretchDirection`, `CornerRadius` |
| `BitmapIcon` | Icon from bitmap | `UriSource`, `ShowAsMonochrome` |
| `FontIcon` | Icon from font glyph | `Glyph`, `FontSize`, `FontFamily`, `Foreground` |
| `SymbolIcon` | WinUI symbol icon | `Symbol` (enum: Home, Search, Settings, etc.) |
| `PathIcon` | Icon from path data | `Data` (Geometry string) |
| `AnimatedVisualPlayer` | Lottie animation | `Source`, `AutoPlay`, `IsPlaying` |
| `MediaPlayerElement` | Video/audio playback | `Source`, `AutoPlay`, `AreTransportControlsEnabled`, `Stretch`, `PosterSource` |
| `WebView2` | Web browser | `Source`, `CoreWebView2`, `NavigationStarting`, `NavigationCompleted`, `ScriptNotify`, `ExecuteScriptAsync` |
| `MapControl` | Map view | `Center`, `ZoomLevel`, `MapServiceToken`, `Style`, `Pitch`, `Heading` |
| `InkCanvas` | Drawing surface | `InkPresenter` |
| `SvgImageSource` | SVG rendering | `UriSource` |
| `CaptureElement` | Camera preview | `Source` |

### Shape Controls (SkiaSharp-based)
| Control | Description |
|---------|-------------|
| `Rectangle` | `Fill`, `Stroke`, `StrokeThickness`, `RadiusX`, `RadiusY` |
| `Ellipse` | `Fill`, `Stroke`, `StrokeThickness` |
| `Line` | `X1`, `Y1`, `X2`, `Y2`, `Stroke`, `StrokeThickness` |
| `Polyline` | `Points`, `Stroke`, `StrokeThickness` |
| `Polygon` | `Points`, `Fill`, `Stroke`, `StrokeThickness` |
| `Path` | `Data` (Geometry), `Fill`, `Stroke` |

### Misc Controls
| Control | Description |
|---------|-------------|
| `ProgressBar` | Determinate/indeterminate progress |
| `ProgressRing` | Spinning indicator |
| `Slider` | Range value input |
| `DatePicker` | Date selection |
| `TimePicker` | Time selection |
| `CalendarView` | Calendar grid |
| `CalendarDatePicker` | Date picker with calendar |
| `RefreshContainer` | Pull-to-refresh |
| `RefreshVisualizer` | Refresh animation |
| `SwipeControl` | Swipe actions |
| `ParallaxView` | Parallax scrolling |
| `ColorPicker` | Color chooser |
| `DropDownButton` | Flyout dropdown |
| `TwoPaneView` | Dual-pane layout |
| `NavigationView` | Navigation pane (hamburger menu) |
| `PersonPicture` | Avatar/photo |
| `Badge` (Toolkit) | Notification badge |
| `TabBar` (Toolkit) | Bottom tab navigation |

---

## 2. ALL STYLE PROPERTIES (Per Control)

### Layout Common Properties (all FrameworkElement)
```
Width, Height, MinWidth, MinHeight, MaxWidth, MaxHeight
HorizontalAlignment (Left/Center/Right/Stretch)
VerticalAlignment (Top/Center/Bottom/Stretch)
Margin (Left,Top,Right,Bottom)
Padding (Left,Top,Right,Bottom)
Visibility (Visible/Collapsed)
Opacity (0.0–1.0)
IsHitTestVisible
IsEnabled
RenderTransform (TranslateTransform, RotateTransform, ScaleTransform, SkewTransform, CompositeTransform, TransformGroup)
RenderTransformOrigin
Projection (PlaneProjection)
UseLayoutRounding
Tag
FlowDirection (LeftToRight/RightToLeft)
```

### TextBlock Style Properties
```
FontFamily, FontSize, FontWeight (Thin/Light/SemiLight/Regular/Medium/SemiBold/Bold/ExtraBold/Black/ExtraBlack)
FontStyle (Normal/Italic/Oblique)
FontStretch
Foreground, Background
TextAlignment (Left/Center/Right/Justify)
TextWrapping (NoWrap/Wrap/WrapWholeWords)
TextTrimming (None/CharacterEllipsis/WordEllipsis/Clip)
LineHeight, LineStackingStrategy
MaxLines
TextDecorations (None/Underline/Strikethrough/Overline/Baseline)
CharacterSpacing
IsTextScaleFactorEnabled
OpticalMarginAlignment
HorizontalTextAlignment
Padding
CornerRadius
```

### Button Style Properties
```
Content, ContentTemplate, ContentTemplateSelector
Command, CommandParameter
ClickMode (Release/Press/Hover)
CornerRadius (TopLeft,TopRight,BottomRight,BottomLeft)
Background, Foreground, BorderBrush, BorderThickness
Padding, FontFamily, FontSize, FontWeight, FontStyle
BackgroundSizing (OuterBorderEdge/InnerBorderEdge)
FocusVisualPrimaryBrush, FocusVisualSecondaryBrush
FocusVisualMargin, FocusVisualThickness
KeyboardAccelerators
AllowFocusOnInteraction
AllowDrop
TabIndex, IsTabStop
```

### Border Style Properties
```
Background, BorderBrush, BorderThickness, CornerRadius
Padding, Child, ChildTransitions, BackgroundSizing
```

### TextBox Style Properties
```
Text, PlaceholderText, PlaceholderForeground
Header, HeaderTemplate
MaxLength, IsReadOnly, IsSpellCheckEnabled, IsTextPredictionEnabled
HorizontalTextAlignment
CornerRadius, Background, Foreground, BorderBrush, BorderThickness
SelectionHighlightColor, SelectionHighlightColorWhenNotFocused
TextWrapping, AcceptsReturn
InputScope (Text/Url/Email/Number/Telephone/Search/Maps/PersonalFullName/etc.)
DesiredCandidateWindowAlignment
PreventKeyboardDisplayOnProgrammaticFocus
IsTabStop, TabIndex
```

### ListView/GridView Style Properties
```
ItemsSource, ItemTemplate, ItemTemplateSelector
GroupStyle, GroupHeaderTemplate
SelectionMode (None/Single/Multiple/Extended)
IsItemClickEnabled, IsSwipeEnabled
CanDragItems, CanReorderItems
ReorderMode, DragItemsStarting, DragItemsCompleted
ContainerContentChanging
Header, HeaderTemplate, HeaderTransitions
Footer, FooterTemplate, FooterTransitions
ItemContainerStyle, ItemContainerStyleSelector
ItemContainerTransitions
ItemsPanel, ItemsUpdatingScrollMode
ScrollViewer.HorizontalScrollBarVisibility
ScrollViewer.VerticalScrollBarVisibility
DataFetchSize, IncrementalLoadingThreshold, IncrementalLoadingTrigger
ShowsScrollingPlaceholders
```

### Image Style Properties
```
Source (BitmapImage, SvgImageSource, RenderTargetBitmap)
Stretch (None/Fill/Uniform/UniformToFill)
StretchDirection (UpOnly/DownOnly/Both)
NineGrid (Left,Top,Right,Bottom)
CornerRadius
GetAlphaMask() (method)
MonochromeColor
```

### StackPanel Style Properties
```
Orientation (Horizontal/Vertical)
Spacing
Background, BorderBrush, BorderThickness, CornerRadius
HorizontalAlignment, VerticalAlignment
Padding, Margin
AreScrollSnapPointsRegular
```

### Grid Style Properties
```
RowDefinitions, ColumnDefinitions
RowSpacing, ColumnSpacing
Padding, CornerRadius, Background
HorizontalAlignment, VerticalAlignment
IsItemsHost, AreScrollSnapPointsRegular
```
**Attached:**
```
Grid.Row (int), Grid.Column (int)
Grid.RowSpan (int), Grid.ColumnSpan (int)
```

### ScrollViewer Style Properties
```
HorizontalScrollBarVisibility (Disabled/Auto/Hidden/Visible)
VerticalScrollBarVisibility
HorizontalScrollMode (Disabled/Auto/Enabled)
VerticalScrollMode
ZoomMode (Disabled/Auto/Enabled)
Content
HorizontalSnapPointsType, VerticalSnapPointsType
HorizontalSnapPointsAlignment, VerticalSnapPointsAlignment
IsScrollInertiaEnabled
IsRailEnabled
IsDeferredScrollingEnabled
ViewportWidth, ViewportHeight, ScrollableWidth, ScrollableHeight
ExtentWidth, ExtentHeight
ComputedHorizontalScrollBarVisibility, ComputedVerticalScrollBarVisibility
```

### Slider Style Properties
```
Minimum, Maximum, SmallChange, LargeChange
Value, SnapToTickFrequency
TickFrequency, TickPlacement (None/TopLeft/BottomRight/Outside)
Orientation
IsDirectionReversed, IsThumbToolTipEnabled
StepFrequency, ThumbToolTipValueConverter
Header
```

### Pivot Style Properties
```
ItemsSource, SelectedIndex, SelectedItem
LeftHeader, RightHeader
Title, Subtitle
IsHeaderItemsCarouselEnabled
HeaderFocusVisualPlacement
TabFlowItemWidthMode
PivotItem: Header (string or object)
```

### TabView Style Properties
```
TabItemsSource, SelectedIndex, SelectedItem
CanDragTabs, CanReorderTabs
AddTabButtonCommand
TabStripPlacement (Top/Left/Bottom/Right)
TabWidthMode (Equal/SizeToContent/Compact)
IsAddTabButtonVisible
TabItemTemplate, TabItemTemplateSelector
```

### InfoBar Style Properties
```
Title, Message, Severity (Information/Warning/Error/Success)
IsOpen, IsClosable, IsIconVisible
ActionButton
SeverityColorLevel (enum)
Foreground (per severity)
Background (per severity)
```

### NavigationView Style Properties
```
ItemsSource, SelectedItem
Header, HeaderTemplate
AlwaysShowHeaderIsActive
IsPaneOpen, OpenPaneLength, CompactPaneLength
PaneDisplayMode (Auto/LeftCompact/LeftMinimal/Top/Left)
PaneTitle
MenuItemsSource, FooterMenuItemsSource
SettingsItem
MenuItemTemplate
IsBackButtonVisible, IsSettingsVisible
AlwaysShowFooter
```

### Frame Style Properties
```
SourcePageType, BackStack, ForwardStack
IsNavigationStackEnabled
CacheSize
BackStackDepth, ForwardStackDepth
CurrentSourcePageType
```

### MediaPlayerElement Style Properties
```
Source, AutoPlay, AreTransportControlsEnabled
Stretch, PosterSource
IsFullWindow
TransportControls
AudioCategory, AudioDeviceType
Stereo3DVideoPackingMode
RealTimePlayback
```

### RefreshContainer Style Properties
```
RefreshRequested event
Visualizer
PullDirection
RefreshDistanceRatio, RefreshThreshold
```

### Flyout/ContentDialog Style Properties
```
Flyout: Content, FlyoutPresenterStyle, Placement, LightDismissEnabled, OverlayInputPassThroughElement
ContentDialog: Title, TitleTemplate, Content, ContentTemplate, PrimaryButtonText, SecondaryButtonText, CloseButtonText, DefaultButton (None/Primary/Secondary/Close), FullSizeDesired, XYFocusKeyboardNavigation
```

---

## 3. STYLING — Complete Guide

### Defining Styles

```xml
<!-- Named style -->
<Style x:Key="PrimaryButton" TargetType="Button">
    <Setter Property="Background" Value="{ThemeResource SystemAccentColor}" />
    <Setter Property="Foreground" Value="White" />
    <Setter Property="CornerRadius" Value="8" />
    <Setter Property="Height" Value="44" />
    <Setter Property="FontWeight" Value="SemiBold" />
    <Setter Property="Padding" Value="24,0" />
</Style>

<!-- Implicit style (applies to ALL Buttons) -->
<Style TargetType="Button">
    <Setter Property="CornerRadius" Value="4" />
</Style>
```

### Using Styles

```xml
<Button Content="Login" Style="{StaticResource PrimaryButton}" />
```

### Theme Resources (Built-in)

```xml
<!-- Brushes -->
{ThemeResource SystemAccentColor}              — System accent (blue/purple/etc)
{ThemeResource SystemAccentColorLight1}         — Lighter accent
{ThemeResource SystemAccentColorDark1}          — Darker accent
{ThemeResource ApplicationPageBackgroundThemeBrush}  — Page background
{ThemeResource ApplicationForegroundThemeBrush}      — Default text
{ThemeResource SystemControlBackgroundBaseLowBrush}
{ThemeResource SystemControlBackgroundBaseMediumBrush}
{ThemeResource SystemControlBackgroundBaseHighBrush}
{ThemeResource SystemControlForegroundBaseLowBrush}
{ThemeResource SystemControlForegroundBaseMediumBrush}
{ThemeResource SystemControlForegroundBaseHighBrush}
{ThemeResource SystemControlPageBackgroundAltHighBrush}
{ThemeResource SystemControlPageBackgroundAltMediumBrush}
{ThemeResource CardBackgroundFillColorDefaultBrush}
{ThemeResource CardBackgroundFillColorSecondaryBrush}
{ThemeResource ControlElevationBorderBrush}
{ThemeResource SolidBackgroundFillColorBaseBrush}
{ThemeResource SolidBackgroundFillColorSecondaryBrush}
{ThemeResource TextControlBackground}               — TextBox background
{ThemeResource TextControlForeground}               — TextBox text
{ThemeResource TextControlPlaceholderForeground}    — Placeholder text
{ThemeResource TextControlBorderBrush}              — TextBox border
{ThemeResource ButtonBackground}
{ThemeResource ButtonForeground}
{ThemeResource ButtonBorderBrush}
{ThemeResource ListViewItemBackground}
{ThemeResource ListViewItemForeground}

<!-- Dimensions -->
{ThemeResource ControlCornerRadius}                 — System corner radius
{ThemeResource TextControlBorderThemeThickness}

<!-- Fonts -->
{ThemeResource ContentControlThemeFontFamily}
```

### Light/Dark Theme

```xml
<ResourceDictionary ThemeDensity="Compact">
</ResourceDictionary>

<!-- RequestTheme on Page/FrameworkElement -->
<Page RequestedTheme="Dark">
```

### Custom Resource Dictionaries

```xml
<!-- App.xaml -->
<Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <XamlControlsResources xmlns="using:Microsoft.UI.Xaml.Controls" />
            <ResourceDictionary Source="Styles/CustomStyles.xaml" />
        </ResourceDictionary.MergedDictionaries>
        
        <SolidColorBrush x:Key="MyBrandColor" Color="#512BD4" />
    </ResourceDictionary>
</Application.Resources>
```

### Visual States

```xml
<VisualStateManager.VisualStateGroups>
    <VisualStateGroup x:Name="CommonStates">
        <VisualState x:Name="Normal">
            <VisualState.Setters>
                <Setter Target="MyControl.Opacity" Value="1" />
            </VisualState.Setters>
        </VisualState>
        <VisualState x:Name="PointerOver">
            <VisualState.Setters>
                <Setter Target="MyControl.Opacity" Value="0.8" />
            </VisualState.Setters>
        </VisualState>
        <VisualState x:Name="Pressed">
            <Storyboard>
                <DoubleAnimation Storyboard.TargetName="MyControl"
                                 Storyboard.TargetProperty="Opacity"
                                 To="0.5" Duration="0:0:0.1" />
            </Storyboard>
        </VisualState>
        <VisualState x:Name="Disabled">
            <VisualState.Setters>
                <Setter Target="MyControl.Opacity" Value="0.3" />
            </VisualState.Setters>
        </VisualState>
    </VisualStateGroup>
</VisualStateManager.VisualStateGroups>
```

### Control Templates

```xml
<Style TargetType="Button">
    <Setter Property="Template">
        <Setter.Value>
            <ControlTemplate TargetType="Button">
                <Grid>
                    <Border x:Name="Root"
                            Background="{TemplateBinding Background}"
                            CornerRadius="{TemplateBinding CornerRadius}"
                            BorderBrush="{TemplateBinding BorderBrush}"
                            BorderThickness="{TemplateBinding BorderThickness}">
                        <ContentPresenter Content="{TemplateBinding Content}"
                                          HorizontalAlignment="Center"
                                          VerticalAlignment="Center" />
                    </Border>
                    <!-- VisualStates for PointerOver, Pressed, etc -->
                </Grid>
            </ControlTemplate>
        </Setter.Value>
    </Setter>
</Style>
```

---

## 4. DATA PASSING

### 4.1 Between Pages (Navigation)

```csharp
// Send
Frame.Navigate(typeof(DetailPage), new Product { Id = 1 });

// Receive
protected override void OnNavigatedTo(NavigationEventArgs e)
{
    var product = e.Parameter as Product;
    if (product is not null) { /* use */ }
}
```

### 4.2 Via Dependency Injection

```csharp
// Register
services.AddSingleton<ISharedState, SharedState>();

// Both pages get the same instance
public class PageA(ISharedState state) { }
public class PageB(ISharedState state) { }
```

### 4.3 Via Messaging

```csharp
// Install CommunityToolkit.Mvvm for WeakReferenceMessenger

// Message
public record ProductSelectedMessage(Product Product);

// Send
WeakReferenceMessenger.Default.Send(new ProductSelectedMessage(product));

// Receive (register in OnNavigatedTo)
WeakReferenceMessenger.Default.Register<ProductSelectedMessage>(this, (r, m) =>
{
    var product = m.Product;
});
```

### 4.4 Via Static Service

```csharp
public static class Session
{
    public static User? CurrentUser { get; set; }
}
```

### 4.5 Via App Properties

```csharp
(Application.Current as App)?.SomeProperty
```

### 4.6 Query Parameters (web-style)

```csharp
Frame.Navigate(typeof(SearchPage), "?q=uno&sort=asc");

// Parse in OnNavigatedTo
var query = e.Parameter as string;
var q = query?.Split('&').FirstOrDefault(s => s.StartsWith("?q="))?.Replace("?q=", "");
```

---

## 5. DATA UPDATING

### ObservableCollection (Automatic UI Updates)

```csharp
public ObservableCollection<Product> Products { get; } = new();

// Any change reflects in UI automatically
Products.Add(new Product());
Products.RemoveAt(0);
Products[0] = updatedProduct;

// For bulk updates, use:
Products.Clear();
foreach (var p in newItems) Products.Add(p);
```

### INotifyPropertyChanged (Single Property Updates)

```csharp
public class ViewModelBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected void SetProperty<T>(ref T field, T value, [CallerMemberName] string? name = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return;
        field = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}

// Usage
private string _name = "";
public string Name
{
    get => _name;
    set => SetProperty(ref _name, value);  // UI auto-updates
}
```

### CommunityToolkit.Mvvm (Source Generated)

```csharp
public partial class MyViewModel : ObservableObject
{
    [ObservableProperty]
    private string _name = "";

    [ObservableProperty]
    private bool _isLoading;

    [RelayCommand]
    async Task LoadAsync() { }
}
// Auto-generates: Name property, NameChanged, IsLoading, NameCommand, LoadCommand
```

### CollectionViewSource (Filtering/Sorting/Grouping)

```csharp
// XAML
<Page.Resources>
    <CollectionViewSource x:Key="Cvs" IsSourceGrouped="False" />
</Page.Resources>

// Code-behind
var cvs = (CollectionViewSource)Resources["Cvs"];
cvs.Source = myItems;
cvs.View.Filter = (item) => ((Product)item).Category == "Electronics";
cvs.View.Refresh();  // Apply filter
```

### Refreshing from API

```csharp
// Manual
async Task RefreshAsync()
{
    var items = await _api.GetProductsAsync();
    Products.Clear();
    foreach (var item in items) Products.Add(item);
}

// Pull-to-refresh
<RefreshContainer RefreshRequested="OnRefresh">
    <ListView ItemsSource="{Binding Products}" />
</RefreshContainer>

void OnRefresh(RefreshContainer sender, RefreshRequestedEventArgs args)
{
    using var deferral = args.GetDeferral();
    await _viewModel.RefreshAsync();
}
```

---

## 6. API — GET & POST

### GET Request

```csharp
public async Task<List<Product>> GetProductsAsync()
{
    var url = "https://api.example.com/products";
    var response = await _http.GetAsync(url);
    response.EnsureSuccessStatusCode();
    var json = await response.Content.ReadAsStringAsync();
    return JsonSerializer.Deserialize<List<Product>>(json, _jsonOpts) ?? new();
}
```

### POST Request

```csharp
public async Task<Product> CreateProductAsync(Product product)
{
    var url = "https://api.example.com/products";
    var json = JsonSerializer.Serialize(product, _jsonOpts);
    var content = new StringContent(json, Encoding.UTF8, "application/json");
    var response = await _http.PostAsync(url, content);
    response.EnsureSuccessStatusCode();
    var result = await response.Content.ReadAsStringAsync();
    return JsonSerializer.Deserialize<Product>(result, _jsonOpts)!;
}
```

### PUT Request

```csharp
public async Task<Product> UpdateProductAsync(int id, Product product)
{
    var url = $"https://api.example.com/products/{id}";
    var json = JsonSerializer.Serialize(product, _jsonOpts);
    var content = new StringContent(json, Encoding.UTF8, "application/json");
    var response = await _http.PutAsync(url, content);
    response.EnsureSuccessStatusCode();
    // ...
}
```

### DELETE Request

```csharp
public async Task DeleteProductAsync(int id)
{
    var url = $"https://api.example.com/products/{id}";
    var response = await _http.DeleteAsync(url);
    response.EnsureSuccessStatusCode();
}
```

### HttpClient Setup

```csharp
// Singleton HttpClient
public class ApiService
{
    private static readonly HttpClient _http = new()
    {
        BaseAddress = new Uri("https://api.example.com"),
        Timeout = TimeSpan.FromSeconds(30)
    };

    static ApiService()
    {
        _http.DefaultRequestHeaders.Add("Accept", "application/json");
        _http.DefaultRequestHeaders.Add("User-Agent", "MyApp/1.0");
    }
}
```

### With Auth Header

```csharp
_http.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", token);

// Or per-request
var request = new HttpRequestMessage(HttpMethod.Get, url);
request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
var response = await _http.SendAsync(request);
```

### Multipart Form (File Upload)

```csharp
public async Task<bool> UploadFileAsync(StorageFile file, string endpoint)
{
    using var stream = await file.OpenStreamForReadAsync();
    using var content = new MultipartFormDataContent();
    using var streamContent = new StreamContent(stream);
    content.Add(streamContent, "file", file.Name);

    var response = await _http.PostAsync(endpoint, content);
    return response.IsSuccessStatusCode;
}
```

### Error Handling Pattern

```csharp
public async Task<ApiResult<T>> SafeGetAsync<T>(string endpoint)
{
    try
    {
        var response = await _http.GetAsync(endpoint);
        if (!response.IsSuccessStatusCode)
            return ApiResult<T>.Fail($"Server error: {response.StatusCode}");
        var json = await response.Content.ReadAsStringAsync();
        var data = JsonSerializer.Deserialize<T>(json, _jsonOpts);
        return ApiResult<T>.Ok(data!);
    }
    catch (HttpRequestException) { return ApiResult<T>.Fail("No internet connection"); }
    catch (TaskCanceledException) { return ApiResult<T>.Fail("Request timed out"); }
    catch (Exception ex) { return ApiResult<T>.Fail($"Error: {ex.Message}"); }
}

public record ApiResult<T>
{
    public bool IsSuccess { get; init; }
    public T? Data { get; init; }
    public string? Error { get; init; }
    public static ApiResult<T> Ok(T data) => new() { IsSuccess = true, Data = data };
    public static ApiResult<T> Fail(string error) => new() { IsSuccess = false, Error = error };
}
```

### Using Refit (Declarative HTTP)

```csharp
// Install Refit
public interface IProductApi
{
    [Get("/products")]
    Task<List<Product>> GetProductsAsync();

    [Get("/products/{id}")]
    Task<Product> GetProductAsync(int id);

    [Post("/products")]
    Task<Product> CreateProductAsync([Body] Product product);

    [Put("/products/{id}")]
    Task<Product> UpdateProductAsync(int id, [Body] Product product);

    [Delete("/products/{id}")]
    Task DeleteProductAsync(int id);
}

// Setup
services.AddRefitClient<IProductApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://api.example.com"));
```

---

## 7. LIVE SEARCH

### AutoSuggestBox

```xml
<AutoSuggestBox x:Name="SearchBox"
                PlaceholderText="Search products..."
                QueryIcon="Find"
                TextChanged="OnSearchTextChanged"
                SuggestionChosen="OnSuggestionChosen"
                UpdateTextOnSelect="True" />
```

```csharp
// Debounce timer
private DispatcherTimer? _debounceTimer;

void OnSearchTextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
{
    if (args.Reason != AutoSuggestionBoxTextChangeReason.UserInput) return;

    // Debounce: wait 300ms after last keystroke
    _debounceTimer?.Stop();
    _debounceTimer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(300) };
    _debounceTimer.Tick += async (s, e) =>
    {
        _debounceTimer.Stop();
        var results = await _searchService.SearchAsync(sender.Text);
        sender.ItemsSource = results;
    };
    _debounceTimer.Start();
}

void OnSuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
{
    var product = args.SelectedItem as Product;
    if (product is not null)
        Frame.Navigate(typeof(ProductDetailPage), product.Id);
}
```

### Search Service (API)

```csharp
public class SearchService
{
    public async Task<List<Product>> SearchAsync(string query)
    {
        if (string.IsNullOrWhiteSpace(query)) return new();
        var url = $"https://api.example.com/products/search?q={Uri.EscapeDataString(query)}";
        var response = await _http.GetAsync(url);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsync<List<Product>>();
    }
}
```

### Local Search (In-Memory)

```csharp
public List<Product> FilterLocally(string query)
{
    if (string.IsNullOrWhiteSpace(query)) return _allProducts;
    return _allProducts
        .Where(p => p.Name.Contains(query, StringComparison.OrdinalIgnoreCase)
                 || p.Description.Contains(query, StringComparison.OrdinalIgnoreCase)
                 || p.Category.Contains(query, StringComparison.OrdinalIgnoreCase))
        .ToList();
}
```

---

## 8. TABS

### 8.1 Pivot (Bottom/Header Tabs)

```xml
<Pivot>
    <PivotItem Header="Home">
        <ListView ItemsSource="{Binding HomeItems}" />
    </PivotItem>
    <PivotItem Header="Search">
        <AutoSuggestBox />
    </PivotItem>
    <PivotItem Header="Profile">
        <StackPanel>...</StackPanel>
    </PivotItem>
</Pivot>
```

### 8.2 TabView (Browser-like Tabs)

```xml
<TabView AddTabButtonCommand="{Binding AddTabCommand}"
         TabItemsSource="{Binding Tabs}"
         SelectedItem="{Binding SelectedTab, Mode=TwoWay}">
    <TabView.ItemTemplate>
        <DataTemplate>
            <TabViewItem Header="{Binding Title}">
                <WebView2 Source="{Binding Url}" />
            </TabViewItem>
        </DataTemplate>
    </TabView.ItemTemplate>
</TabView>
```

### 8.3 Bottom Tab Bar (Custom + Toolkit)

Using Uno.Toolkit `TabBar`:

```xml
<toolkit:TabBar>
    <toolkit:TabBarItem Icon="Home" Label="Home" />
    <toolkit:TabBarItem Icon="Search" Label="Search" />
    <toolkit:TabBarItem Icon="Heart" Label="Favorites" />
    <toolkit:TabBarItem Icon="Person" Label="Profile" />
</toolkit:TabBar>
```

### 8.4 NavigationView (Hamburger Menu)

```xml
<NavigationView PaneDisplayMode="LeftCompact"
                MenuItemsSource="{Binding MenuItems}"
                SelectedItem="{Binding SelectedMenuItem, Mode=TwoWay}">
    <Frame x:Name="ContentFrame" />
</NavigationView>
```

---

## 9. BUTTONS — ALL VARIANTS

```xml
<!-- Standard -->
<Button Content="Save" Click="OnSave" />

<!-- With icon -->
<Button>
    <StackPanel Orientation="Horizontal" Spacing="8">
        <SymbolIcon Symbol="Save" />
        <TextBlock Text="Save" />
    </StackPanel>
</Button>

<!-- Hyperlink -->
<HyperlinkButton Content="Forgot password?" NavigateUri="https://..." />

<!-- Toggle -->
<ToggleButton Content="Dark Mode" IsChecked="{Binding IsDarkMode}" />

<!-- Repeat (fires while held) -->
<RepeatButton Content="-" Interval="100" Delay="500" />

<!-- Split (action + dropdown) -->
<SplitButton Command="{Binding SaveCommand}">
    <SplitButton.Flyout>
        <MenuFlyout>
            <MenuFlyoutItem Text="Save as PDF" />
            <MenuFlyoutItem Text="Save as CSV" />
        </MenuFlyout>
    </SplitButton.Flyout>
</SplitButton>

<!-- DropDown (menu only) -->
<DropDownButton Content="Export">
    <DropDownButton.Flyout>
        <MenuFlyout>
            <MenuFlyoutItem Text="PDF" />
            <MenuFlyoutItem Text="CSV" />
        </MenuFlyout>
    </DropDownButton.Flyout>
</DropDownButton>

<!-- Toggle Split -->
<ToggleSplitButton IsChecked="{Binding IsBold}" Content="B" />

<!-- AppBar (toolbar) -->
<CommandBar>
    <AppBarButton Icon="Add" Label="New" />
    <AppBarButton Icon="Delete" Label="Delete" />
    <AppBarToggleButton Icon="Bold" Label="Bold" />
</CommandBar>

<!-- Radio -->
<RadioButton Content="Option A" GroupName="Group1" />
<RadioButton Content="Option B" GroupName="Group1" />

<!-- CheckBox -->
<CheckBox Content="Accept terms" IsChecked="{Binding AcceptTerms}" />

<!-- ToggleSwitch -->
<ToggleSwitch Header="Wi-Fi" IsOn="{Binding IsWifiOn}" />
```

---

## 10. COMPONENT TYPES — FULL CLASSIFICATION

| Category | Components |
|----------|------------|
| **Layout** | Grid, StackPanel, FlexPanel, RelativePanel, Canvas, ScrollViewer, Border, Viewbox, VariableSizedWrapGrid, ItemsRepeater |
| **Content** | ContentControl, ContentPresenter, Frame, Page, UserControl, AppBar, CommandBar |
| **Buttons** | Button, HyperlinkButton, RepeatButton, ToggleButton, SplitButton, DropDownButton, ToggleSplitButton, AppBarButton, AppBarToggleButton, RadioButton, CheckBox, ToggleSwitch |
| **Text** | TextBlock, TextBox, PasswordBox, RichEditBox, AutoSuggestBox, NumberBox, RichTextBlock |
| **Lists** | ListView, GridView, ComboBox, ListBox, FlipView, ItemsControl, TreeView |
| **Tabs/Nav** | Pivot, TabView, NavigationView, MenuBar |
| **Media** | Image, MediaPlayerElement, CaptureElement, WebView2, MapControl, InkCanvas, AnimatedVisualPlayer |
| **Shapes** | Rectangle, Ellipse, Line, Polyline, Polygon, Path |
| **Icons** | FontIcon, SymbolIcon, BitmapIcon, PathIcon, AnimatedIcon |
| **Input** | DatePicker, TimePicker, CalendarView, CalendarDatePicker, Slider, RatingControl, ColorPicker |
| **Status** | ProgressBar, ProgressRing, InfoBar, Badge |
| **Feedback** | Flyout, Popup, ContentDialog, ToolTip, RefreshContainer, RefreshVisualizer, SwipeControl |
| **Toolkit+** | TabBar, TabBarItem, NavigationBar, Chip, ChipGroup, MarkupExtensions |

---

## 11. VIDEO PLAYER

```xml
<MediaPlayerElement x:Name="VideoPlayer"
                    AutoPlay="True"
                    AreTransportControlsEnabled="True"
                    Stretch="Uniform"
                    Source="ms-appx:///Assets/video.mp4" />
```

### Source Types

```csharp
// Local file
VideoPlayer.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/video.mp4"));

// URL
VideoPlayer.Source = MediaSource.CreateFromUri(new Uri("https://example.com/video.mp4"));

// From StorageFile
var file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Assets/video.mp4"));
VideoPlayer.Source = MediaSource.CreateFromStorageFile(file);

// From stream
var stream = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Assets/video.mp4"));
VideoPlayer.Source = MediaSource.CreateFromStreamReference(stream, "video/mp4");
```

### Control Programmatically

```csharp
var player = VideoPlayer.MediaPlayer;
player.Play();
player.Pause();
player.Stop();
player.Position = TimeSpan.FromSeconds(30);
player.Volume = 0.5;  // 0.0–1.0
player.IsMuted = true;

// Events
player.PlaybackSession.PlaybackStateChanged += (s, e) => { };
player.PlaybackSession.PositionChanged += (s, e) => { };
player.PlaybackSession.NaturalDurationChanged += (s, e) => { };
player.MediaEnded += (s, e) => { };
player.MediaFailed += (s, e) => { };
```

### Poster (Thumbnail)

```xml
<MediaPlayerElement PosterSource="https://example.com/thumbnail.jpg">
```

---

## 12. AUDIO PLAYER

```xml
<MediaPlayerElement x:Name="AudioPlayer"
                    AutoPlay="False"
                    AreTransportControlsEnabled="False" />
```

```csharp
// Play audio (no visible UI)
var player = AudioPlayer.MediaPlayer;

// From URL
player.Source = MediaSource.CreateFromUri(new Uri("https://example.com/audio.mp3"));

// From local file
var file = await StorageFile.GetFileFromApplicationUriAsync(
    new Uri("ms-appx:///Assets/sound.mp3"));
player.Source = MediaSource.CreateFromStorageFile(file);

// Controls
player.Play();
player.Pause();
player.Volume = 0.3;
player.IsMuted = false;
player.Position = TimeSpan.FromSeconds(10);

// Get duration
var duration = player.PlaybackSession.NaturalDuration;
var currentPos = player.PlaybackSession.Position;
```

### Background Audio

Not natively supported by Uno. Use platform-specific code:

```csharp
#if __ANDROID__
using Android.Media;

var mediaPlayer = MediaPlayer.Create(Android.App.Application.Context, 
    Android.Net.Uri.Parse("https://example.com/audio.mp3"));
mediaPlayer.Start();
#endif
```

---

## 13. FILE SYSTEM

### Storage Locations

```csharp
// App local folder (persistent)
var localFolder = ApplicationData.Current.LocalFolder;

// Temp folder (may be cleared)
var tempFolder = ApplicationData.Current.TemporaryFolder;

// Cache folder
var cacheFolder = ApplicationData.Current.LocalCacheFolder;

// Paths
var localPath = ApplicationData.Current.LocalFolder.Path;
var cachePath = ApplicationData.Current.LocalCacheFolder.Path;
var tempPath = ApplicationData.Current.TemporaryFolder.Path;
```

### File Operations

```csharp
// Create file
var file = await localFolder.CreateFileAsync("data.json",
    CreationCollisionOption.ReplaceExisting);

// Write text
await FileIO.WriteTextAsync(file, "Hello");

// Write bytes
await FileIO.WriteBytesAsync(file, new byte[] { 1, 2, 3 });

// Read text
var text = await FileIO.ReadTextAsync(file);

// Read bytes
var buffer = await FileIO.ReadBufferAsync(file);
var bytes = buffer.ToArray();

// Copy
await file.CopyAsync(localFolder, "backup.json", NameCollisionOption.ReplaceExisting);

// Move
await file.MoveAsync(localFolder, "renamed.json");

// Delete
await file.DeleteAsync();

// Check exists
var exists = await localFolder.TryGetItemAsync("data.json") is not null;

// Get file
file = await localFolder.GetFileAsync("data.json");
```

### Folder Operations

```csharp
// Create folder
var folder = await localFolder.CreateFolderAsync("images",
    CreationCollisionOption.OpenIfExists);

// Get folder
folder = await localFolder.GetFolderAsync("images");

// Get files
var files = await folder.GetFilesAsync();
var images = await folder.GetFilesAsync(CommonFileQuery.OrderByName);

// Get subfolders
var subfolders = await folder.GetFoldersAsync();

// Delete folder
await folder.DeleteAsync();
```

### File Picker (Open/Save)

```csharp
// Open file picker
var picker = new FileOpenPicker
{
    FileTypeFilter = { ".jpg", ".png", ".gif" },
    SuggestedStartLocation = PickerLocationId.PicturesLibrary
};
var file = await picker.PickSingleFileAsync();

// Save file picker
var savePicker = new FileSavePicker
{
    SuggestedFileName = "photo.jpg",
    SuggestedStartLocation = PickerLocationId.PicturesLibrary,
    DefaultFileExtension = ".jpg"
};
savePicker.FileTypeChoices.Add("JPEG Image", new List<string> { ".jpg" });
var saveFile = await savePicker.PickSaveFileAsync();
```

### System.IO (Standard .NET)

```csharp
var path = Path.Combine(ApplicationData.Current.LocalFolder.Path, "data.bin");

// Write all bytes
await File.WriteAllBytesAsync(path, data);

// Read all bytes
var bytes = await File.ReadAllBytesAsync(path);

// Write all text
await File.WriteAllTextAsync(path, json);

// Read all text
var text = await File.ReadAllTextAsync(path);

// Check exists
if (File.Exists(path)) { }

// Delete
File.Delete(path);
```

---

## 14. DOWNLOAD

```csharp
public async Task DownloadFileAsync(string url, string destinationFileName)
{
    var http = new HttpClient();
    var response = await http.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
    response.EnsureSuccessStatusCode();

    var totalBytes = response.Content.Headers.ContentLength ?? -1;
    var stream = await response.Content.ReadAsStreamAsync();
    var destFile = await ApplicationData.Current.LocalFolder
        .CreateFileAsync(destinationFileName, CreationCollisionOption.ReplaceExisting);

    using var fileStream = await destFile.OpenStreamForWriteAsync();
    var buffer = new byte[8192];
    long totalRead = 0;
    int bytesRead;

    while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
    {
        await fileStream.WriteAsync(buffer, 0, bytesRead);
        totalRead += bytesRead;
        var progress = (double)totalRead / totalBytes * 100;
        // Report progress
    }
}
```

### Download with Progress

```csharp
public class DownloadService
{
    public async Task DownloadAsync(string url, StorageFile file,
        IProgress<double> progress, CancellationToken ct)
    {
        using var http = new HttpClient();
        using var response = await http.GetAsync(url,
            HttpCompletionOption.ResponseHeadersRead, ct);
        response.EnsureSuccessStatusCode();

        var total = response.Content.Headers.ContentLength ?? -1L;
        using var sourceStream = await response.Content.ReadAsStreamAsync(ct);
        using var destStream = await file.OpenStreamForWriteAsync();

        var buffer = new byte[81920];  // 80KB buffer
        long readSoFar = 0;
        int read;

        while ((read = await sourceStream.ReadAsync(buffer, 0, buffer.Length, ct)) > 0)
        {
            await destStream.WriteAsync(buffer, 0, read, ct);
            readSoFar += read;
            if (total > 0)
                progress.Report((double)readSoFar / total * 100);
        }
    }
}
```

```csharp
// Usage
var downloadService = new DownloadService();
var progress = new Progress<double>(p => DownloadProgressBar.Value = p);
var cts = new CancellationTokenSource();

var file = await ApplicationData.Current.LocalFolder
    .CreateFileAsync("download.zip", CreationCollisionOption.ReplaceExisting);

await downloadService.DownloadAsync("https://example.com/file.zip", file, progress, cts.Token);
```

---

## 15. UPLOAD

### Simple Upload

```csharp
public async Task<bool> UploadAsync(StorageFile file, string endpoint)
{
    using var http = new HttpClient();
    using var stream = await file.OpenStreamForReadAsync();
    using var content = new MultipartFormDataContent();
    using var streamContent = new StreamContent(stream);
    content.Add(streamContent, "file", file.Name);

    var response = await http.PostAsync(endpoint, content);
    return response.IsSuccessStatusCode;
}
```

### Upload with Progress

```csharp
public class UploadService
{
    public async Task UploadWithProgressAsync(
        StorageFile file, string endpoint,
        IProgress<double> progress, CancellationToken ct)
    {
        using var http = new HttpClient();
        using var fileStream = await file.OpenStreamForReadAsync();
        var totalBytes = fileStream.Length;

        var progressStream = new ProgressStream(fileStream, totalBytes, progress);
        using var content = new MultipartFormDataContent();
        content.Add(new StreamContent(progressStream), "file", file.Name);

        var response = await http.PostAsync(endpoint, content, ct);
        response.EnsureSuccessStatusCode();
    }
}

public class ProgressStream(Stream innerStream, long totalBytes, IProgress<double> progress)
    : Stream
{
    long _read = 0;
    public override int Read(byte[] buffer, int offset, int count)
    {
        var read = innerStream.Read(buffer, offset, count);
        _read += read;
        progress.Report((double)_read / totalBytes * 100);
        return read;
    }
    // ... other Stream overrides
}
```

### Upload to Presigned URL (S3, Azure Blob)

```csharp
// PUT directly to cloud storage
public async Task UploadToBlobAsync(StorageFile file, Uri presignedUrl)
{
    using var http = new HttpClient();
    using var stream = await file.OpenStreamForReadAsync();
    using var content = new StreamContent(stream);
    content.Headers.ContentType = new MediaTypeHeaderValue(file.ContentType ?? "application/octet-stream");

    var response = await http.PutAsync(presignedUrl, content);
    response.EnsureSuccessStatusCode();
}
```

---

## 16. BLUETOOTH / BLE

Uno does not have a built-in cross-platform Bluetooth API. Use platform-specific code.

### Bluetooth Low Energy (BLE) — Scanner

```csharp
#if __ANDROID__
using Android.Bluetooth;
using Android.Bluetooth.LE;
using Android.Content;

public class BleService
{
    private BluetoothAdapter? _adapter;
    private BluetoothLeScanner? _scanner;

    public BleService()
    {
        var manager = (BluetoothManager?)Android.App.Application.Context
            .GetSystemService(Context.BluetoothService);
        _adapter = manager?.Adapter;
        _scanner = _adapter?.BluetoothLeScanner;
    }

    public void StartScan(Action<BluetoothDevice> onDeviceFound)
    {
        var callback = new BleScanCallback(onDeviceFound);
        _scanner?.StartScan(callback);
    }

    public void StopScan()
    {
        _scanner?.StopScan(null);
    }
}

class BleScanCallback : ScanCallback
{
    readonly Action<BluetoothDevice> _onFound;
    public BleScanCallback(Action<BluetoothDevice> onFound) => _onFound = onFound;
    public override void OnScanResult(ScanResultType callbackType, ScanResult result)
        => _onFound(result.Device);
}
#endif
```

### Classic Bluetooth — Pairing & Data Transfer

```csharp
#if __ANDROID__
using Android.Bluetooth;
using Java.Util;

public class ClassicBtService
{
    public async Task SendDataAsync(string deviceAddress, byte[] data)
    {
        var device = BluetoothAdapter.DefaultAdapter?.GetRemoteDevice(deviceAddress);
        if (device is null) return;

        var uuid = UUID.FromString("00001101-0000-1000-8000-00805F9B34FB");
        var socket = device.CreateRfcommSocketToServiceRecord(uuid);
        await socket.ConnectAsync();
        var outputStream = socket.OutputStream;
        await outputStream.WriteAsync(data, 0, data.Length);
        socket.Close();
    }
}
#endif
```

### Permissions

```xml
<!-- Android manifest -->
<uses-permission android:name="android.permission.BLUETOOTH" />
<uses-permission android:name="android.permission.BLUETOOTH_ADMIN" />
<uses-permission android:name="android.permission.BLUETOOTH_CONNECT" />
<uses-permission android:name="android.permission.BLUETOOTH_SCAN" />
<uses-permission android:name="android.permission.ACCESS_FINE_LOCATION" />
```

---

## 17. ADDITIONAL DEVICE FEATURES

### Clipboard

```csharp
// Copy
var dp = new DataPackage();
dp.SetText("Hello");
Clipboard.SetContent(dp);

// Paste
var data = await Clipboard.GetContent();
if (data.Contains(StandardDataFormats.Text))
    var text = await data.GetTextAsync();
```

### Vibrate

```csharp
#if __ANDROID__
var vibrator = (Vibrator?)Android.App.Application.Context
    .GetSystemService(Context.VibratorService);
vibrator?.Vibrate(VibrationEffect.CreateOneShot(100, VibrationEffect.DefaultAmplitude));
#endif
```

### Wi-Fi Info

```csharp
#if __ANDROID__
var wifiManager = (WifiManager?)Android.App.Application.Context
    .GetSystemService(Context.WifiService);
var info = wifiManager?.ConnectionInfo;
var ssid = info?.SSID;  // Network name
var speed = info?.LinkSpeed;  // Mbps
#endif
```

### Battery Status

```csharp
#if __ANDROID__
var batteryManager = (BatteryManager?)Android.App.Application.Context
    .GetSystemService(Context.BatteryService);
var level = batteryManager?.GetIntProperty((int)BatteryPropertyCapacity);
// 0–100
#endif
```

### Screen Brightness

```csharp
#if __ANDROID__
var window = activity?.Window;
var attrs = window?.Attributes;
attrs.ScreenBrightness = 0.5f;  // 0.0–1.0
window.Attributes = attrs;
#endif
```

### NFC

```csharp
#if __ANDROID__
var nfcAdapter = NfcAdapter.GetDefaultAdapter(Android.App.Application.Context);
if (nfcAdapter?.IsEnabled == true)
{
    // NFC is available
}
#endif
```

---

## 18. PERFORMANCE TIPS

```
✓ Use x:Bind instead of Binding (compiled, faster)
✓ Use ListView/GridView (virtualized) not StackPanel for long lists
✓ Use ObservableCollection bound to ItemsSource
✓ Use x:Phase for lazy loading in DataTemplates
✓ Set x:DeferLoadingStrategy="Lazy" on rarely-used elements
✓ Avoid deep visual trees
✓ Use Image caching (CacheMode="BitmapCache")
✓ Load thumbnails, not full images, in lists
✓ Use async/await everywhere, never .Result or .Wait()
✓ Cancel async operations with CancellationToken
✓ Use IncrementalLoading for infinite scroll
✓ Use CollectionViewSource for filtering (not re-creating lists)
✓ Use ConditionalWeakTable for attaching data to views
```

---

## 19. HOT RELOAD — Live Preview While Coding

Uno Platform supports **Hot Reload** — edit XAML or C# and see changes instantly on the running emulator/device without full rebuild.

### Option 1: Visual Studio + Uno Extension

1. Install **Uno Platform Extension** for Visual Studio
2. Open your project, run the app (Debug mode)
3. Edit any `.xaml` file — press **Ctrl+S** and the UI updates live
4. C# changes also reload (method bodies, ViewModel logic)

No extra configuration needed — works out of the box with the extension.

### Option 2: Uno Studio (Standalone Desktop Preview)

```powershell
# Install the tool
dotnet new tool-manifest
dotnet tool install Uno.Studio

# Run alongside your app
dotnet run
```

Uno Studio gives you a desktop preview window that mirrors the app and supports XAML Hot Reload.

### Option 3: CLI Remote Control

```powershell
cd MyApp/MyApp
dotnet build -t:Run -p:UnoRemoteControl=true
```

This starts the app with a remote control server — any XAML or C# change saved triggers a hot reload push to the device.

### Option 4: CommunityToolkit LiveSharp

Install **LiveSharp** (third-party) for more advanced hot reload:

```bash
dotnet tool install -g LiveSharp
livesharper --watch MyApp.csproj
```

### What Can Be Hot-Reloaded

| Change | Supported |
|--------|-----------|
| XAML layout changes | ✅ Yes |
| XAML styles/colors | ✅ Yes |
| XAML templates | ✅ Yes |
| C# method bodies | ✅ Yes |
| C# new methods/classes | ⚠️ Partial |
| C# new properties | ⚠️ Partial |
| Adding new NuGet packages | ❌ Rebuild needed |
| Modifying `.csproj` | ❌ Rebuild needed |

### Tips

- Run in **Debug** mode for Hot Reload to work
- Save files (Ctrl+S) to trigger the reload
- If UI doesn't update, focus the emulator window then focus back
- For Android emulator: ensure `UnoRemoteControl` is enabled in `appsettings.json`

---

*This reference covers Uno Platform 5.x / WinUI 3 targeting Android via .NET.*
