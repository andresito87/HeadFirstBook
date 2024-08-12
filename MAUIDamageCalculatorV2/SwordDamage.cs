﻿namespace DamageCalculator;
class SwordDamage
{
    private const int BASE_DAMAGE = 3;
    private const int FLAME_DAMAGE = 2;

    private int roll;
    private bool magic;
    private bool flaming;

    /// <summary>
    /// Contains the calculated damage
    /// </summary>
    public int Damage { get; private set; }

    /// <summary>
    /// Sets or gets the 3d6 roll
    /// </summary>
    public int Roll
    {
        get { return roll; }
        set
        {
            roll = value;
            CalculateDamage(); // we keep the damage updated automatically
        }
    }

    /// <summary>
    /// True if the sword is magic, false otherwise
    /// </summary>
    public bool Magic
    {
        get { return magic; }
        set
        {
            magic = value;
            CalculateDamage();
        }
    }

    /// <summary>
    /// True if the sword is flaming, false otherwise
    /// </summary>
    public bool Flaming
    {
        get
        {
            return flaming;
        }
        set
        {
            flaming = value;
            CalculateDamage();
        }
    }


    /// <summary>
    /// Calculates the damage based on the currrent properties.
    /// </summary>
    public void CalculateDamage()
    {
        decimal magicMultiplier = 1M;
        if (Magic) magicMultiplier = 1.75M;

        Damage = BASE_DAMAGE;
        Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
        if (Flaming) Damage += FLAME_DAMAGE;
    }

    /// <summary>
    /// The constructor calculates damage based on default Magic
    /// and Flaming values and a starting 3d6 roll
    /// </summary>
    /// <param name="startingRoll">Starting 3d6 roll</param>
    public SwordDamage(int startingRoll)
    {
        roll = startingRoll;
        CalculateDamage();
    }
}
