using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_Kacper_Tkacz
{
    class ClasicalDesigner : Designer
    {
        ClasicDesk clasicDesk = new ClasicDesk();
        Small smallWardrobe = new Small();

        public override Desk DeskMaker(int priceLimit)
        {
            if (clasicDesk.price <= priceLimit)
            {
                return new ClasicDesk();
            }
            else return null;
        }
        public override Wardrobe WardrobeMaker(int priceLimit)
        {
            int wardrobeLimit = clasicDesk.price + smallWardrobe.price;
            if (wardrobeLimit < priceLimit)
            {
                return new Small();
            }
            else return null;
        }
    }
}
