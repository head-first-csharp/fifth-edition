using SuitsAndValuesEnums;

Card card = new Card((Values)Random.Shared.Next(1, 14), (Suits)Random.Shared.Next(4));
Console.WriteLine(card.Name);

