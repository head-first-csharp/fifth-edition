namespace BeehiveManagementSystemTest;

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

        UpdateStatusAndEnableAssignButton();

        Dispatcher.StartTimer(TimeSpan.FromSeconds(1.5), TimerTick);
    }

    private bool TimerTick()
    {
        if (!this.IsLoaded) return false;

        WorkShiftButton_Clicked(this, new EventArgs());
        return true;
    }

    private void UpdateStatusAndEnableAssignButton()
    {
        StatusReport.Text = queen.StatusReport;
        AssignJobButton.IsEnabled = queen.CanAssignWorkers;
    }

    private void WorkShiftButton_Clicked(object sender, EventArgs e)
    {
        if (!queen.WorkTheNextShift())
        {
            WorkShiftButton.IsVisible = false;
            OutOfHoneyButton.IsVisible = true;
            SemanticScreenReader.Default.Announce(OutOfHoneyButton.Text);
        }

        UpdateStatusAndEnableAssignButton();
    }

    private void AssignJobButton_Clicked(object sender, EventArgs e)
    {
        queen.AssignBee(JobPicker.SelectedItem.ToString());
        UpdateStatusAndEnableAssignButton();
    }

    private void OutOfHoneyButton_Clicked(object sender, EventArgs e)
    {
        queen = new Queen();
        HoneyVault.Reset();
        WorkShiftButton.IsVisible = true;
        OutOfHoneyButton.IsVisible = false;
        UpdateStatusAndEnableAssignButton();
    }
}


