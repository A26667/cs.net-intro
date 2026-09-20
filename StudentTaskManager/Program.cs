const int MaxTasks = 10;
const string AppName = "Student Task Manager";

ShowMessage($"Application started: {AppName}");
ShowMessage($"Maximum recommended daily tasks: {MaxTasks}");
Console.WriteLine("====================");

List<string> tasks = new List<string>();
tasks.Add("Review C# variables");
tasks.Add("Practice loops");
tasks.Add("Create a Console application");

Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.WriteLine();
Console.WriteLine($"Hello {name}!");
Console.Write("How many tasks have you completed today? ");
int.TryParse(Console.ReadLine(), out int completedTasks);

if (completedTasks == 0) {
    Console.WriteLine("Time to get started!");
} else if (completedTasks < 3) {
    Console.WriteLine("Good start. Keep going!");
} else {
    Console.WriteLine("Great progress!");
}

List<string> options = new List<string>();
options.Add("Add task");
options.Add("View tasks");
options.Add("Complete task");
options.Add("Remove task");
options.Add("Calculate time");

bool running = true;
while (running) {
    ShowMenu(options);
    Console.Write("Choose an option: ");
    int.TryParse(Console.ReadLine(), out int option); // allows "Enter" to exit (0)

    switch (option) {
        case 1:
            AddTask(tasks);
            break;

        case 2:
            ShowTasks(tasks);
            break;

        case 3:
            CompleteTask(tasks);
            break;

        case 4:
            RemoveTask(tasks);
            break;

        case 5:
            CalculateTime();
            break;

        case 0:
            Console.WriteLine("Goodbye!");
            ShowMessage("Exiting application...");
            running = false;
            break;

        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}

void ShowTitle() {
    Console.WriteLine();
    Console.WriteLine("Student Task Manager");
    Console.WriteLine("====================");
}

void ShowMessage(string message) {
    Console.WriteLine($"[INFO] {message}");
}

void ShowMenu(List<string> options) {
    ShowTitle();
    WriteEnumLines(options);
    Console.WriteLine("0. Exit");
}

int GetCount(List<string> strings) {
    return strings.Count;
}

void AddTask(List<string> tasks) {
    if (tasks.Count >= MaxTasks) {
        Console.WriteLine("Maximum number of tasks reached.");
        return;
    }
    Console.Write("Enter a new task: ");
    string newTask = Console.ReadLine();
    Console.WriteLine("Adding a task...");
    tasks.Add(newTask);
    ShowMessage("Task added.");
}

/*
Write each enumerated string in List tasks. A return value indicates
whether the list has any items.

Returns:
    false if given List tasks is empty; otherwise, true.
*/
bool ShowTasks(List<string> tasks) {
    if (tasks.Count == 0) {
        Console.WriteLine("No tasks available.");
        return false;
    }
    WriteEnumLines(tasks);
    return true;
}

void CompleteTask(List<string> tasks) {
    if (ShowTasks(tasks)) {
        Console.Write("Number of task to complete: ");
        int.TryParse(Console.ReadLine(), out int taskNumber);
        if (taskNumber > 0 && taskNumber <= GetCount(tasks)) {
            Console.WriteLine("Completing task...");
            tasks[taskNumber - 1] += " (completed)"; // number 1 -> index 0
            ShowMessage("Task completed.");
        } else {
            Console.WriteLine("Invalid task number.");
        }
    }
}

void RemoveTask(List<string> tasks) {
    if (ShowTasks(tasks)) {
        Console.Write("Number of task to remove: ");
        int.TryParse(Console.ReadLine(), out int taskNumber);
        if (taskNumber > 0 && taskNumber <= GetCount(tasks)) {
            Console.WriteLine("Removing task...");
            tasks.RemoveAt(taskNumber - 1); // number 1 -> index 0
            ShowMessage("Task removed.");
        } else {
            Console.WriteLine("Invalid task number.");
        }
    }
}

void CalculateTime() {
    Console.Write("How many tasks do you want to complete today? ");
    // int taskGoal = int.Parse(Console.ReadLine()); // program crash on System.FormatException
    int.TryParse(Console.ReadLine(), out int taskGoal); // safer alternative

    Console.Write("How many hours do you have available? ");
    // double availableHours = double.Parse(Console.ReadLine());
    double.TryParse(Console.ReadLine(), out double availableHours);

    double distributedHours = availableHours / taskGoal;
    Console.WriteLine($"If your goal is {taskGoal} tasks, you have around {distributedHours} hours available for each.");
}

void WriteEnumLines(List<string> strings) {
    for (int i = 0; i < GetCount(strings); i++) {
        Console.WriteLine($"{i + 1}. {strings[i]}");
    }
}

enum TaskPriority
{
    Low,
    Medium,
    High
}
