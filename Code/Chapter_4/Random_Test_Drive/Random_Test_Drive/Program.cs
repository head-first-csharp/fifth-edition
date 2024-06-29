int randomInt = Random.Shared.Next();
Console.WriteLine(randomInt);

int zeroToNine = Random.Shared.Next(10);
Console.WriteLine(zeroToNine);

int dieRoll = Random.Shared.Next(1, 7);
Console.WriteLine(dieRoll);

double randomDouble = Random.Shared.NextDouble();

Console.WriteLine(randomDouble * 100);


Console.WriteLine((float)randomDouble * 100F);
Console.WriteLine((decimal)randomDouble * 100M);


int zeroOrOne = Random.Shared.Next(2);
bool coinFlip = Convert.ToBoolean(zeroOrOne);
Console.WriteLine(coinFlip);
