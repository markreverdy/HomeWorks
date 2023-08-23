using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Ex6
{
    public class EntertainmentAppliance : ElectricalAppliance
    {
        public int Volume { get; private set; } // volume level

        public EntertainmentAppliance(string name, double power, int volume) : base(name, power)
        {
            Volume = volume;
        }

        public void IncreaseVolume()
        {
            Volume++;
        }

        public void DecreaseVolume()
        {
            Volume--;
        }

        public override string ToString()
        {
            return base.ToString() + $", Volume: {Volume}";
        }
    }
}
