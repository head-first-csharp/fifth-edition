namespace BeehiveManagementSystem;

public partial class MainPage : ContentPage
{
    private Queen queen = new Queen();
    public MainPage()
    {
        InitializeComponent();
        JobPicker.ItemsSource = new string[]
        {
            "Nectar Collector",
            "Honey Manufacturer",
            "Egg Care"
        };
        JobPicker.SelectedIndex = 0;
        Dispatcher.StartTimer(TimeSpan.FromSeconds(1.5), TimerTick);
        BindingContext = queen;
    }
    private bool TimerTick()
    {
        if (!this.IsLoaded || !WorkShiftButton.IsVisible)
            return false;
        WorkShiftButton_Clicked(this, new EventArgs());

        return true;
    }
    private void WorkShiftButton_Clicked(object sender, EventArgs e)
    {
        if (!queen.WorkTheNextShift())
            SemanticScreenReader.Default.Announce(OutOfHoneyButton.Text);
    }
    private void AssignJobButton_Clicked(object sender, EventArgs e)
    {
        queen.AssignBee(JobPicker.SelectedItem.ToString());
    }
    private void OutOfHoneyButton_Clicked(object sender, EventArgs e)
    {
        HoneyVault.Reset();
        queen = new Queen();
        BindingContext = queen;
    }
}