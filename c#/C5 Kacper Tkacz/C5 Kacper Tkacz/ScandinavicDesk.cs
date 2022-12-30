using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_Kacper_Tkacz
{
    class ScandinavicDesk : Desk
    {
        private string specific;

        public ScandinavicDesk() : base()
        {
            price = 300;
            color = "white";
            specific = "electric socket under table";
        }

        public override string ToString()
        {
            return base.ToString() + "This desk has " + specific;
        }
    }
}
