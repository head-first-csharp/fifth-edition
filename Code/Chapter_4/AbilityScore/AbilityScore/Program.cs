using AbilityScore;

AbilityScoreCalculator calculator = new AbilityScoreCalculator();
while (true)
{
    calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
    calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide by");
    calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
    calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
    calculator.CalculateAbilityScore();
    Console.WriteLine("Calculated ability score: " + calculator.Score);
    Console.WriteLine("Press Q to quit, any other key to continue");
    char keyChar = Console.ReadKey(true).KeyChar;
    if ((keyChar == 'Q') || (keyChar == 'q')) return;
}

static int ReadInt(int defaultValue, string prompt)
{
    Console.Write(prompt + " [" + defaultValue + "]: ");
    string? line = Console.ReadLine();
    if (int.TryParse(line, out int value))
    {
        Console.WriteLine("   using value " + value);
        return value;
    }
    else
    {
        Console.WriteLine("   using default value " + defaultValue);
        return defaultValue;
    }
}

static double ReadDouble(double defaultValue, string prompt)
{
    Console.Write(prompt + " [" + defaultValue + "]: ");
    string? line = Console.ReadLine();
    if (double.TryParse(line, out double value))
    {
        Console.WriteLine("   using value " + value);
        return value;
    }
    else
    {
        Console.WriteLine("   using default value " + defaultValue);
        return defaultValue;
    }
}