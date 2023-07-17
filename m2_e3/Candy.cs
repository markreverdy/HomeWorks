using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Ex3
{
    class Candy : Sweet
    {
        public string Flavor { get; }

        public Candy(string name, double weight, string flavor) : base(name, weight)
        {
            Flavor = flavor;
        }

        public override void Display()
        {
            Console.WriteLine($"Candy: {Name}, Weight: {Weight}g, Flavor: {Flavor}");
        }
    }
}
