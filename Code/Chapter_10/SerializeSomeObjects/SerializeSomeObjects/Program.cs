using System.Text.Json;

List<Guy> guys = [
    new Guy(
        "Bob",
        new Outfit("t-shirt", "jeans"),
        new HairStyle(HairColor.Red, 3.5f)
    ),
   new Guy(
       "Joe",
       new Outfit("polo", "slacks"),
       new HairStyle(HairColor.Gray, 2.7f)
   ),
];

var jsonString = JsonSerializer.Serialize(guys);
Console.WriteLine(jsonString);


var copyOfGuys = JsonSerializer.Deserialize<List<Guy>>(jsonString);
if (copyOfGuys != null)
    foreach (var guy in copyOfGuys)
        Console.WriteLine("I deserialized this guy: {0}", guy);


var dudes = JsonSerializer.Deserialize<Stack<Dude>>(jsonString);
while (dudes.Count > 0)
{
    var dude = dudes.Pop();
    Console.WriteLine($"Next dude: {dude.Name} with {dude.Hair} hair");
}