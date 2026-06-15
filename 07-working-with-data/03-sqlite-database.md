# SQLite Database

## Setup

Add NuGet packages:
```xml
<PackageReference Include="sqlite-net-pcl" Version="1.9.*" />
<PackageReference Include="SQLitePCLRaw.bundle_green" />
```

## Define Models

```csharp
using SQLite;

[Table("products")]
public class Product
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    [MaxLength(100), NotNull]
    public string Name { get; set; } = "";

    public decimal Price { get; set; }

    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
```

## Database Service

```csharp
public class DatabaseService
{
    private SQLiteAsyncConnection? _db;

    async Task<SQLiteAsyncConnection> GetDbAsync()
    {
        if (_db is not null) return _db;

        var path = Path.Combine(
            ApplicationData.Current.LocalFolder.Path, "myapp.db");
        _db = new SQLiteAsyncConnection(path);
        await _db.CreateTableAsync<Product>();
        return _db;
    }

    // CRUD
    public async Task<List<Product>> GetAllAsync()
    {
        var db = await GetDbAsync();
        return await db.Table<Product>().ToListAsync();
    }

    public async Task<Product?> GetByIdAsync(int id)
    {
        var db = await GetDbAsync();
        return await db.Table<Product>()
            .Where(p => p.Id == id)
            .FirstOrDefaultAsync();
    }

    public async Task<int> SaveAsync(Product product)
    {
        var db = await GetDbAsync();
        if (product.Id != 0)
            return await db.UpdateAsync(product);
        return await db.InsertAsync(product);
    }

    public async Task<int> DeleteAsync(Product product)
    {
        var db = await GetDbAsync();
        return await db.DeleteAsync(product);
    }

    // Query
    public async Task<List<Product>> SearchAsync(string term)
    {
        var db = await GetDbAsync();
        return await db.Table<Product>()
            .Where(p => p.Name.Contains(term))
            .OrderBy(p => p.Name)
            .ToListAsync();
    }
}
```

## Using in ViewModel

```csharp
public class ProductsViewModel
{
    private readonly DatabaseService _db;

    public ProductsViewModel(DatabaseService db) => _db = db;

    public async Task LoadAsync()
    {
        var items = await _db.GetAllAsync();
        Products.Clear();
        foreach (var item in items) Products.Add(item);
    }
}
```

---

**Next:** [REST API Client](04-rest-api-client.md)
