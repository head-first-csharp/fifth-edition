var items = Enumerable.Range(0, 10)
    .Select((i) => new Feeling((Colors)(i % 4), i))
    .ToList();

Enumerable.Range(0, 6)
.Select((i) => new Feeling((Colors)((i * 3) % 4), i * 3))
.ToList()
.ForEach((item) => items.Remove(item));

Enumerable.Range(0, 3)
.Reverse()
.Select((i) => new Feeling((Colors)i, 8 - i * 3))
.ToList()
.ForEach((item) => items.Remove(item));

for (int i = 0; i < 3; i++)
    items[i] = items[i] with { Speak = Feeling.Extra[2 - i] };

foreach (var item in items)
    Console.Write($"{item.Speak} ");

foreach (var item in items)
    Console.Write(item);

record Feeling(Colors Color, int Degree, string Speak = "")
{
    public static readonly string[] Extra = ["TO", "NEED", "NO"];
    public override string ToString() => $"{Color}{(char)(68 + Degree)}";
}

enum Colors { RT, OV, NO, IN }