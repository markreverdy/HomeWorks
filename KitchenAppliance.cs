using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Ex6
{
    public class KitchenAppliance : ElectricalAppliance
    {
        public string Brand { get; private set; }

        public KitchenAppliance(string name, double power, string brand) : base(name, power)
        {
            Brand = brand;
        }

        public override string ToString()
        {
            return base.ToString() + $", Brand: {Brand}";
        }
    }
}
