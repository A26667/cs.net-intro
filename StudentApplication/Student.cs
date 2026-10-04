public class Student // public keyword is unnecessary here in C#; but good habit for other languages
{
    private string name;
    private int age;
    public string Career;

    public Student() // constructor: special method without return value
    {
        Name = "Unknown";
        Age = 18;
        Career = "None";
    }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
        Career = new Student().Career;
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
        return 26 - Age;
    }
}
