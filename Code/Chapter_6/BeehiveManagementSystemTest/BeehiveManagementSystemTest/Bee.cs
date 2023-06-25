using System;
namespace BeehiveManagementSystemTest
{
    class Bee
    {
        /// <summary>
        /// The units of honey this bee consumes per shift
        /// </summary>
        public virtual float CostPerShift { get; }

        /// <summary>
        /// The job assigned to this bee
        /// </summary>
        public string Job { get; private set; }

        /// <summary>
        /// The Bee class constructor
        /// </summary>
        /// <param name="job">The job to assign to this bee</param>
        public Bee(string job)
        {
            Job = job;
        }

        /// <summary>
        /// If there's enough honey for this bee to do its job, consume the honey
        /// and call the DoJob method (which is implemented in the subclass)
        /// </summary>
        /// <returns>True if there was enough honey to do the job, false otherwise</returns>
        public bool WorkTheNextShift()
        {
            if (HoneyVault.ConsumeHoney(CostPerShift))
            {
                DoJob();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// A method implemented by the subclass to do the job
        /// </summary>
        protected virtual void DoJob()
        {
            /* the subclass overrides this method */
        }
    }
}

