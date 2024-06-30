class Comic(string name, int issue)
{
    public string Name { get { return name; } }
    public int Issue { get { return issue; } }

    public override string ToString() => $"{Name} (Issue #{Issue})";

    public static readonly IEnumerable<Comic> Catalog = [
        new Comic("Johnny America vs. the Pinko", 6),
        new Comic("Rock and Roll (limited edition)", 19),
        new Comic("Woman's Work", 36),
        new Comic("Hippie Madness (misprinted)", 57),
        new Comic("Revenge of the New Wave Freak", 68),
        new Comic("Black Monday", 74),
        new Comic("Beyond the Alternative", 83),
        new Comic("The Death of the Object", 97),
    ];

    public static readonly IReadOnlyDictionary<int, decimal> Prices =
    new Dictionary<int, decimal>() {
            { 6, 3600M },
            { 19, 500M },
            { 36, 650M },
            { 57, 13525M },
            { 68, 250M },
            { 74, 75M },
            { 83, 25.75M },
            { 97, 35.25M },
    };
}
