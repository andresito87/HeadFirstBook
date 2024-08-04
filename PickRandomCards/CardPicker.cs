
namespace PickRandomCards;

internal class CardPicker
{
    public static string[] PickSomeCards(int numberOfCards)
    {
        string[] pickerCards = new string[numberOfCards];

        for (int i = 0; i < pickerCards.Length; i++)
        {
            pickerCards[i] = RandomValue() + " of " + RandomSuit();
        }

        return pickerCards;
    }

    private static string RandomSuit()
    {
        String suit = "Diamonds";
        int value = Random.Shared.Next(1, 5);
        if (value == 1)
        {
            suit = "Spades";
        }
        if (value == 2)
        {
            suit = "Hearts";
        }
        if (value == 3)
        {
            suit = "Clubs";
        }

        return suit;
    }

    private static string RandomValue()
    {
        int value = Random.Shared.Next(1, 14);
        string result = value.ToString();

        if (value == 1)
        {
            result = "Ace";
        }
        if (value == 11)
        {
            result = "Jack";
        }
        if (value == 12)
        {
            result = "Queen";
        }
        if (value == 13)
        {
            result = "King";
        }

        return result;
    }
}
