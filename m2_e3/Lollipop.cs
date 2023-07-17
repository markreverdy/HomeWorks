using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Ex3
{
    class Lollipop : Sweet
    {
        public string Color { get; }

        public Lollipop(string name, double weight, string color) : base(name, weight)
        {
            Color = color;
        }

        public override void Display()
        {
            Console.WriteLine($"Lollipop: {Name}, Weight: {Weight}g, Color: {Color}");
        }
    }
}
