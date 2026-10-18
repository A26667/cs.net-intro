public class Teacher
{
    public string Name;
    // (4*) encapsulation for value validation
    private string subject;
    private int yearsOfExperience;

    public int YearsOfExperience {
        get => yearsOfExperience;
        set {
            if (value < 0)
                return; // reject negative values

            yearsOfExperience = value;
        }
    }

    public string Subject {
        get => subject;
        set {
            if (string.IsNullOrWhiteSpace(value))
                value = "Unknown subject"; // prevent empty values
            
            subject = value;
        }
    }
    
    public void ShowProfile() {
        Console.WriteLine($"Teacher of {Subject}: {Name}\nExperience: {YearsOfExperience} years");
    }
}
