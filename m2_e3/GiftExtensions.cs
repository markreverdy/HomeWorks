using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Ex3
{
    static class GiftExtensions
    {
        public static double CalculateTotalWeight(this Sweet[] gift)
        {
            double totalWeight = 0;
            foreach (Sweet sweet in gift)
            {
                totalWeight += sweet.Weight;
            }
            return totalWeight;
        }

        public static void SortByName(this Sweet[] gift)
        {
            Array.Sort(gift, (x, y) => string.Compare(x.Name, y.Name));
        }

        public static Sweet FindByFlavor(this Sweet[] gift, string flavor)
        {
            foreach (Sweet sweet in gift)
            {
                if (sweet is Candy candy && candy.Flavor.Equals(flavor, StringComparison.OrdinalIgnoreCase))
                {
                    return sweet;
                }
            }
            return null;
        }
    }
}
