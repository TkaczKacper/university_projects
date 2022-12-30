using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_Kacper_Tkacz
{
    abstract class Designer
    {
        public abstract Desk DeskMaker(int priceLimit);
        public abstract Wardrobe WardrobeMaker(int priceLimit);
    }
}
