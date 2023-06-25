using System;
namespace BeehiveManagementSystemTest
{
    class EggCare : Bee
    {
        private Queen queen;

        public EggCare(Queen queen) : base("Egg Care")
        {
            this.queen = queen;
        }

        public override float CostPerShift
        {
            get { return Constants.EGG_CARE_COST; }
        }

        protected override void DoJob()
        {
            queen.ReportEggConversion(Constants.CARE_PROGRESS_PER_SHIFT);
        }
    }
}

