using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class Eggcare : Bee
    {
        public override float CostPerShift { get { return 1.35f; } }

        public Eggcare() : base("Opiekunka jaj") { }
    }
}
