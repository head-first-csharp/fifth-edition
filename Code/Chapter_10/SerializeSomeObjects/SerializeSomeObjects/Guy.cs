class Guy(string? name, Outfit? clothes, HairStyle? hair)
{
    public string? Name => name;
    public HairStyle? Hair => hair;
    public Outfit? Clothes => clothes;
    public override string ToString() => $"{Name} with {Hair} wearing {Clothes}";
}