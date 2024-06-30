class PrintWhenGetting
{
    private int number;
    public PrintWhenGetting(int number)
    {
        this.number = number;
    }
    public int Number
    {
        get
        {
            Console.WriteLine($"Getting #{number}");
            return number;
        }
    }
}
