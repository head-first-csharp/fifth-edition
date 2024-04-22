namespace AddDataBinding
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        Moods moods = new Moods();

        public MainPage()
        {
            InitializeComponent();

            BindingContext = moods;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            moods.UpdateMood();

            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
