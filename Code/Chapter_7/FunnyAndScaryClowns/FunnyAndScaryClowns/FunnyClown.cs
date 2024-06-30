class FunnyClown : IClown
{
    private string funnyThingIHave;

    public string FunnyThingIHave { get { return funnyThingIHave; } }

    public FunnyClown(string funnyThingIHave)
    {
        this.funnyThingIHave = funnyThingIHave;
    }

    public void Honk()
    {
        Console.WriteLine($"Hi kids! I have {funnyThingIHave}.");
    }
}