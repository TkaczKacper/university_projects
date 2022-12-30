using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_Kacper_Tkacz
{
    abstract class Desk
    {
        public int price;
        public string color;

        public Desk()
        {
            price = 0;
            color = "";
        }
        public override string ToString()
        {
            return "This desk costs $" + price + " and has " + color + " color.";
        }
    }
}
