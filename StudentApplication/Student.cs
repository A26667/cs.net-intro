public class Student // public keyword is unnecessary here in C#; but good habit for other languages
{
    public static int TotalStudents = 0;
    public static int MaxTravelDiscountAge = 26;
    
    private string name;
    private int age;
    public string Career;

    public Student() // constructor: special method without return value
    {
        Name = "Unknown";
        Age = 18;
        Career = "None";

        TotalStudents++;
    }

    public Student(string name, int age)
    {
        Student defaultStudent = new Student();
        Name = name;
        Age = age;
        Career = defaultStudent.Career;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0)
            {
                age = value;
            }
        }
    }
    
    public void PrintSummary()
    {
        Console.WriteLine($"{Name} ({Age}) - {Career}");
    }

    public int TravelDiscountYearsLeft()
    {
        return MaxTravelDiscountAge - Age;
    }
}
