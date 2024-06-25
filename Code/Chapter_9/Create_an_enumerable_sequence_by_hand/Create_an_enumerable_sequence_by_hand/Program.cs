using System.Collections;

var sports = new ManualSportSequence();
foreach (var sport in sports)
    Console.WriteLine(sport);

enum Sport { Football, Baseball, Basketball, Hockey, Boxing, Rugby, Fencing }

class ManualSportSequence : IEnumerable<Sport>
{
    public IEnumerator<Sport> GetEnumerator()
    {
        return new ManualSportEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}


class ManualSportEnumerator : IEnumerator<Sport>
{
    int current = -1;

    public Sport Current => (Sport)current;

    object IEnumerator.Current => Current;

    public void Dispose() { }

    public bool MoveNext()
    {
        var maxEnumValue = Enum.GetValues(typeof(Sport)).Length;
        if ((int)current >= maxEnumValue - 1)
            return false;
        current++;
        return true;
    }
    public void Reset() => current = 0;
}
