using RetailInventory.Data;
using RetailInventory.Models;

AppDbContext context = new AppDbContext();

if (!context.Categories.Any())
{
    var electronics = new Category
    {
        Name = "Electronics"
    };

    var grocery = new Category
    {
        Name = "Grocery"
    };

    context.Categories.Add(electronics);
    context.Categories.Add(grocery);

    context.SaveChanges();

    context.Products.Add(new Product
    {
        Name = "Laptop",
        Price = 65000,
        CategoryId = electronics.Id
    });

    context.Products.Add(new Product
    {
        Name = "Mouse",
        Price = 800,
        CategoryId = electronics.Id
    });

    context.Products.Add(new Product
    {
        Name = "Rice",
        Price = 70,
        CategoryId = grocery.Id
    });

    context.Products.Add(new Product
    {
        Name = "Milk",
        Price = 55,
        CategoryId = grocery.Id
    });

    context.SaveChanges();

    Console.WriteLine("Data Inserted Successfully.");
}
else
{
    Console.WriteLine("Data already exists.");
}