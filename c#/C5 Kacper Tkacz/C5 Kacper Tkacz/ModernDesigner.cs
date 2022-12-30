using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_Kacper_Tkacz
{
    class ModernDesigner : Designer
    {
        ModernDesk modernDesk = new ModernDesk();
        Medium mediumWardrobe = new Medium();

        public override Desk DeskMaker(int priceLimit)
        {
            if (modernDesk.price <= priceLimit)
            {
                return new ModernDesk();
            }
            else return null;
        }

        public override Wardrobe WardrobeMaker(int priceLimit)
        {
            int wardrobeLimit = modernDesk.price + mediumWardrobe.price;
            if (wardrobeLimit <= priceLimit)
            {
                return new Medium();
            }
            else return null;
        }
    }
}
