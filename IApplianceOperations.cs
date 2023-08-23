using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Ex6
{
    public interface IApplianceOperations
    {
        double CalculateTotalPowerConsumption(ElectricalAppliance[] appliances);
        void SortAppliancesByPower(ElectricalAppliance[] appliances);
        ElectricalAppliance[] FindAppliancesByPowerRange(ElectricalAppliance[] appliances, double minPower, double maxPower);
    }
}
