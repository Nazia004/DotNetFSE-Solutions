using Lab5_RetrieveData.Data;
using Lab5_RetrieveData.Models;

AppDbContext context = new AppDbContext();

if (!context.Categories.Any())
{
    var electronics = new Category { Name = "Electronics" };
    var groceries = new Category { Name = "Groceries" };

    context.Categories.AddRange(electronics, groceries);
    context.SaveChanges();

    context.Products.AddRange(
        new Product
        {
            Name = "Laptop",
            Price = 65000,
            CategoryId = electronics.Id
        },
        new Product
        {
            Name = "Keyboard",
            Price = 1200,
            CategoryId = electronics.Id
        },
        new Product
        {
            Name = "Rice",
            Price = 80,
            CategoryId = groceries.Id
        });

    context.SaveChanges();
}

Console.WriteLine("Products:");

foreach (var product in context.Products)
{
    Console.WriteLine($"{product.Id} | {product.Name} | ₹{product.Price}");
}