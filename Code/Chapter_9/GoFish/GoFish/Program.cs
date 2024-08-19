using GoFish;

string? humanName = "";
while (String.IsNullOrWhiteSpace(humanName))
{
    Console.Write("Enter your name: ");
    humanName = Console.ReadLine();
}

Console.Write("Enter the number of computer opponents: ");
int opponentCount;
while (!int.TryParse(Console.ReadKey().KeyChar.ToString(), out opponentCount)
    || opponentCount < 1 || opponentCount > 4)
{
    Console.WriteLine("Please enter a number from 1 to 4");
}
Console.WriteLine($"{Environment.NewLine}Welcome to the game, {humanName}");


var gameController = new GameController(humanName,
            Enumerable.Range(1, opponentCount).Select(i => $"Computer #{i}"));
Console.WriteLine(gameController.Status);

while (!gameController.GameOver)
{
    while (!gameController.GameOver)
    {
        Console.WriteLine($"Your hand:");
        foreach (var card in gameController.HumanPlayer.Hand
            .OrderBy(card => card.Suit)
            .OrderBy(card => card.Value))
            Console.WriteLine(card);

        var value = PromptForAValue(gameController);

        var player = PromptForAnOpponent(gameController);

        gameController.NextRound(player, value);

        Console.WriteLine(gameController.Status);
    }

    Console.WriteLine("Press Q to quit, or any other key for a new game.");
    if (Console.ReadKey(true).KeyChar.ToString().ToUpper() == "N")
        gameController.NewGame();
}

/// <summary>
/// Asks the player for a card value currently in their hand
/// </summary>
/// <param name="gameController">The game controller</param>
/// <returns>The value to ask for</returns>
Values PromptForAValue(GameController gameController)
{
    var handValues = gameController.HumanPlayer.Hand.Select(card => card.Value).ToList();
    Console.Write("What card value do you want to ask for? ");
    while (true)
    {
        if (Enum.TryParse(typeof(Values), Console.ReadLine(), out var value) &&
            handValues.Contains((Values)value))
            return (Values)value;
        else
            Console.WriteLine("Please enter a value in your hand.");
    }
}

/// <summary>
/// Asks the player to select an opponent to ask for a card
/// </summary>
/// <param name="gameController">The game controller</param>
/// <returns>The opponent to ask</returns>
Player PromptForAnOpponent(GameController gameController)
{
    var opponents = gameController.Opponents.ToList();
    for (int i = 1; i <= opponents.Count(); i++)
        Console.WriteLine($"{i}. {opponents[i - 1]}");
    Console.Write("Who do you want to ask for a card? ");
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int selection)
            && selection >= 1 && selection <= opponents.Count())
            return opponents[selection - 1];
        else
            Console.Write($"Please enter a number from 1 to {opponents.Count()}: ");
    }
}