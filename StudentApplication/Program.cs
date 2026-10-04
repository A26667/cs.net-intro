Student student1 = new Student();
// student1.Name = "Ana";
// student1.Age = 20;
// student1.Career = "Computer Science";

Console.WriteLine($"Student: {student1.Name}");
Console.WriteLine($"Age: {student1.Age}");
Console.WriteLine($"Career: {student1.Career}");

Student student2 = new ("Luis", 22);
student2.Career = "Software Engineering";

Course OOPCourse = new Course
{
    Name = "Object-oriented Programming",
    Credits = 4,
    Teacher = "Luis Antonio Beltrán Prieto"
};

Console.WriteLine($"{student2.Name} is enrolled in the course {OOPCourse.Name
    }, of {OOPCourse.Credits} credits, teached by {OOPCourse.Teacher}.");

List<Student> students = new List<Student>();

students.Add(student1);
students.Add(student2);

foreach (Student student in students)
{
    student.PrintSummary();
    Console.WriteLine($"{student.Name} can travel with a student discount for {
        student.TravelDiscountYearsLeft()} more years.");
}

Book book1 = new Book
{
    Title = "NoSQL distilled: a brief guide to the emerging world of polyglot persistence",
    Author = "Sadalage, P. J., & Fowler, M.",
    Pages = 192
};

Book book2 = new Book
{
    Title = "Advanced data management: for SQL, NoSQL, cloud and distributed databases",
    Author = "Wiese, L.",
    Pages = 374
};

Book book3 = new Book
{
    Title = "Big Data Fundamentals: Concepts, Drivers & Techniques",
    Author = "Erl, T., Khattak, W., & Buhler, P.",
    Pages = 235
};

List<Book> dataBooks = [book1, book2, book3];
foreach (Book book in dataBooks)
{
    Console.WriteLine($"{book}");
}

List<Product> bookProducts =
[
    new Product($"{book2.Title}. {book2.Author}", 926.62, 3),
    new Product($"{book3.Title}. {book3.Author}", 848.64, 2)
];
foreach (Product bookProduct in bookProducts)
{
    Console.WriteLine($"{bookProduct.Name}: {bookProduct.Price} CZK ({bookProduct.Stock} in stock)");
}
