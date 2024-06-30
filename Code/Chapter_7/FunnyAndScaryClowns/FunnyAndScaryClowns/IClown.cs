interface IClown
{
    string FunnyThingIHave { get; }
    void Honk();

    private static int carCapacity = 12;

    public static int CarCapacity
    {
        get { return carCapacity; }
        set
        {
            if (value > 10) carCapacity = value;
            else Console.Error.WriteLine($"Warning: Car capacity {value} is too small");
        }
    }

    public static string ClownCarDescription()
    {
        return $"A clown car with {Random.Shared.Next(CarCapacity / 2, CarCapacity)} clowns";
    }
}
