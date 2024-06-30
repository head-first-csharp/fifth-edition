// See https://aka.ms/new-console-template for more information
record Clone(string Name, int Id)
{
    public const int MAX_ID = 6;
    public const double ADD_SECONDS = 1.5;
    public const int FRAME_DELAY_MILLISECONDS = 25;

    public static IReadOnlyList<string> CloneNames =
        ["ZapBot3000", "Smasho", "KillMeister", "Predatron", "Larry"];

    public override string ToString() => $"[{Name} #{Id}]";
}
