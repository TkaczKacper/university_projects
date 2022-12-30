using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_Kacper_Tkacz
{
    class Large : Wardrobe
    {
        private string specific;

        public Large() : base()
        {
            price = 500;
            color = "white";
            specific = "sliding doors and light inside";
        }
        public override string ToString()
        {
            return base.ToString() + "In this wardrobe we adding " + specific + " for no additional fee.";
        }
    }
}
