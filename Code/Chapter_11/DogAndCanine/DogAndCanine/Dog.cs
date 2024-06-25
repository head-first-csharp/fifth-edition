struct Dog(string name, string breed)
{
    public string Name { get; set; } = name;

    public string Breed { get; set; } = breed;

    public void Speak()
    {
        Console.WriteLine("My name is {0} and I’m a {1}.", Name, Breed);
    }
}