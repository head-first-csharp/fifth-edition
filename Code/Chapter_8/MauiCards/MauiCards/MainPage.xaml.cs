using System.Collections.ObjectModel;

namespace MauiCards;

public partial class MainPage : ContentPage
{
    private string[] birds = new string[] {
        "Duck",
        "Pigeon",
        "Penguin",
        "Ostrich",
        "Owl"
    };

    public MainPage()
    {
        InitializeComponent();
    }

    private Deck getDeckFromResources()
    {
        if (Resources.TryGetValue("MyCards", out object myCards) && myCards is Deck deck)
            return deck;
        else
            return new Deck();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        getDeckFromResources().Add(
           new Card((Values)Random.Shared.Next(1, 14), (Suits)Random.Shared.Next(4)));
    }

    private void Shuffle_Clicked(object sender, EventArgs e) { getDeckFromResources().Shuffle(); }

    private void Sort_Clicked(object sender, EventArgs e) { getDeckFromResources().Sort(); }

    private void Reset_Clicked(object sender, EventArgs e) { getDeckFromResources().Reset(); }

    private void Clear_Clicked(object sender, EventArgs e) { getDeckFromResources().Clear(); }

}
