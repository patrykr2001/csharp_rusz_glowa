using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class HiveDefender : Bee, IDefender
    {
        public override float CostPerShift { get
            {
                return 1.0f;
            } }

        public HiveDefender() : base("Obrońca roju") { }

        protected override void DoJob()
        {
            throw new NotImplementedException();
        }

        public void DefendHive()
        {

        }
    }
}
