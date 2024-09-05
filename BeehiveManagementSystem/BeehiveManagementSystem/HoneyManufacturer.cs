using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class HoneyManufacturer : Bee
    {
        public override float CostPerShift { get { return 1.7f; } }

        public HoneyManufacturer() : base("Producentka miodu") { }
    }
}
