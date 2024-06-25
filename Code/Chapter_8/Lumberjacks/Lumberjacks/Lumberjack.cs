namespace Lumberjacks;

class Lumberjack(string name)
{
    public string Name { get { return name; } }

    private Stack<Flapjack> flapjackStack = new Stack<Flapjack>();

    public void TakeFlapjack(Flapjack flapjack)
    {
        flapjackStack.Push(flapjack);
    }

    public void EatFlapjacks()
    {
        Console.WriteLine($"{Name} is eating flapjacks");
        while (flapjackStack.Count > 0)
        {
            Console.WriteLine(
                $"{Name} ate a {flapjackStack.Pop().ToString().ToLower()} flapjack");
        }
    }
}