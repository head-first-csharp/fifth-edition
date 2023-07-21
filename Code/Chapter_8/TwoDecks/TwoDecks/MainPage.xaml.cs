using MauiCards;

namespace TwoDecks;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private Deck getDeckFromResources(String key)
    {
        if (Resources.TryGetValue(key, out object resource) && resource is Deck deck)
            return deck;
        else
            return new Deck();
    }

    private void shuffleLeftDeck_Clicked(object sender, EventArgs e)
    {
        getDeckFromResources("LeftDeck").Shuffle();
    }

    private void sortLeftDeck_Clicked(object sender, EventArgs e)
    {
        getDeckFromResources("LeftDeck").Sort();
    }

    private void clearLeftDeck_Clicked(object sender, EventArgs e)
    {
        getDeckFromResources("LeftDeck").Clear();
    }

    private void resetLeftDeck_Clicked(object sender, EventArgs e)
    {
        getDeckFromResources("LeftDeck").Reset();
    }

    private void moveLeftDeck_Clicked(object sender, EventArgs e)
    {
        if (LeftListView.SelectedItem is Card card)
        {
            getDeckFromResources("RightDeck").Add(card);
            getDeckFromResources("LeftDeck").Remove(card);
        }
    }

    private void shuffleRightDeck_Clicked(object sender, EventArgs e)
    {
        getDeckFromResources("RightDeck").Shuffle();
    }

    private void sortRightDeck_Clicked(object sender, EventArgs e)
    {
        getDeckFromResources("RightDeck").Sort();
    }

    private void clearRightDeck_Clicked(object sender, EventArgs e)
    {
        getDeckFromResources("RightDeck").Clear();
    }

    private void resetRightDeck_Clicked(object sender, EventArgs e)
    {
        getDeckFromResources("RightDeck").Reset();
    }

    private void moveRightDeck_Clicked(object sender, EventArgs e)
    {
        if (RightListView.SelectedItem is Card card)
        {
            getDeckFromResources("LeftDeck").Add(card);
            getDeckFromResources("RightDeck").Remove(card);
        }
    }
}

