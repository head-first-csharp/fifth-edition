List<Card> cards = new List<Card>();
Console.Write("Enter number of cards: ");
if (int.TryParse(Console.ReadLine(), out int numberOfCards))
    for (int i = 0; i < numberOfCards; i++)
        cards.Add(RandomCard());

PrintCards(cards);

cards.Sort(new CardComparerByValue());
Console.WriteLine("\n... sorting the cards ...\n");
PrintCards(cards);
void PrintCards(List<Card> cards)
{
    foreach (Card card in cards)
    {
        Console.WriteLine(card);
    }
}

Card RandomCard()
{
    return new Card((Values)Random.Shared.Next(1, 14), (Suits)Random.Shared.Next(4));
}
