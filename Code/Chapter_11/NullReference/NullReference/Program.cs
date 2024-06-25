Guy guy;
guy = new Guy("Bob", 25);
Console.WriteLine("guy.Name is {0} letters long", guy.Name.Length);

class Guy(string name, int age)
{
    public string Name => name;
    public int Age { get => age; set => age = value; }
    public override string ToString() => $"a {age}-year-old named {name}";
}
