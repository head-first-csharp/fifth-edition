Console.WriteLine("Press a to add a clone, c to clear the list, and g to collect");
var stopwatch = System.Diagnostics.Stopwatch.StartNew();
var clones = new List<EvilClone>();
while (true)
{
    switch (Console.ReadKey(true).KeyChar)
    {
        case 'a':
            clones.Add(new EvilClone());
            break;
        case 'c':
            Console.WriteLine("Clearing list at time {0}", stopwatch.ElapsedMilliseconds);
            clones.Clear();
            break;
        case 'g':
            Console.WriteLine("Collecting at time {0}", stopwatch.ElapsedMilliseconds);
            GC.Collect();
            break;
    };
}