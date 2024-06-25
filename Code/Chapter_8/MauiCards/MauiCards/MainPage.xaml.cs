using System.Collections.ObjectModel;

namespace MauiCards
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private Deck GetDeckFromResources()
        {
            if (Resources.TryGetValue("MyCards", out object myCards) && myCards is Deck deck)
                return deck;
            else
                return new Deck();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            GetDeckFromResources().Add(
               new Card((Values)Random.Shared.Next(1, 14), (Suits)Random.Shared.Next(4)));
        }

        private void MyItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MyItems.SelectedItem == null)
                SelectedCard.Text = $"No card selected";
            else
                SelectedCard.Text = $"You selected {MyItems.SelectedItem}";
        }

        private void Shuffle_Clicked(object sender, EventArgs e) { GetDeckFromResources().Shuffle(); }

        private void Sort_Clicked(object sender, EventArgs e) { GetDeckFromResources().Sort(); }

        private void Reset_Clicked(object sender, EventArgs e) { GetDeckFromResources().Reset(); }

        private void Clear_Clicked(object sender, EventArgs e) { GetDeckFromResources().Clear(); }
    }

}
