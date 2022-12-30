using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zniwa_Kacper_Tkacz
{
    class Wheat
    {
        //list of wheat X and Y coordinates 
        public List<int> WheatXCoord = new List<int>();
        public List<int> WheatYCoord = new List<int>();
        
        //current wheat position holder
        public Coordinate CurrentWheat { get; set; }

        //wheat generator
        public Wheat()
        {
            for (int i = 3; i < 20; i++)
            {
                Random random = new Random();
                var x = 2 * i;
                var y = random.Next(1, 25);
                CurrentWheat = new Coordinate(x, y);
                Draw();
                WheatXCoord.Add(x);
                WheatYCoord.Add(y);
            }
        }
        void Draw()
        {
            Console.SetCursorPosition(CurrentWheat.X, CurrentWheat.Y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("■");
        }
    }
}
