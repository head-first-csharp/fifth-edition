using MauiCards;

namespace TwoDecks
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private Deck GetDeckFromResources(String key)
        {
            if (Resources.TryGetValue(key, out object resource) && resource is Deck deck)
                return deck;
            else
                return new Deck();
        }

        private void ShuffleLeftDeck_Clicked(object sender, EventArgs e)
        {
            GetDeckFromResources("LeftDeck").Shuffle();
        }

        private void SortLeftDeck_Clicked(object sender, EventArgs e)
        {
            GetDeckFromResources("LeftDeck").Sort();
        }

        private void ClearLeftDeck_Clicked(object sender, EventArgs e)
        {
            GetDeckFromResources("LeftDeck").Clear();
        }

        private void ResetLeftDeck_Clicked(object sender, EventArgs e)
        {
            GetDeckFromResources("LeftDeck").Reset();
        }

        private void MoveLeftDeck_Clicked(object sender, EventArgs e)
        {
            if (LeftCards.SelectedItem is Card card)
            {
                GetDeckFromResources("RightDeck").Add(card);
                GetDeckFromResources("LeftDeck").Remove(card);
            }
        }

        private void ShuffleRightDeck_Clicked(object sender, EventArgs e)
        {
            GetDeckFromResources("RightDeck").Shuffle();
        }

        private void SortRightDeck_Clicked(object sender, EventArgs e)
        {
            GetDeckFromResources("RightDeck").Sort();
        }

        private void ClearRightDeck_Clicked(object sender, EventArgs e)
        {
            GetDeckFromResources("RightDeck").Clear();
        }

        private void ResetRightDeck_Clicked(object sender, EventArgs e)
        {
            GetDeckFromResources("RightDeck").Reset();
        }

        private void MoveRightDeck_Clicked(object sender, EventArgs e)
        {
            if (RightCards.SelectedItem is Card card)
            {
                GetDeckFromResources("LeftDeck").Add(card);
                GetDeckFromResources("RightDeck").Remove(card);
            }
        }
    }
}