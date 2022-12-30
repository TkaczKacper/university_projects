using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_Kacper_Tkacz
{
    abstract class Wardrobe
    {
        public int price;
        public string color;

        public Wardrobe()
        {
            price = 0;
            color = "";
        }

        public override string ToString()
        {
            return "This wardrobe costs $" + price + " and has " + color + " color.";
        }
    }
}
