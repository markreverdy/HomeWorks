using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Ex3
{
    abstract class Sweet
    {
        public string Name { get; }
        public double Weight { get; }

        protected Sweet(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public abstract void Display();

    }
}
