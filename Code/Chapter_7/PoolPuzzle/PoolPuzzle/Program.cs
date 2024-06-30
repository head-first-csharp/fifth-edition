string result = "";
INose[] i = new INose[3];
i[0] = new Acts();
i[1] = new Clowns();
i[2] = new Of2028();
for (int x = 0; x < 3; x++)
{
    result += $"{i[x].Ear()} {i[x].Face}\n";
}
Console.WriteLine(result);
Console.ReadKey();

interface INose
{
    int Ear();
    string Face { get; }
}

class Clowns : Picasso
{
    public Clowns() : base("Clowns") { }

    public override int Ear()
    {
        return 7;
    }
}

abstract class Picasso : INose
{
    private string face;
    public virtual string Face
    {
        get { return face; }
    }

    public abstract int Ear();

    public Picasso(string face)
    {
        this.face = face;
    }
}

class Acts : Picasso
{
    public Acts() : base("Acts") { }
    public override int Ear()
    {
        return 5;
    }
}

class Of2028 : Clowns
{
    public override string Face
    {
        get { return "Of2028"; }
    }
}