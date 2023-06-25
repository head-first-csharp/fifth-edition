namespace BeehiveManagementSystemTest
{
    static class HoneyVault
    {
        private static float honey = Constants.INITIAL_HONEY;
        private static float nectar = Constants.INITIAL_NECTAR;

        internal static void Reset()
        {
            honey = Constants.INITIAL_HONEY;
            nectar = Constants.INITIAL_NECTAR;
        }

        public static bool ConsumeHoney(float amount)
        {
            if (honey >= amount)
            {
                honey -= amount;
                return true;
            }
            return false;
        }

        public static void CollectNectar(float amount)
        {
            if (amount > 0f) nectar += amount;
        }

        public static void ConvertNectarToHoney(float amount)
        {
            float nectarToConvert = amount;
            if (nectarToConvert > nectar) nectarToConvert = nectar;
            nectar -= nectarToConvert;
            honey += nectarToConvert * Constants.NECTAR_CONVERSION_RATIO;
        }

        public static string StatusReport
        {
            get
            {

                string status = $"{honey:0.0} units of honey\n" +
                                $"{nectar:0.0} units of nectar";
                string warnings = "";
                if (honey < Constants.LOW_LEVEL_WARNING) warnings +=
                                    "\nLOW HONEY - ADD A HONEY MANUFACTURER";

                if (nectar < Constants.LOW_LEVEL_WARNING) warnings +=
                                    "\nLOW NECTAR - ADD A NECTAR COLLECTOR";

                SemanticScreenReader.Default.Announce(warnings);
                return status + warnings;
            }
        }
    }
}