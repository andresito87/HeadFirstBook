using Guys;

Guy joe = new Guy() { Name = "Joe", Cash = 50 };

Guy bob = new Guy() { Name = "Bob", Cash = 100 };
while (true)
{
    joe.WriteMyInfo();
    bob.WriteMyInfo();

    Console.Write("Enter an amount: ");
    string? howMuch = Console.ReadLine();

    if (howMuch == "")
    {
        return;
    }
    if (int.TryParse(howMuch, out int amount))
    {
        Console.Write("Who should give the cash: (Joe or Bob)");
        string? whichGuy = Console.ReadLine();
        if (whichGuy == "Joe")
        {
            int cashGiven = joe.GiveCash(amount);
            bob.ReceivedCash(cashGiven);
        }
        else if (whichGuy == "Bob")
        {
            int cashGiven = bob.GiveCash(amount);
            joe.ReceivedCash(amount);
        }
        else
        {
            Console.WriteLine("Please enter 'Joe' or 'Bob'");
        }
    }
    else
    {
        Console.WriteLine("Please enter an amount (or a blank line to exit).");
    }
}

