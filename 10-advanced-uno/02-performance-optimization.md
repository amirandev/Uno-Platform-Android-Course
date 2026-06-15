# Performance Optimization

## x:Bind Over Binding

Use compiled bindings (`x:Bind`) instead of runtime bindings:

```xml
<!-- Fast: compiled, type-checked -->
<TextBlock Text="{x:Bind ViewModel.Name, Mode=OneWay}" />

<!-- Slower: runtime reflection -->
<TextBlock Text="{Binding Name}" />
```

## Virtualized Lists

Always use `ListView`/`GridView` (virtualized) not `ItemsStackPanel` manually:

```xml
<!-- GOOD: Virtualized, only renders visible items -->
<ListView ItemsSource="{Binding LargeList}" />

<!-- BAD: All items rendered at once -->
<ScrollViewer>
    <ItemsStackPanel>
        <!-- Manual items -->
    </ItemsStackPanel>
</ScrollViewer>
```

## Reduce Visual Tree Depth

```xml
<!-- BAD: Deep nesting -->
<Border><Border><Border><StackPanel><TextBlock /></StackPanel></Border></Border></Border>

<!-- GOOD: Flat hierarchy -->
<Grid><TextBlock /></Grid>
```

## Image Optimization

```xml
<!-- Cache images to disk -->
<Image Source="https://example.com/large.jpg"
       CacheMode="BitmapCache" />
```

Load thumbnails instead of full images for lists.

## Async & Main Thread

```csharp
// BAD: Blocks UI
Task.Wait();

// GOOD: Async all the way
await Task.Delay(100);
```

## Lazy Loading

```csharp
// LazyViewModel — only created when first accessed
private Lazy<HeavyViewModel> _heavyVm = new(() => new HeavyViewModel());

// Use
var vm = _heavyVm.Value;
```

## Profiling

```csharp
// Uno Studio profiler (debug mode)
// Enables FPS counter, memory, CPU tracking
```

---

**Next:** [Unit Testing](03-unit-testing.md)
