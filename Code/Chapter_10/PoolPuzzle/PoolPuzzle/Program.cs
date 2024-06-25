const string d = "delivery.txt";

var o = new StreamWriter("order.txt");
var pz = new Pizza(new StreamWriter(d, true));
pz.Idaho(Fargo.Flamingo);
for (int w = 3; w >= 0; w--)
{
    var i = new Pizza(new StreamWriter(d, false));
    i.Idaho((Fargo)w);
    Party p = new Party(new StreamReader(d));
    p.HowMuch(o);
}
o.WriteLine("That’s all folks!");
o.Close();


enum Fargo
{
    North, South, East, West, Flamingo
}

class Pizza(StreamWriter writer)
{
    public void Idaho(Fargo f)
    {
        writer.WriteLine(f);
        writer.Close();
    }
}

class Party(StreamReader reader)
{
    public void HowMuch(StreamWriter q)
    {
        q.WriteLine(reader.ReadLine());
        reader.Close();
    }
}