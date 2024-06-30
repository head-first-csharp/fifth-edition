class Card(Values value, Suits suit)
{

    public Values Value { get { return value; } }

    public Suits Suit { get { return suit; } }

    public string Name
    {
        get { return $"{Value} of {Suit}"; }
    }

}
