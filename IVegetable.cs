using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Ex4
{
    public interface IVegetable
    {
        string Name { get; set; }
        double Calories { get; set; }
        double Weight { get; set; }

        double CalculateTotalCalories();
    }
}
