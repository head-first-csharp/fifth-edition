using System.ComponentModel;

namespace AddDataBinding;

class Moods : INotifyPropertyChanged
{
    public string CurrentMood { get; private set; } = "I'm happy!";

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged(string name)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    public void UpdateMood()
    {
        switch (Random.Shared.Next(1, 4))
        {
            case 1:
                CurrentMood = "I'm happy!";
                break;
            case 2:
                CurrentMood = "Oh so sad.";
                break;
            default:
                CurrentMood = "Feeling good.";
                break;
        }
        SemanticScreenReader.Announce(CurrentMood);

        OnPropertyChanged("CurrentMood");
    }
}