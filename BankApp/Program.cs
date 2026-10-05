using BankApp.Classes;

BankAccount b = new BankAccount();

try
{
    b.Name = "Savings";
    Console.WriteLine(b.Name);
    b.Balance = 0;
    Console.WriteLine(b.Balance);
    Console.WriteLine(b.HasPositiveBalance);
}
catch (ArgumentException e)
{
    Console.WriteLine($"Error: {e.Message}");
}
