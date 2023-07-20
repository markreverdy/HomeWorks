using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Ex4
{
    public abstract class Vegetable : IVegetable
    {
        public string Name { get; set; }
        public double Calories { get; set; }
        public double Weight { get; set; }

        public double CalculateTotalCalories()
        {
            return (Calories * Weight) / 100;
        }
    }
}
