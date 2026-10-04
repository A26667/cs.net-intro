// Roll a die twice by generating two random numbers (between 1 and 6) using
// the Random C# class. The first roll is yours, while the second one is from
// the computer. Print both values and the winner. In the case of a tie,
// re-roll both dice. Use Imperative Programming.
int userRoll;
int computerRoll;
do
{
    userRoll = Die.Roll();
    computerRoll = Die.Roll();
    
    Console.WriteLine($"Your roll: {userRoll}\nComputer roll: {computerRoll}");
    if (userRoll == computerRoll)
    {
        Console.WriteLine("It's a tie. Re-rolling...");
    }
    else
    {
        Console.Write("Winner: ");
        if (userRoll > computerRoll)
        {
            Console.WriteLine("you.");
        }
        else
        {
            Console.WriteLine("the computer.");
        }
    }
} while (userRoll == computerRoll);
