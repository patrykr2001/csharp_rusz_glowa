﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal class NectarDefender : NectarCollector, IDefender
    {
        public NectarDefender() : base("Obrońca nectaru") { }

        public void DefendHive()
        {

        }
    }
}
