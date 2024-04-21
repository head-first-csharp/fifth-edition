namespace BeehiveManagementSystem;

static class Constants
{
    /// <summary>
    /// The amount of honey the hive starts with
    /// </summary>
    public const decimal INITIAL_HONEY = 25m;

    /// <summary>
    /// The amount of nectar the hive starts with
    /// </summary>
    public const decimal INITIAL_NECTAR = 100m;

    /// <summary>
    /// The amount of honey the queen consumes each shift
    /// </summary>
    public const decimal QUEEN_COST_PER_SHIFT = 2.15m;

    /// <summary>
    /// Number of eggs the queen lays per shift
    /// </summary>
    public const decimal EGGS_PER_SHIFT = 0.45m;

    /// <summary>
    /// The shift report shows a warning if the honey level drops below this
    /// </summary>
    public const decimal LOW_LEVEL_WARNING = 10m;

    /// <summary>
    /// How much honey each unassigned worker consumes
    /// </summary>
    public const decimal HONEY_PER_UNASSIGNED_WORKER = 0.5m;

    /// <summary>
    /// Cost of a nectar collector per shift
    /// </summary>
    public const decimal NECTAR_COLLECTOR_COST = 1.95m;

    /// <summary>
    /// How much nectar a nectar collector can collect per shift
    /// </summary>
    public const decimal NECTAR_COLLECTED_PER_SHIFT = 33.25m;

    /// <summary>
    /// Cost of a honey manufacturer per shift
    /// </summary>
    public const decimal HONEY_MANUFACTURER_COST = 1.7m;

    /// <summary>
    /// How much nectar the honey manufacturer processes per shift
    /// </summary>
    public const decimal NECTAR_PROCESSED_PER_SHIFT = 33.15m;

    /// <summary>
    /// How many units of honey get converted from one unit of nectar
    /// </summary>
    public const decimal NECTAR_CONVERSION_RATIO = .19m;

    /// <summary>
    /// Cost of an egg care worker per shift
    /// </summary>
    public const decimal EGG_CARE_COST = 1.35m;

    /// <summary>
    /// Number of eggs an egg care worker converts to unassigned workers per shift
    /// </summary>
    public const decimal CARE_PROGRESS_PER_SHIFT = 0.15m;
}