using Animals;

Animal[] animals =
[
    new Wolf(false),
    new Hippo(),
    new Wolf(true),
    new Wolf(false),
    new Hippo()
];

foreach (Animal animal in animals)
{
    animal.MakeNoise();
    if (animal is Hippo hippo)
    {
        hippo.Swim();
    }
    if (animal is Wolf wolf)
    {
        wolf.HuntInPack();
    }
    Console.WriteLine();
}

foreach (Animal animal in animals)
{
    animal.MakeNoise();
    if (animal is ISwimmer swimmer)
    {
        swimmer.Swim();
    }
    if (animal is IPackHunter hunter)
    {
        hunter.HuntInPack();
    }
    Console.WriteLine();
}