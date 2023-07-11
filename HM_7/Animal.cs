using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_7
{
    public class Animal
    {
        private string name;

        public Animal(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }
}
