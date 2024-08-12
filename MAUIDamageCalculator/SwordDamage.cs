namespace MAUIDamageCalculator;

using System.Diagnostics;
class SwordDamage
{
    public const int BASE_DAMAGE = 3;
    public const int FLAME_DAMAGE = 2;

    public int Roll;
    private decimal MagicMultiplier = 1M;
    public int Damage;

    public void CalculateDamage()
    {
        Damage = (int)(Roll * MagicMultiplier) + BASE_DAMAGE;
    }

    public void SetMagic(bool isMagic)
    {
        if (isMagic)
        {
            MagicMultiplier = 1.75M;
        }
        else
        {
            MagicMultiplier = 1M;
        }
        CalculateDamage();
        Debug.WriteLine($"SetMagic finished: Damage = {Damage} (roll: {Roll})");
    }

    public void SetFlaming(bool isFlaming)
    {
        CalculateDamage();
        if (isFlaming)
        {
            Damage += FLAME_DAMAGE;
        }
        Debug.WriteLine($"SetFlaming finished: Damage = {Damage} (roll: {Roll})");
    }
}

