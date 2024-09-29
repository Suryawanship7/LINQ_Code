// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
List<int> Numbers = new List<int>() { 1,2,3,4,5,6,7,8,9 };
//any it return in treu or false it is used to find check casses
bool b = Numbers.Any(x => x >= 5 && x <= 7);
Console.WriteLine($"bool b = Numbers.Any(x => x >= 5 && x <= 7):{b}");
//all condn it is used in such cases all element are eligble for given condn are true then itb will give true or else false
b = Numbers.All(x => x % 2 == 0);
Console.WriteLine($"b = Numbers.All(x => x % 2 == 0):{b}");
//contains it will check condn is satisfing or not
b = Numbers.Contains(3);
Console.WriteLine($"Numbers.Contains(3):{b}");









Console.ReadLine();
