public class Student 
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string City { get; set; }

    public static List<Student> GetAll()
    {
        return new List<Student>()
        {

             new Student(){RollNumber = 1, Name = "akash", Age = 20, Gender = "male", City = "pune" },
        new Student(){RollNumber = 2, Name = "sudha", Age = 15, Gender = "female", City = "mumbai"  },
        new Student(){RollNumber = 3, Name = "pranav", Age = 15, Gender = "male", City = "satara"  },
        new Student(){RollNumber = 4, Name = "krishika", Age = 25, Gender = "female", City = "pune"  },
        new Student(){RollNumber = 5, Name = "ashok", Age = 32, Gender = "male", City = "mumbai"  }


        };
    }
}