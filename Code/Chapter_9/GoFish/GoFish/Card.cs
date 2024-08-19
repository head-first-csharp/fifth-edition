namespace GoFish;

public class Card(Values value, Suits suit) : IComparable<Card>
{
    public int CompareTo(Card? other)
    {
        return new CardComparerByValue().Compare(this, other);
    }

    public Values Value { get { return value; } }

    public Suits Suit { get { return suit; } }

    public string Name
    {
        get { return $"{Value} of {Suit}"; }
    }

    public override string ToString()
    {
        return Name;
    }

}
