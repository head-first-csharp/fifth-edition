using PickRandomCards;

namespace PickRandomCardsMAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void PickCardsButton_Clicked(object sender, EventArgs e)
        {
            if (int.TryParse(NumberOfCards.Text, out int numberOfCards))
            {
                string[] cards = CardPicker.PickSomeCards(numberOfCards);
                PickedCards.Text = String.Empty;
                foreach (string card in cards)
                {
                    PickedCards.Text += card + Environment.NewLine;
                }
                PickedCards.Text += Environment.NewLine + "You picked " + numberOfCards + " cards.";
            }
            else
            {
                PickedCards.Text = "Please enter a valid number.";
            }
        }
    }

}
