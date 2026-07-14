using Lab2_DbContext.Data;

using AppDbContext context = new AppDbContext();

Console.WriteLine();
Console.WriteLine("DbContext created successfully.");
Console.WriteLine("Connection to SQL Server configured.");

Console.WriteLine();
Console.WriteLine("Entity Sets:");
Console.WriteLine($"Categories : {context.Categories.GetType().Name}");
Console.WriteLine($"Products   : {context.Products.GetType().Name}");

Console.WriteLine();
Console.WriteLine("Lab 2 Completed Successfully.");