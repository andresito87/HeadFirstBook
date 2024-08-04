
using Guys;

double odds = .75;
Random random = new Random();

Guy player = new Guy() { Name = "The player", Cash = 100 };

Console.WriteLine("Welcome to the casino. The odds are " + odds);


while (player.Cash > 0)
{
    player.WriteMyInfo();
    Console.Write("How much do you want to bet:");
    string? line = Console.ReadLine();

    if (int.TryParse(line, out int amount))
    {

        int pot = player.GiveCash(amount) * 2;
        if (pot > 0)
        {
            if (random.NextDouble() > odds)
            {
                player.ReceivedCash(pot);
                Console.WriteLine("You win " + pot);
            }
            else
            {
                Console.WriteLine("Bad luck, you lose.");
            }

        }
    }
    else
    {
        Console.WriteLine("Please enter a valid number.");
    }
}

Console.WriteLine("The house always wins.");



