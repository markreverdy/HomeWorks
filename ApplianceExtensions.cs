﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Ex6
{
    public static class ApplianceExtensions
    {
        public static ElectricalAppliance[] FindByPowerRange(this ElectricalAppliance[] appliances, double minPower, double maxPower)
        {
            return appliances.Where(a => a.Power >= minPower && a.Power <= maxPower).ToArray();
        }
    }
}
