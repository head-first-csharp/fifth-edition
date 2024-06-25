var clones = Clone.CloneNames
    .Select(name => new Clone(name, Random.Shared.Next(1, Clone.MAX_ID))).ToList();

int selectedName = 0;
int selectedId = 1;
var startTime = DateTime.Now;
var lastAddTime = DateTime.Now;

while (clones.Count > 0)
{
    Console.Clear();
    Console.Write("Name: ");
    for (var i = 0; i < Clone.CloneNames.Count; i++)
    {
        var name = Clone.CloneNames[i];
        Console.Write($"{(i == selectedName ? name.ToUpper() : name)}\t");
    }
    Console.Write($"{Environment.NewLine}ID:  \t");
    for (int i = 1; i <= Clone.MAX_ID; i++)
        Console.Write($"{(i == selectedId ? $">{i}<" : i)}\t");

    Console.WriteLine($@"

Target clones: Name = up/down arrows, ID = left/right arrows, enter = fire

Clones: {clones.Count}          Time: {(DateTime.Now - startTime).TotalSeconds:0.0}s");

    int count = 0;
    string LineBreakOrTab() => ++count % 5 == 0 ? Environment.NewLine : "\t";
    clones.ForEach(clone => Console.Write($"{clone}{LineBreakOrTab()}"));

    if (Console.KeyAvailable)
    {
        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.UpArrow:
                if (selectedName > 0) selectedName--;
                break;
            case ConsoleKey.DownArrow:
                if (selectedName < Clone.CloneNames.Count - 1) selectedName++;
                break;
            case ConsoleKey.LeftArrow:
                if (selectedId > 1) selectedId--;
                break;
            case ConsoleKey.RightArrow:
                if (selectedId < Clone.MAX_ID) selectedId++;
                break;
            case ConsoleKey.Enter:
                var target = new Clone(Clone.CloneNames[selectedName], selectedId);
                clones.Remove(target);
                break;
        }
    }

    if ((DateTime.Now - lastAddTime).TotalSeconds > Clone.ADD_SECONDS && clones.Count < 99)
    {
        var clone = clones[Random.Shared.Next(clones.Count)];
        clones.Add(clone with { Id = Random.Shared.Next(1, Clone.MAX_ID + 1) });
        lastAddTime = DateTime.Now;
    }
    Thread.Sleep(Clone.FRAME_DELAY_MILLISECONDS);
}

Console.WriteLine($"You won in {(DateTime.Now - startTime).TotalSeconds:0.0} seconds");