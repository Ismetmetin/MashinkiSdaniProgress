using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mashinki
{
    public class Coin
    {
        public string Name { get; set; }
        public double Markliplier { get; set; }

        //snimka
        public Coin(string name, double markliplier)
        {
            Name = name;
            Markliplier = markliplier;
        }

        public override string ToString()
        {
            return $"{Name} ";
        }
    }
}
