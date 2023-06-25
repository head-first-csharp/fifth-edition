using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    abstract class Bee
    {
        /// <summary>
        /// The units of honey this bee consumes per shift
        /// </summary>
        public abstract decimal CostPerShift { get; }

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
        /// If there's enough honey for this bee to work the next shift, consume the honey
        /// </summary>
        /// <returns>True if there was enough honey to do the job, false otherwise</returns>
        public virtual bool WorkTheNextShift()
        {
            if (HoneyVault.ConsumeHoney(CostPerShift))
                return true;
            else
                return false;
        }
    }
}
