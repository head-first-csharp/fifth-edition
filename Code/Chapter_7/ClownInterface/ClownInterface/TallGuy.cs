namespace ClownInterface;

class TallGuy : IClown
{
    private string? name;
    private int height;
    public TallGuy(string? name, int height)
    {
        this.name = name;
        this.height = height;
    }

    public void TalkAboutYourself()
    {
        Console.WriteLine($"My name is {name} and I'm {height} inches tall.");
    }

    public string FunnyThingIHave
    {
        get { return "big shoes"; }
    }

    public void Honk()
    {
        Console.WriteLine("Honk honk!");
    }
}