Guy guy;
guy = new Guy() { Age = 25 };
Console.WriteLine("guy.Name is {0} letters long", guy.Name.Length);

class Guy
{
    public string Name { get; set; }
    public int Age { get; set; }
    public override string ToString() =>
                       $"a {Age}-year-old named {Name}";
}
