using System;
namespace BeehiveManagementSystemTest
{
    class HoneyManufacturer : Bee
    {
        public HoneyManufacturer() : base("Honey Manufacturer") { }

        public override float CostPerShift
        {
            get { return Constants.HONEY_MANUFACTURER_COST; }
        }

        protected override void DoJob()
        {
            HoneyVault.ConvertNectarToHoney(Constants.NECTAR_PROCESSED_PER_SHIFT);
        }
    }

}

