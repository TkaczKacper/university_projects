using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_Kacper_Tkacz
{
    class Small : Wardrobe
    {
        private string doors;

        public Small() : base()
        {
            price = 100;
            color = "brown";
            doors = "one door.";
        }

        public override string ToString()
        {
            return base.ToString() + "This wardrobe has " + doors;
        }
    }
}
