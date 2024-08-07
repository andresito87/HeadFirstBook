
namespace AbilityScore;

internal class AbilityScoreCalculator
{
    public int RollResult = 14;
    public double DivideBy = 1.75;
    public int AddAmount = 2;
    public int Minimum = 3;
    public int Score;

    public void CalculateAbilityScore()
    {
        //Divide the roll result by the DivideBy field
        double divided = RollResult / DivideBy;

        // Add AddAmount to the result and round down
        int added = AddAmount + (int)divided;

        // If the result is too samll, use Minimum
        if (added < Minimum)
        {
            Score = Minimum;
        }
        else
        {
            Score = added;
        }
    }

    /// <summary>
    /// Reads an integer number entered by the user from the console.
    /// </summary>
    /// <param name="defaultValue">
    /// The default value to use if the user does not enter a valid number.
    /// </param>
    /// <param name="prompt">
    /// The text to display to the user when asking for input.
    /// </param>
    /// <returns>
    /// Returns the number entered by the user, or the default value if the input is invalid or empty.
    /// </returns>
    public static int ReadInt(int defaultValue, string prompt)
    {
        Console.Write(prompt + " [" + defaultValue + "] ");
        string? line = Console.ReadLine();

        if (int.TryParse(line, out int value))
        {
            Console.WriteLine("   using value " + value);
            return value;
        }
        Console.WriteLine("   using default value " + defaultValue);
        return defaultValue;
    }

    /// <summary>
    /// Reads a double-precision floating-point number entered by the user from the console.
    /// </summary>
    /// <param name="defaultValue">
    /// The default value to use if the user does not enter a valid number.
    /// </param>
    /// <param name="prompt">
    /// The text to display to the user when asking for input.
    /// </param>
    /// <returns>
    /// Returns the number entered by the user, or the default value if the input is invalid or empty.
    /// </returns>
    public static double ReadDouble(double defaultValue, string prompt)
    {
        Console.Write(prompt + " [" + defaultValue + "] ");
        string? line = Console.ReadLine();

        if (double.TryParse(line, out double value))
        {
            Console.WriteLine("   using value " + value);
            return value;
        }
        Console.WriteLine("   using default value " + defaultValue);
        return defaultValue;
    }

}
