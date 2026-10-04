public class Student // public keyword is unnecessary here in C#; but good habit for other languages
{
    public string Name;
    public int Age;
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

    public void PrintSummary()
    {
        Console.WriteLine($"{Name} ({Age}) - {Career}");
    }

    public int TravelDiscountYearsLeft()
    {
        return 26 - Age;
    }
}
