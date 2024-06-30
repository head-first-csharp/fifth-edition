var array = new[] { 1, 2, 3, 4 };
var result = array.Select(TimesTwo());

foreach (var i in result)
    Console.WriteLine(i);

static Func<int, int> TimesTwo()
{
    return i => i * 2;
}