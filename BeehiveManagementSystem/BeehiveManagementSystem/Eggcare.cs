using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class Eggcare : Bee
    {
        private readonly static float CARE_PROGRESS_PER_SHIFT = 0.15f;
        private readonly Queen _queen;

        public override float CostPerShift { get { return 1.35f; } }

        public Eggcare(Queen queen) : base("Opiekunka jaj") 
        { 
            _queen = queen;
        }

        protected override void DoJob()
        {
            _queen.CareForEggs(CARE_PROGRESS_PER_SHIFT);
        }
    }
}
