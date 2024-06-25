var duck = new Duck();
var smallerDuck = duck with { Size = 21 };
Console.WriteLine(smallerDuck);


record Duck(int Size = 24, KindOfDuck Kind = KindOfDuck.Mallard);

// Here's the KindOfDuck enum from Chapter 9
enum KindOfDuck { Mallard, Muscovy, Loon }
