var listOfObjects = new List<PrintWhenGetting>();
for (int i = 1; i < 5; i++)
    listOfObjects.Add(new PrintWhenGetting(i));

Console.WriteLine("Set up the query");
var result =
    from o in listOfObjects
    select o.Number;

Console.WriteLine("Run the foreach");
var immediate = result.ToList();
foreach (var number in immediate)
    Console.WriteLine($"Writing #{number}");
