using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Ex6
{
    public class ElectricalAppliance
    {
        public string Name { get; private set; }
        public double Power { get; private set; } // in watts
        public bool IsPluggedIn { get; private set; }

        public ElectricalAppliance(string name, double power)
        {
            Name = name;
            Power = power;
            IsPluggedIn = false;
        }

        public void PlugIn()
        {
            IsPluggedIn = true;
        }

        public void UnPlug()
        {
            IsPluggedIn = false;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Power: {Power}W, Plugged In: {IsPluggedIn}";
        }
    }
}
