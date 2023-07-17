using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Ex3
{
    class Chocolate : Sweet
    {
        public string Brand { get; }

        public Chocolate(string name, double weight, string brand) : base(name, weight)
        {
            Brand = brand;
        }

        public override void Display()
        {
            Console.WriteLine($"Chocolate: {Name}, Weight: {Weight}g, Brand: {Brand}");
        }
    }
}
