using System.Collections;

foreach (var sport in new BetterSportSequence())
    Console.WriteLine(sport);

var sequence = new BetterSportSequence();
Console.WriteLine(sequence[3]);

enum Sport { Football, Baseball, Basketball, Hockey, Boxing, Rugby, Fencing }

class BetterSportSequence : IEnumerable<Sport>
{
    public IEnumerator<Sport> GetEnumerator()
    {
        int maxEnumValue = Enum.GetValues(typeof(Sport)).Length - 1;
        for (int i = 0; i <= maxEnumValue; i++)
        {
            yield return (Sport)i;
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public Sport this[int index]
    {
        get => (Sport)index;
    }
}