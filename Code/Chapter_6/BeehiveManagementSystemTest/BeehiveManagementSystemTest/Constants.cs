using System;
namespace BeehiveManagementSystemTest
{
    static class Constants
    {
        /// <summary>
        /// The amount of honey the hive starts with
        /// </summary>
        public const float INITIAL_HONEY = 25f;

        /// <summary>
        /// The amount of nectar the hive starts with
        /// </summary>
        public const float INITIAL_NECTAR = 100f;

        /// <summary>
        /// The amount of honey the queen consumes each shift
        /// </summary>
        public const float QUEEN_COST_PER_SHIFT = 2.15f;

        /// <summary>
        /// Number of eggs an egg the queen lays per shift
        /// </summary>
        public const float EGGS_PER_SHIFT = 0.45f;

        /// <summary>
        /// The shift report shows a warning if the honey level drops below this
        /// </summary>
        public const float LOW_LEVEL_WARNING = 10f;

        /// <summary>
        /// How much honey each unassigned worker consumes
        /// </summary>
        public const float HONEY_PER_UNASSIGNED_WORKER = 0.5f;

        /// <summary>
        /// Cost of a nectar collector per shift
        /// </summary>
        public const float NECTAR_COLLECTOR_COST = 1.95f;

        /// <summary>
        /// How much nectar a nectar collector can collect per shift
        /// </summary>
        public const float NECTAR_COLLECTED_PER_SHIFT = 33.25f;

        /// <summary>
        /// Cost of an honey manufacturer per shift
        /// </summary>
        public const float HONEY_MANUFACTURER_COST = 1.7f;

        /// <summary>
        /// How much nectar the honey manufacturer processes per shift
        /// </summary>
        public const float NECTAR_PROCESSED_PER_SHIFT = 33.15f;

        /// <summary>
        /// How many units of honey gets converted from one unit of nectar
        /// </summary>
        public const float NECTAR_CONVERSION_RATIO = .19f;

        /// <summary>
        /// Cost of an egg care worker per shift
        /// </summary>
        public const float EGG_CARE_COST = 1.35f;

        /// <summary>
        /// Number of eggs an egg care worker converts to unassigned workers per shift
        /// </summary>
        public const float CARE_PROGRESS_PER_SHIFT = 0.15f;
    }
}

