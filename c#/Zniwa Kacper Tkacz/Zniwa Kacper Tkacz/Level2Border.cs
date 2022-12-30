using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zniwa_Kacper_Tkacz
{
    class Level2Border
    {
        //current border coordinate holder 
        public Coordinate Level2BorderCoord { get; set; }

        //list of X and Y of walls in borders
        public List<int> Level2BorderXCoord = new List<int>();
        public List<int> Level2BorderYCoord = new List<int>();

        public Level2Border()
        {
            //first up
            for (int i = 1; i <= 55; i++)
            {
                var x = i;
                var y = 0;
                Level2BorderCoord = new Coordinate(x, y);
                DrawHorizontal();
                Level2BorderXCoord.Add(x);
                Level2BorderYCoord.Add(y);
            }
            //first down
            for (int i = 1; i <= 48; i++)
            {
                var x = i;
                var y = 3;
                Level2BorderCoord = new Coordinate(x, y);
                DrawHorizontal();
                Level2BorderXCoord.Add(x);
                Level2BorderYCoord.Add(y);
            }
            //first left
            for(int i = 4; i <= 17; i++)
            {
                var x = 48;
                var y = i;
                Level2BorderCoord = new Coordinate(x, y);
                DrawVertical();
                Level2BorderXCoord.Add(x);
                Level2BorderYCoord.Add(y);
            }
            //first right
            for (int i = 1; i <= 20; i++)
            {
                var x = 55;
                var y = i;
                Level2BorderCoord = new Coordinate(x, y);
                DrawVertical();
                Level2BorderXCoord.Add(x);
                Level2BorderYCoord.Add(y);
            }
            //second up
            for (int i = 33; i <= 48; i++)
            {
                var x = i;
                var y = 17;
                Level2BorderCoord = new Coordinate(x, y);
                DrawHorizontal();
                Level2BorderXCoord.Add(x);
                Level2BorderYCoord.Add(y);
            }
            //second down
            for (int i = 12; i <= 55; i++)
            {
                var x = i;
                var y = 20;
                Level2BorderCoord = new Coordinate(x, y);
                DrawHorizontal();
                Level2BorderXCoord.Add(x);
                Level2BorderYCoord.Add(y);
            }
            //second left
            for (int i = 14; i <= 19; i++)
            {
                var x = 26;
                var y = i;
                Level2BorderCoord = new Coordinate(x, y);
                DrawVertical();
                Level2BorderXCoord.Add(x);
                Level2BorderYCoord.Add(y);
            }
            //third up
            for (int i = 26; i <= 41; i++)
            {
                var x = i;
                var y = 14;
                Level2BorderCoord = new Coordinate(x, y);
                DrawHorizontal();
                Level2BorderXCoord.Add(x);
                Level2BorderYCoord.Add(y);
            }
            //third left
            for (int i = 6; i <= 13; i++)
            {
                var x = 41;
                var y = i;
                Level2BorderCoord = new Coordinate(x, y);
                DrawVertical();
                Level2BorderXCoord.Add(x);
                Level2BorderYCoord.Add(y);
            }
            //fourth down
            for (int i = 19; i <= 41; i++)
            {
                var x = i;
                var y = 6;
                Level2BorderCoord = new Coordinate(x, y);
                DrawHorizontal();
                Level2BorderXCoord.Add(x);
                Level2BorderYCoord.Add(y);
            }
            //fourth left
            for (int i = 4; i <= 19; i++)
            {
                var x = 12;
                var y = i;
                Level2BorderCoord = new Coordinate(x, y);
                DrawVertical();
                Level2BorderXCoord.Add(x);
                Level2BorderYCoord.Add(y);
            }
            //fourth right
            for (int i = 7; i <= 17; i++)
            {
                var x = 19;
                var y = i;
                Level2BorderCoord = new Coordinate(x, y);
                DrawVertical();
                Level2BorderXCoord.Add(x);
                Level2BorderYCoord.Add(y);
            }
        }

        void DrawHorizontal()
        {
            Console.SetCursorPosition(Level2BorderCoord.X, Level2BorderCoord.Y);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("═");
        }
        void DrawVertical()
        {
            Console.SetCursorPosition(Level2BorderCoord.X, Level2BorderCoord.Y);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("║");
        }
    }
}
