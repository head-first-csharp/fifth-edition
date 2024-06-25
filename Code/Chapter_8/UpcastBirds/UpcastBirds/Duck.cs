namespace UpcastBirds;

class Duck(int size, KindOfDuck kind) : Bird
{
    public int Size { get { return size; } }
    public KindOfDuck Kind { get { return kind; } }

    public override string ToString()
    {
        return $"A {Size} inch {Kind}";
    }
}