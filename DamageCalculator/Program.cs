using DamageCalculator;

// Program calculates sword damage
SwordDamage swordDamage = new SwordDamage();

string keyPressed;
do
{
    Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
    keyPressed = Console.ReadKey().KeyChar.ToString();

    swordDamage.Roll = Random.Shared.Next(1, 7) + Random.Shared.Next(1, 7) + Random.Shared.Next(1, 7);

    switch (keyPressed)
    {
        case "0":
            swordDamage.SetMagic(false);
            swordDamage.SetFlaming(false);
            break;
        case "1":
            swordDamage.SetMagic(false);
            swordDamage.SetFlaming(false);
            break;
        case "2":
            swordDamage.SetMagic(true);
            swordDamage.SetFlaming(true);
            break;
        case "3":
            swordDamage.SetMagic(false);
            swordDamage.SetFlaming(true);
            break;
    }
    Console.WriteLine("\nRolled " + swordDamage.Roll + " for " + swordDamage.Damage + "HP\n");
} while (keyPressed == "0" || keyPressed == "1" || keyPressed == "2" || keyPressed == "3");