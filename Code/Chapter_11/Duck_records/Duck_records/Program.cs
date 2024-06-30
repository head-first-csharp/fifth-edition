var duck = new Duck();
// var smallerDuck = duck; // this won't work! we're just copying the reference
// smallerDuck.Size = 26; // this line will have a syntax error
var smallerDuck = duck with { Size = 21 };
Console.WriteLine(smallerDuck);

record Duck(int Size = 24, KindOfDuck Kind = KindOfDuck.Mallard);

enum KindOfDuck
{
    Mallard,
    Muscovy,
    Loon,
}