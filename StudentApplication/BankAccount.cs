public class BankAccount
{
    public string Owner;
    public double Balance;

    public BankAccount(string ownerName)
    {
        Owner = ownerName;
        Balance = 0;
    }

    public bool Deposit(double amount)
    {
        Balance += amount;
        return true; // successful operation 
    }

    public bool Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            return true; 
        }

        return false; // unsuccessful operation (insufficient balance)
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Balance: {Balance}");
    }
}
