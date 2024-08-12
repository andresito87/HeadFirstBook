// Game of PaintBall

// Ask to user for amount of balls and magazine size
int numberOfBalls = ReadInt(20, "Number of balls");
int magazineSize = ReadInt(16, "Magazine size");

Console.Write($"Loaded [false]: ");
bool.TryParse(Console.ReadLine(), out bool isLoaded); // If a parsing error occurs, it is set to false by default

PaintballGun gun = new(numberOfBalls, magazineSize, isLoaded);
while (true)
{
    Console.WriteLine($"{gun.Balls} balls, {gun.BallsLoaded} loaded");
    if (gun.IsEmpty())
    {
        Console.WriteLine("WARNING: You're aout of ammo");
    }
    char key = Console.ReadKey(true).KeyChar;
    if (key == ' ')
    {
        Console.WriteLine($"Shooting returned {gun.Shoot()}");
    }
    else if (key == 'r')
    {
        gun.Reload();
    }
    else if (key == '+')
    {
        gun.Balls += gun.MagazineSize;
    }
    else
    {
        return;
    }
}

static int ReadInt(int defaultValue, string prompt)
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