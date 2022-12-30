using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zniwa_Kacper_Tkacz
{
    class Tractor
    {
        //tractor generator
        public Tractor()
        {
            TractorCoordinate = new Coordinate(2, 2);
        }
        //current tractor position holder
        public Coordinate TractorCoordinate { get; set; }

        //current moving direction holder
        public Direction Direction { get; set; } = Direction.Right;

        //list of elements of tractor
        public List<Coordinate> TractorBack { get; set; } = new List<Coordinate>();
        Level2Border level2Border = new Level2Border();
        public bool outOfRange = false;
        
        //main tractor function
        public void Move()
        {
            //movement
            switch (Direction)
            {
                case Direction.Left:
                    TractorCoordinate.X--;
                    break;
                case Direction.Right:
                    TractorCoordinate.X++;
                    break;
                case Direction.Up:
                    TractorCoordinate.Y--;
                    break;
                case Direction.Down:
                    TractorCoordinate.Y++;
                    break;
            }
            //console tractor visualization
            try
            {
                Console.SetCursorPosition(TractorCoordinate.X, TractorCoordinate.Y);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("█");
                Console.ResetColor();

                TractorBack.Add(new Coordinate(TractorCoordinate.X, TractorCoordinate.Y));
                if (TractorBack.Count > 3)
                {
                    var endTractor = TractorBack.First();
                    Console.SetCursorPosition(endTractor.X, endTractor.Y);
                    Console.Write(" ");
                    TractorBack.Remove(endTractor);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                outOfRange = true;
            }
        }
        //tractor crash into border checker
        public bool Level2HitBorder()
        {
            for (int i = 0; i < level2Border.Level2BorderXCoord.Count; i++)
            {
                if (level2Border.Level2BorderXCoord[i].Equals(TractorCoordinate.X) && level2Border.Level2BorderYCoord[i].Equals(TractorCoordinate.Y))
                {
                    return true;
                }
            }
            return false;
        }
        public bool Level2BorderHitted
        {
            get { return Level2HitBorder(); }
        }
    }
}
