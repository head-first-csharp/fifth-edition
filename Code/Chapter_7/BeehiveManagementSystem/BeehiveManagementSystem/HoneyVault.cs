namespace BeehiveManagementSystem;

static class HoneyVault
{
    private static decimal honey = Constants.INITIAL_HONEY;
    private static decimal nectar = Constants.INITIAL_NECTAR;

    internal static void Reset()
    {
        honey = Constants.INITIAL_HONEY;
        nectar = Constants.INITIAL_NECTAR;
    }

    public static bool ConsumeHoney(decimal amount)
    {
        if (honey >= amount)
        {
            honey -= amount;
            return true;
        }
        return false;
    }

    public static void CollectNectar(decimal amount)
    {
        if (amount > 0m) nectar += amount;
    }

    public static void ConvertNectarToHoney(decimal amount)
    {
        decimal nectarToConvert = amount;
        if (nectarToConvert > nectar) nectarToConvert = nectar;
        nectar -= nectarToConvert;
        honey += nectarToConvert * Constants.NECTAR_CONVERSION_RATIO;
    }

    public static string StatusReport
    {
        get
        {
            string status = $"{honey:0.00} units of honey\n" +
                            $"{nectar:0.00} units of nectar";
            string warnings = "";
            if (honey < Constants.LOW_LEVEL_WARNING) warnings +=
                                "\nLOW HONEY - ADD A HONEY MANUFACTURER";

            if (nectar < Constants.LOW_LEVEL_WARNING) warnings +=
                                "\nLOW NECTAR - ADD A NECTAR COLLECTOR";

            return status + warnings;
        }
    }
}