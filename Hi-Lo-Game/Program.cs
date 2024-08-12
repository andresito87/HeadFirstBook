Console.WriteLine("Welcome to HiLo.");
Console.WriteLine($"Guess numbers between 1 and {HiLoGame.MAXIMUM}.");
HiLoGame.Hint();
while (HiLoGame.GetPot() > 0)
{
    Console.WriteLine("Press h for higher, l for lower, ? to buy a hint,");
    Console.WriteLine($"or any other key to quit with {HiLoGame.GetPot()}.");
    char key = Console.ReadKey(true).KeyChar;
    if (key == 'h') HiLoGame.Guess(true);
    else if (key == 'l') HiLoGame.Guess(false);
    else if (key == '?') HiLoGame.Hint();
    else return;
}
Console.WriteLine("The pot is empty. Bye!");

static class HiLoGame
{
    public static int MAXIMUM = 10;

    private static int currentNumber = Random.Shared.Next(1, MAXIMUM + 1);
    private static int nextNumber = Random.Shared.Next(1, MAXIMUM + 1);

    private static int pot = 10;

    public static int GetPot()
    {
        return pot;
    }

    public static void Guess(bool higher)
    {
        if ((higher && nextNumber >= currentNumber) || (!higher && nextNumber <= currentNumber))
        {
            Console.WriteLine("You guessed right!");
            pot++;
        }
        else
        {
            Console.WriteLine("Bad luck, you guessed wrong!");
            pot--;
        }
        currentNumber = nextNumber;
        nextNumber = Random.Shared.Next(1, MAXIMUM + 1);
        Console.WriteLine($"The current number is {currentNumber}");
    }

    public static void Hint()
    {
        int half = MAXIMUM / 2;
        if (nextNumber >= half)
        {
            Console.WriteLine($"The current number is {currentNumber}, the next is at least {half}");
        }
        else
        {
            Console.WriteLine($"The current number is {currentNumber}, the next is at most {half}");
        }
        pot--;
    }

}