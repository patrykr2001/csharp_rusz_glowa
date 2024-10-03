using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class NectarCollector : Bee
    {
        private readonly static float NECTAR_COLLECTED_PER_SHIFT = 33.25f;

        public override float CostPerShift { get { return 1.95f;  } }

        public NectarCollector() : base("Zbieraczka nektaru") { }
        public NectarCollector(string job) : base(job) { }

        protected override void DoJob()
        {
            HoneyVault.CollectNectar(NECTAR_COLLECTED_PER_SHIFT);
        }
    }
}
