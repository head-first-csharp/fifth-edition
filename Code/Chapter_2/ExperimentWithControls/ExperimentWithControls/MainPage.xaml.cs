namespace ExperimentWithControls;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

        BirdPicker.ItemsSource = new string[] {
            "Duck",
            "Pigeon",
            "Penguin",
            "Ostrich",
            "Owl"
        };
    }

    private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        EnteredText.Text = e.NewTextValue;
    }

    private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        StepperValue.Text = e.NewValue.ToString();
    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        SliderValue.Text = e.NewValue.ToString();
    }
    private void AddBird_Clicked(object sender, EventArgs e)
    {
        if (!String.IsNullOrEmpty(Birds.Text))
        {
            Birds.Text = Birds.Text + Environment.NewLine;
        }
        Birds.Text += BirdPicker.SelectedItem;
    }
}

