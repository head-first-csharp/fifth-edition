var listOfObjects = new List<PrintWhenGetting>();
for (int i = 1; i < 5; i++)
    listOfObjects.Add(new PrintWhenGetting(i));

Console.WriteLine("Set up the query");
var result =
    from o in listOfObjects
    select o.Number;

var immediate = result.ToList();

Console.WriteLine("Run the foreach");
foreach (var number in result)
    Console.WriteLine($"Writing #{number}");


class PrintWhenGetting
{
    private int number;
    public PrintWhenGetting(int number)
    {
        this.number = number;
    }
    public int Number
    {
        get
        {
            Console.WriteLine($"Getting #{number}");
            return number;
        }
    }
}

