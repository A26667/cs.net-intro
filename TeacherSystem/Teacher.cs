public class Teacher {
    public static List<Teacher> All = new List<Teacher>();
    
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
    
    public static int Count { get => All.Count; }

    public Teacher() {
        All.Add(this);
    }

    public static void ShowAll() {
        foreach (Teacher teacher in All) {
            teacher.ShowProfile();
        }
    }
    
    public void ShowProfile() {
        Console.WriteLine($"Teacher of {Subject}: {Name}\nExperience: {YearsOfExperience} years");
    }
    
    public static double AverageYearsExperience {
        get => All.Average(teacher => teacher.YearsOfExperience);
    }
}
