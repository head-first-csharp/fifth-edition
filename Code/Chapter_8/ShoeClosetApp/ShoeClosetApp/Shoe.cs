namespace ShoeClosetApp;

class Shoe(Style style, string? color)
{
    public Style Style
    {
        get { return style; }
    }

    public string? Color
    {
        get { return color; }
    }

    public string Description
    {
        get { return $"A {Color} {Style}"; }
    }
}