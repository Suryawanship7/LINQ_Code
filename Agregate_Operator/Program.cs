// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<int>Number= new List<int>() { 1,2,3,4,5,6,7,8};
//Agregaet fun max
int num = Number.Max();
Console.WriteLine($"max no in list:{num}");
//Min func
num= Number.Min();
Console.WriteLine($"Min No in list :{num}");
//average func
var avg=Number.Average();
Console.WriteLine($"Average of list is:{avg}");
//Count
int count= Number.Count();
Console.WriteLine($"count of list{count}");
//longCount
long Count= Number.LongCount();
Console.WriteLine($"Long count:{count}");
//sum or summation
num= Number.Sum();
Console.WriteLine($"Sum of ele of list is:{num}");
//aggregate
var Num = Number.Aggregate((i,j)=>i*j);
Console.WriteLine($"Aggregate of fun:{Num}");
Console.ReadLine();