using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_Kacper_Tkacz
{
    class ClasicDesk : Desk
    {
        private string specific;

        public ClasicDesk(): base()
        {
            price = 499;
            color = "brown";
            specific = "mahogany wood.";
        }

        public override string ToString()
        {
            return base.ToString() + " Made using " + specific;
        }
    }
}
