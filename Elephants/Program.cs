using Elephants;

Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };

char input;
do
{
    Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap, 4 for change elephant reference, 5 to use SpeakTo method");
    input = Console.ReadKey().KeyChar;
    if (input == '1')
    {
        Console.WriteLine(" Calling Lloyd");
        lloyd.WhoAmI();
    }
    else if (input == '2')
    {
        Console.WriteLine(" Calling Lucinda");
        lucinda.WhoAmI();
    }
    else if (input == '3')
    {
        Elephant aux = lloyd;
        lloyd = lucinda;
        lucinda = aux;
        Console.WriteLine(" References have been swapped");
    }
    else if (input == '4')
    {
        lloyd = lucinda;
        lloyd.EarSize = 4321;
        lloyd.WhoAmI();
    }
    else if (input == '5')
    {
        lucinda.SpeakTo(lloyd, "Hi, Lloyd!");
    }
    Console.WriteLine();

} while (input == '1'
            || input == '2'
            || input == '3'
            || input == '4'
            || input == '5'
            );

