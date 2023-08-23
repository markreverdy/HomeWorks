using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Ex6
{
    public class ApplianceOperations : IApplianceOperations
    {
        public double CalculateTotalPowerConsumption(ElectricalAppliance[] appliances)
        {
            return appliances.Where(a => a.IsPluggedIn).Sum(a => a.Power);
        }

        public void SortAppliancesByPower(ElectricalAppliance[] appliances)
        {
            Array.Sort(appliances, (a, b) => a.Power.CompareTo(b.Power));
        }

        public ElectricalAppliance[] FindAppliancesByPowerRange(ElectricalAppliance[] appliances, double minPower, double maxPower)
        {
            return appliances.Where(a => a.Power >= minPower && a.Power <= maxPower).ToArray();
        }
    }
}
