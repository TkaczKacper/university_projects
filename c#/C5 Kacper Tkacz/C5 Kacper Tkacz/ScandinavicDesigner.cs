using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_Kacper_Tkacz
{
    class ScandinavicDesigner : Designer
    {
        ScandinavicDesk scandinavicDesk = new ScandinavicDesk();
        Large largeWardrobe = new Large();

        public override Desk DeskMaker(int priceLimit)
        {
            if (scandinavicDesk.price <= priceLimit)
            {
                return new ScandinavicDesk();
            }
            else return null;
        }

        public override Wardrobe WardrobeMaker(int priceLimit)
        {
            int wardrobeLimit = scandinavicDesk.price + largeWardrobe.price;
            if (wardrobeLimit <= priceLimit)
            {
                return new Large();
            }
            else return null;
        }
    }
}
