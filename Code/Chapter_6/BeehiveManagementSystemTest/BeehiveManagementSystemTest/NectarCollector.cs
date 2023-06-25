using System;
namespace BeehiveManagementSystemTest
{
    class NectarCollector : Bee
    {
        public NectarCollector() : base("Nectar Collector") { }

        public override float CostPerShift
        {
            get { return Constants.NECTAR_COLLECTOR_COST; }
        }

        protected override void DoJob()
        {
            HoneyVault.CollectNectar(Constants.NECTAR_COLLECTED_PER_SHIFT);
        }
    }

}

