class Outfit(string? top, string? bottom)
{
    public string? Top => top;
    public string? Bottom => bottom;
    public override string ToString() => $"{Top} and {Bottom}";
}
