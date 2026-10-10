int userRoll;
int computerRoll;
do
{
    // Roll a die twice by generating two random numbers
    // (between 1 and 6) using the Random C# class
    userRoll = Die.Roll();  // first roll is yours
    computerRoll = Die.Roll();  // second one is from the computer
    
    // Print both values
    Console.WriteLine($"Your roll: {userRoll}\nComputer roll: {computerRoll}");
    if (userRoll == computerRoll)
    {
        Console.WriteLine("It's a tie. Re-rolling...");
    }
    else // Print the winner
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
} while (userRoll == computerRoll); // In the case of a tie, re-roll both dice
