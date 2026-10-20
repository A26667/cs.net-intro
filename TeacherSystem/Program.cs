// (1*) create 2 teachers
Teacher teacher1 = new Teacher
{
    Name = "Nélida Filipe",
    Subject = "Math A",
    YearsOfExperience = 20
};
Teacher teacher2 = new Teacher
{
    Name = "Pedro Cardoso",
    Subject = "Machine Learning",
    YearsOfExperience = 25
};

// (3*) use a list
List<Teacher> teachers = [teacher1, teacher2];

// (1*) print their information
foreach (Teacher teacher in teachers) {
    // Console.WriteLine($"Teacher: {teacher.Name}\nSubject: {teacher.Subject}\nYears of experience: {teacher.YearsOfExperience}");
    teacher.ShowProfile();
}

List<string> options = new List<string>();
options.Add("Add teacher");
options.Add("Show teachers");
options.Add("Count teachers");
options.Add("Average years of experience");

bool running = true;
while (running) {
    for (int i = 0; i < options.Count; i++) {
        Console.WriteLine($"{i + 1}. {options[i]}");
    }
    Console.WriteLine("0. Exit");
    
    Console.Write("Choose an option: ");
    int.TryParse(Console.ReadLine(), out int option); // allows "Enter" to exit (0)
    
    switch (option) {
        case 1:
            AddTeacher();
            break;

        case 2:
            Teacher.ShowAll();
            break;
        
        case 3:
            Console.WriteLine(Teacher.Count + " registered teachers exist");
            break;
        
        case 4:
            Console.WriteLine(options[3] + ": " + Teacher.AverageYearsExperience);
            break;

        case 0:
            Console.WriteLine("Goodbye!");
            Console.WriteLine("Exiting application...");
            running = false;
            break;

        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}

void AddTeacher() {
    Console.WriteLine("Enter the new teacher's details");
    
    Console.Write("Name: ");
    string name = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(name)) {              
        Console.WriteLine("Name cannot be empty. Try Again.");
        return;
    }
    
    Console.Write("Subject: ");
    string subject = Console.ReadLine();
    
    Console.Write("Years of experience: ");
    int.TryParse(Console.ReadLine(), out int yearsOfExp);

    Console.WriteLine("Adding teacher...");
    teachers.Add(new Teacher() {
        Name = name, Subject = subject, YearsOfExperience = yearsOfExp
    });
    Console.WriteLine("Teacher added.");
}
