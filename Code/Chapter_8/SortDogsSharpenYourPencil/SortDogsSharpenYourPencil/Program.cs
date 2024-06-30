List<Dog> dogs = [
    new Dog(Breeds.Dachshund, "Franz"),
    new Dog(Breeds.Collie, "Petunia"),
    new Dog(Breeds.Mastiff, "Pepperoni"),
    new Dog(Breeds.Dachshund, "Brunhilda"),
    new Dog(Breeds.Malanois, "Zippy"),
    new Dog(Breeds.Collie, "Carrie"),
];

dogs.Sort();
foreach (Dog dog in dogs)
    Console.WriteLine(dog);

enum Breeds
{
    Collie = 3,
    Malanois = -9,
    Dachshund = 7,
    Mastiff = 0,
}

class Dog(Breeds breed, string name) : IComparable<Dog>
{
    public Breeds Breed { get { return breed; } }

    public string Name { get { return name; } }

    public int CompareTo(Dog? other)
    {
        if (other == null) return 0;
        if (Breed > other.Breed) return -1;
        if (Breed < other.Breed) return 1;
        return -Name.CompareTo(other.Name);
    }

    public override string ToString()
    {
        return $"A {Breed} named {Name}";
    }
}
