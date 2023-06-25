using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    class NectarCollector : Bee
    {
        public NectarCollector() : base("Nectar Collector") { }

        public override decimal CostPerShift
        {
            get { return Constants.NECTAR_COLLECTOR_COST; }
        }

        public override bool WorkTheNextShift()
        {
            HoneyVault.CollectNectar(Constants.NECTAR_COLLECTED_PER_SHIFT);
            return base.WorkTheNextShift();
        }
    }

}
