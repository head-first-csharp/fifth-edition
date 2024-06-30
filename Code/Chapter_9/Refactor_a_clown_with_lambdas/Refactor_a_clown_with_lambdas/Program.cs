TallGuy tallGuy = new TallGuy() { Height = 76, Name = "Jimmy" };
tallGuy.TalkAboutYourself();
Console.WriteLine($"The tall guy has {tallGuy.FunnyThingIHave}");
tallGuy.Honk();

interface IClown
{
    string FunnyThingIHave { get; }
    void Honk();
}

class TallGuy : IClown
{
    public string? Name;
    public int Height;

    public string FunnyThingIHave => "big red shoes";

    public void Honk() => Console.WriteLine("Honk honk!");

    public void TalkAboutYourself()
    {
        Console.WriteLine($"My name is {Name} and I'm {Height} inches tall.");
    }
}

