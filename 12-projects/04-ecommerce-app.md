# Project 4: E-commerce App

Build a full e-commerce app with product catalog, cart, and checkout.

## Features

- Product listing with categories
- Product detail page
- Cart management (add/remove/quantity)
- Checkout flow
- Order history
- User profile

## Architecture

```
Models/Product.cs, CartItem.cs, Order.cs
Services/ProductApi.cs, CartService.cs, OrderService.cs
ViewModels/
  HomeViewModel.cs
  ProductDetailViewModel.cs
  CartViewModel.cs
  CheckoutViewModel.cs
Screens/
  HomePage.xaml / .cs            — Product grid
  ProductDetailPage.xaml / .cs   — Product detail
  CartPage.xaml / .cs            — Shopping cart
  CheckoutPage.xaml / .cs        — Payment/shipping
  OrdersPage.xaml / .cs          — Order history
Partials/
  ProductCard.xaml
  CartBadge.xaml
```

## Product Model

```csharp
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public decimal Price { get; set; }
    public string ImageUrl { get; set; } = "";
    public string Category { get; set; } = "";
    public double Rating { get; set; }
    public bool InStock { get; set; }
}
```

## Cart Logic

```csharp
public class CartService
{
    public ObservableCollection<CartItem> Items { get; } = new();
    public decimal Total => Items.Sum(i => i.Product.Price * i.Quantity);
    public int Count => Items.Sum(i => i.Quantity);

    public void Add(Product product)
    {
        var existing = Items.FirstOrDefault(i => i.Product.Id == product.Id);
        if (existing is not null) existing.Quantity++;
        else Items.Add(new CartItem { Product = product, Quantity = 1 });
    }

    public void Remove(Product product)
    {
        var item = Items.FirstOrDefault(i => i.Product.Id == product.Id);
        if (item is null) return;
        if (item.Quantity > 1) item.Quantity--;
        else Items.Remove(item);
    }
}
```

## Key Screens

```
Home:     GridView with categories + product cards
Detail:   Image, name, price, description, Add to Cart
Cart:     List of items with +/- buttons, total, Checkout button
Checkout: Address, payment method, Place Order
Orders:   Order list with status badges
```

## Learning Outcomes

- Complex state management (cart)
- Navigation with data passing
- REST API with auth
- Local storage for cart persistence
- Full checkout flow
- Loading/error states in real-world app

---

**Congratulations!** You've completed the full course. 🎉
