// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<ProductList> products = ProductList.GetAll();
foreach (var product in products)
{
    Console.WriteLine($"{product.PdId} {product.ProductName} {product.ProductDescription} {product.Price} {product.Discount}");
}

//fetching only name of product
//USing Select Keyword

var names= products.Select(s=>s.ProductName).ToList();
foreach (var name in names)
{
    Console.WriteLine(name);
}
var namewithType = products.Select(s => new { Name = s.ProductName, Type = s.ProductDescription }).ToList();
foreach (var name in namewithType)
{
    Console.WriteLine($"{name.Name} {name.Type}");
}
Console.ReadLine();
