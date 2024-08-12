using DamageCalculator;

// Program calculates sword damage
SwordDamage swordDamage = new(RollDice());

string keyPressed;
do
{
    Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
    keyPressed = Console.ReadKey().KeyChar.ToString();

    swordDamage.Roll = RollDice();

    switch (keyPressed)
    {
        case "0":
            swordDamage.Magic = false;
            swordDamage.Flaming = false;
            break;
        case "1":
            swordDamage.Magic = false;
            swordDamage.Flaming = false;
            break;
        case "2":
            swordDamage.Magic = true;
            swordDamage.Flaming = true;
            break;
        case "3":
            swordDamage.Magic = false;
            swordDamage.Flaming = true;
            break;
    }
    Console.WriteLine("\nRolled " + swordDamage.Roll + " for " + swordDamage.Damage + "HP\n");
} while (keyPressed == "0" || keyPressed == "1" || keyPressed == "2" || keyPressed == "3");

int RollDice()
{
    return Random.Shared.Next(1, 7) + Random.Shared.Next(1, 7) + Random.Shared.Next(1, 7);
}