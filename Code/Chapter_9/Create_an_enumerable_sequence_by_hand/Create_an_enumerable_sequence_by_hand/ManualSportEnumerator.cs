using System.Collections;

class ManualSportEnumerator : IEnumerator<Sport>
{
    int current = -1;
    public Sport Current => (Sport)current;
    public void Dispose() { } // You'll meet the Dispose method in Chapter 10
    object IEnumerator.Current => Current;
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
