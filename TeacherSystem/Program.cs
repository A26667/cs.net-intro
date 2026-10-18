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
