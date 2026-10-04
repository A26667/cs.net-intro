public class Course
{
    public static int TotalCourses = 0;
    
    public string Name;
    public int Credits;
    public string Teacher;

    public Course()
    {
        TotalCourses++;
    }

    public static void ShowMessage()
    {
        Console.WriteLine("Total courses: " + TotalCourses);
    }
}
