using CardLinq;

var filename = "deckofcards.txt";
Deck deck = new Deck();
deck.Shuffle();
for (int i = deck.Count - 1; i > 9; i--)
    deck.RemoveAt(i);

deck.WriteCards(filename);

Deck cardsToRead = new Deck(filename);
foreach (var card in cardsToRead)
    Console.WriteLine(card.Name);
