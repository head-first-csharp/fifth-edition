using GoFish;
namespace GoFishTests;

[TestClass]
public class PlayerTests
{
    [TestMethod]
    public void TestGetNextHand()
    {
        var player = new Player("Owen", new List<Card>());
        player.GetNextHand(new Deck());
        CollectionAssert.AreEqual(
            new Deck().Take(5).Select(card => card.ToString()).ToList(),
            player.Hand.Select(card => card.ToString()).ToList());
    }

    [TestMethod]
    public void TestDoYouHaveAny()
    {
        IEnumerable<Card> cards = [
            new Card(Values.Jack, Suits.Spades),
            new Card(Values.Three, Suits.Clubs),
            new Card(Values.Three, Suits.Hearts),
            new Card(Values.Four, Suits.Diamonds),
            new Card(Values.Three, Suits.Diamonds),
            new Card(Values.Jack, Suits.Clubs),
        ];
        var player = new Player("Owen", cards);


        var threes = player.DoYouHaveAny(Values.Three, new Deck())
            .Select(Card => Card.ToString())
            .ToList();

        CollectionAssert.AreEqual(
           (string[])["Three of Diamonds", "Three of Clubs", "Three of Hearts"],
           threes);
        Assert.AreEqual(3, player.Hand.Count());

        var jacks = player.DoYouHaveAny(Values.Jack, new Deck())
            .Select(Card => Card.ToString())
            .ToList();

        CollectionAssert.AreEqual((string[])["Jack of Clubs", "Jack of Spades"], jacks);

        var hand = player.Hand.Select(Card => Card.ToString()).ToList();
        CollectionAssert.AreEqual((string[])["Four of Diamonds"], hand);

        Assert.AreEqual("Owen has 1 card and 0 books", player.Status);
    }

    [TestMethod]
    public void TestAddCardsAndPullOutBooks()
    {
        IEnumerable<Card> cards = [
            new Card(Values.Jack, Suits.Spades),
            new Card(Values.Three, Suits.Clubs),
            new Card(Values.Jack, Suits.Hearts),
            new Card(Values.Three, Suits.Hearts),
            new Card(Values.Four, Suits.Diamonds),
            new Card(Values.Jack, Suits.Diamonds),
            new Card(Values.Jack, Suits.Clubs),
        ];

        var player = new Player("Owen", cards);

        Assert.AreEqual(0, player.Books.Count());

        List<Card> cardsToAdd = [
            new Card(Values.Three, Suits.Diamonds),
            new Card(Values.Three, Suits.Spades),
        ];
        player.AddCardsAndPullOutBooks(cardsToAdd);
        var books = player.Books.ToList();
        CollectionAssert.AreEqual((Values[])[Values.Three, Values.Jack], books);

        var hand = player.Hand.Select(Card => Card.ToString()).ToList();
        CollectionAssert.AreEqual((string[])["Four of Diamonds"], hand);

        Assert.AreEqual("Owen has 1 card and 2 books", player.Status);
    }

    [TestMethod]
    public void TestDrawCard()
    {
        var player = new Player("Owen", new List<Card>());
        player.DrawCard(new Deck());
        Assert.AreEqual(1, player.Hand.Count());
        Assert.AreEqual("Ace of Diamonds", player.Hand.First().ToString());
    }

    [TestMethod]
    public void TestRandomValueFromHand()
    {
        var player = new Player("Owen", new Deck());

        Player.Random = new MockRandom() { ValueToReturn = 0 };
        Assert.AreEqual("Ace", player.RandomValueFromHand().ToString());
        Player.Random = new MockRandom() { ValueToReturn = 16 };
        Assert.AreEqual("Five", player.RandomValueFromHand().ToString());
        Player.Random = new MockRandom() { ValueToReturn = 51 };
        Assert.AreEqual("King", player.RandomValueFromHand().ToString());
    }
}
