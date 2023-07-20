using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Ex4
{
    public class Salad
    {
        public IVegetable[] Vegetables { get; set; }

        public Salad(IVegetable[] vegetables)
        {
            Vegetables = vegetables;
        }

        public double CalculateTotalCalories()
        {
            return Vegetables.Sum(v => v.CalculateTotalCalories());
        }
    }
    public static class SaladExtensions
    {
        public static IVegetable[] FindByCalories(this Salad salad, double minCalories, double maxCalories)
        {
            return salad.Vegetables.Where(v => v.CalculateTotalCalories() >= minCalories && v.CalculateTotalCalories() <= maxCalories).ToArray();
        }

        public static void SortByCalories(this Salad salad)
        {
            Array.Sort(salad.Vegetables, (v1, v2) => v1.CalculateTotalCalories().CompareTo(v2.CalculateTotalCalories()));
        }
    }
}
