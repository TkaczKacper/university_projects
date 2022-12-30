using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_Kacper_Tkacz
{
    class ModernDesk : Desk
    {
        private string specific;

        public ModernDesk() : base()
        {
            price = 400;
            color = "black/white";
            specific = "controlable LED panel.";
        }
        public override string ToString()
        {
            return base.ToString() + "This desk has additional " + specific;
        }
    }
}
