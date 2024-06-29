
namespace PickRandomCards;

internal class CardPicker
{
    public static string[] PickSomeCards(int numberOfCards)
    {
        string[] pickedCards = new string[numberOfCards];
        for (int i = 0; i < numberOfCards; i++)
        {
            pickedCards[i] = RandomValue() + " of " + RandomSuit();
        }
        return pickedCards;
    }

    private static string RandomSuit()
    {
        int value = Random.Shared.Next(1, 5);  // pick a random number from 1 to 4
        if (value == 1) return "Spades";       // if it's 1 return the string Spades
        if (value == 2) return "Hearts";       // if it's 2 return the string Hearts
        if (value == 3) return "Clubs";        // if it's 3 return the string Clubs
        return "Diamonds";                     // otherwise return the string
    }

    private static string RandomValue()
    {
        int value = Random.Shared.Next(1, 14);
        if (value == 1) return "Ace";
        if (value == 11) return "Jack";
        if (value == 12) return "Queen";
        if (value == 13) return "King";
        return value.ToString();
    }
}
