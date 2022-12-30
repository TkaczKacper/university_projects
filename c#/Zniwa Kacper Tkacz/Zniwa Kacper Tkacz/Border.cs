using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zniwa_Kacper_Tkacz
{
    class Border
    {
        //current border position holder
        public Coordinate BorderCoord { get; set; }

        //Lists of X and Y coordinations
        public List<int> BorderXCoord = new List<int>();
        public List<int> BorderYCoord = new List<int>();

        public Border()
        {
            //border Up
            for (int i = 1; i <= 55; i++)
            {
                var x = i;
                var y = 0;
                BorderCoord = new Coordinate(x, y);
                DrawHorizontal();
                BorderXCoord.Add(x);
                BorderYCoord.Add(y);
            }
            //border Down
            for (int i = 1; i <= 55; i++)
            {
                var x = i;
                var y = 25;
                BorderCoord = new Coordinate(x, y);
                DrawHorizontal();
                BorderXCoord.Add(x);
                BorderYCoord.Add(y);
            }
            //border Right
            for (int i = 1; i <= 25; i++)
            {
                var x = 55;
                var y = i;
                BorderCoord = new Coordinate(x, y);
                DrawVertical();
                BorderXCoord.Add(x);
                BorderYCoord.Add(y);
            }
            //border Left
            for (int i = 1; i <= 25; i++)
            {
                var x = 1;
                var y = i;
                BorderCoord = new Coordinate(x, y);
                DrawVertical();
                BorderXCoord.Add(x);
                BorderYCoord.Add(y);
            }
        }

        void DrawHorizontal()
        {
            Console.SetCursorPosition(BorderCoord.X, BorderCoord.Y);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("═");
        }

        void DrawVertical()
        {
            Console.SetCursorPosition(BorderCoord.X, BorderCoord.Y);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("║");
        }
    }
}
