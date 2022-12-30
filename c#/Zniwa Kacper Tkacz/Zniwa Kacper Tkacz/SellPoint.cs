using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zniwa_Kacper_Tkacz
{
    class SellPoint
    {
        //sell point coordinate holder
        public Coordinate CurrentSellPoint { get; set; }

        //sell point generator
        public SellPoint()
        {
            var x = 30;
            var y = 9;
            CurrentSellPoint = new Coordinate(x, y);
            SellPointDraw();  
        }
        void SellPointDraw()
        {
            Console.SetCursorPosition(CurrentSellPoint.X, CurrentSellPoint.Y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("■");
        } 
    }
}
