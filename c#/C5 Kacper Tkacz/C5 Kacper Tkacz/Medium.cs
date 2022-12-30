using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_Kacper_Tkacz
{
    class Medium : Wardrobe
    {
        private bool additionalFeature;
        public Medium() : base()
        {
            price = 200;
            color = "black";
            additionalFeature = true;
        }
        public override string ToString()
        {
            if (additionalFeature == true)
            {
                return base.ToString() + "You choosed glass doors for aditional $50.";
            }
            else return null;
        }
    }
}
