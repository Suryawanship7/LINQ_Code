// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<Student> std = Student.GetAll();
foreach(Student s in std)
{
    Console.WriteLine($"Roll:{s.RollNumber}  Name:{s.Name}  age:{s.Age}  Gender:{s.Gender}  City:{s.City} ");
}
//GroupBy syntax and Use:
var groups = std.GroupBy(s=>s.Gender);
foreach(var group in groups)
{
    Console.WriteLine($"Grop key:{group.Key} Count:{group.Count()}");
}
var cgroup=std.GroupBy(s=>s.City);
foreach(var group in cgroup) 
{ 
    Console.WriteLine($"Cityname:{group.Key}  Count:{group.Count()}");
    foreach (var item in group) 
    {
        Console.WriteLine($"name:{item.Name}");
    }
}

Console.WriteLine("tolookup");
List<Sellproducts> Prdct=Sellproducts.GetAll();
foreach (Sellproducts s in Prdct)
{
    Console.WriteLine($"id:{s.idNo}  Name:{s.Productname}  Type:{s.Productdescription}");
}
var prdctgroup = Prdct.ToLookup(p => p.Productdescription);
foreach (var K in prdctgroup)
{
    Console.WriteLine( $"key:{K.Key} Count:{K.Count()}");
    foreach(var item in K)
    {
        Console.WriteLine($"Item name:{item.Productname}");
    }
}
Console.ReadLine();
