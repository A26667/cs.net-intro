// List to store the numeric values
List<float> grades = new List<float>();

for (int i = 0; i < 5; )
// Ask the user for 5 grades
{
    Console.Write($"Enter grade #{++i}: ");
    float.TryParse(Console.ReadLine(), out float grade);
    grades.Add(grade);
}

// Get the maximum, minimum, and average of all grades
// using LINQ and Aggregation functions
float maximum = grades.Max();
float minimum = grades.Min();
float average = grades.Average();

// Print the information
Console.WriteLine("#: grade\n--|-----");
int j = 0;
grades.ForEach(delegate(float grade)
{
    Console.WriteLine(++j + ": " + grade);
});
Console.WriteLine($"*Maximum: {maximum}\n*Minimum: {minimum}\n*Average: {average}");
