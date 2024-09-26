public class Student_helper : IComparer<Student>
{
    public int Compare(Student? x, Student? y)
    {
        return x.City.CompareTo(y.City);
        throw new NotImplementedException();
    }
}