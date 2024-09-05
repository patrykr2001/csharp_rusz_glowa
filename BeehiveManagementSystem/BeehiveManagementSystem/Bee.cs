using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class Bee
    {
        public virtual float CostPerShift { get; }

        public string Job { get; private set; }

        public Bee(string job)
        {
            Job = job;
        }

        public void WorkNextShift()
        {
            bool canWork = HoneyVault.ConsumeHoney(CostPerShift);
            if (canWork)
            {
                DoJob();
            }
        }

        protected virtual void DoJob() { }
    }
}
