// See https://aka.ms/new-console-template for more information

#region Sort()
List<int> Numbers = new List<int>() { 5, 6, 8, 9, 1, 2, 3, 0, 4, 7 };
foreach (var number in Numbers)
{
    Console.Write($"{number}\t");
}
Console.WriteLine();
Numbers.Sort();
foreach(var number in Numbers)
{
    Console.Write($"{number}\t");
}
Console.WriteLine();



List<Student> students = Student.GetAll();
Console.WriteLine("ALl Students");
foreach(var student in students)
{
    Console.WriteLine($"Name:{student.Name}  {student.RollNumber}  {student.Age}  {student.Gender}  {student.City}");
}
Console.WriteLine("After Sorting method");
students.Sort();
foreach (var student in students)
{
    Console.WriteLine($"Name:{student.Name}  {student.RollNumber}  {student.Age}  {student.Gender}  {student.City}");
}
#endregion Sort()
#region Sort(Icomparer)
Console.WriteLine("----Icomperor_Sort----");
List<Student> std=Student.GetAll();
Console.WriteLine("All Students or without any sort student List");
foreach(var s in std)
{
    Console.WriteLine($"Name:{s.Name}"+$" Roll No:{s.RollNumber}"+$" Age:{s.Age}"+$" Gender:{s.Gender}"+$" City:{s.City}");
}
std.Sort(new Student_helper());
Console.WriteLine("After Sorting with Icompare<> we used city based assending");
foreach (var s in std)
{
    Console.WriteLine($"Name:{s.Name}" + $" Roll No:{s.RollNumber}" + $" Age:{s.Age}" + $" Gender:{s.Gender}" + $" City:{s.City}");
}
Console.WriteLine();
#endregion sort(Icomperer)
#region Sort(int index,int count,Icomparer)
//Its part of icopmrer here we set index from which inedx we want sort count how mmany records we want compare and sort and icomparer write
//using for first 3 record
Console.WriteLine("Used sort(index,count,icomparer, For First three record of student");
std.Sort(2,3,new Student_helper());
foreach (var s in std)
{
    Console.WriteLine($"Name:{s.Name}" + $" Roll No:{s.RollNumber}" + $" Age:{s.Age}" + $" Gender:{s.Gender}" + $" City:{s.City}");
}


#endregion sort(index,count,Icomparer)
#region sort(COMPARISON)
Console.WriteLine("Sort By using sort(comparison)");
std.Sort((x,y)=>x.Name.CompareTo(y.Name));
foreach (var s in std)
{
    Console.WriteLine($"Name:{s.Name}" + $" Roll No:{s.RollNumber}" + $" Age:{s.Age}" + $" Gender:{s.Gender}" + $" City:{s.City}");
}


#endregion sort(COMPARISON)
