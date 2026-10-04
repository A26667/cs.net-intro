public class Die
{
    private static Random RandomInt = new Random();

    /// Return random integer between 1 and 6 generated with the Random class
    public static int Roll()
    {
        return RandomInt.Next(maxValue: 6) + 1;
        // `maxValue` is exclusive boundary and 0 is inclusive lower boundary
        // so Next() returns an integer between 0 and 5
    }
}
