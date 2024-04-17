new ConstructorTest(2);

public class ConstructorTest
{
    public int i = Random.Shared.Next();

    public ConstructorTest(int newIntValue)
    {
        i = newIntValue;
    }
}