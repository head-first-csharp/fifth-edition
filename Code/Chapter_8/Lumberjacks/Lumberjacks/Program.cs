using Lumberjacks;

Queue<Lumberjack> lumberjacks = new Queue<Lumberjack>();

string? name;
Console.Write("First lumberjack's name: ");
while (!String.IsNullOrEmpty(name = Console.ReadLine()))
{
    Console.Write("Number of flapjacks: ");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        Lumberjack lumberjack = new Lumberjack(name);
        for (int i = 0; i < number; i++)
        {
            lumberjack.TakeFlapjack((Flapjack)Random.Shared.Next(0, 4));
        }
        lumberjacks.Enqueue(lumberjack);
    }
    Console.Write("Next lumberjack's name (blank to end): ");
}

while (lumberjacks.Count > 0)
{
    Lumberjack next = lumberjacks.Dequeue();
    next.EatFlapjacks();
}