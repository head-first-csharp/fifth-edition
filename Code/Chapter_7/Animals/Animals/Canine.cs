namespace Animals;

abstract class Canine : Animal
{
    public bool BelongsToPack { get; protected set; } = false;
}