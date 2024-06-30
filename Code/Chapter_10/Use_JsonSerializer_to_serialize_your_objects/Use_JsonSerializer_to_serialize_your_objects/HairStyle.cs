class HairStyle(HairColor color, float length)
{
    public HairColor Color => color;
    public float Length => length;
    public override string ToString() => $"{Length:0.0} inch {Color} hair";
}
