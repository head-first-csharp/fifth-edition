using CardLinq;

static string Output(Suits suit, int number) => $"Suit is {suit}, number is {number}";

var deck = new Deck();
var processedCards = deck
    .Take(3)
    .Concat(deck.TakeLast(3))
    .OrderByDescending(card => card)
    .Select(card => card.Value switch
    {
        Values.King => Output(card.Suit, 7),
        Values.Ace => $"It's an ace! {card.Suit}",
        Values.Jack => Output((Suits)card.Suit - 1, 9),
        Values.Two => Output(card.Suit, 18),
        _ => card.ToString(),
    });

foreach (var output in processedCards)
{
    Console.WriteLine(output);
}

