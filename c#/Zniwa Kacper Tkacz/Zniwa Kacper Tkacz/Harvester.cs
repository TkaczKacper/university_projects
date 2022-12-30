using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zniwa_Kacper_Tkacz
{
    class Harvester
    {
        //harvester generator
        public Harvester()
        {
            HarvesterCoordinate = new Coordinate(2, 2);
        }
        //current harvester position holder
        public Coordinate HarvesterCoordinate { get; set; }
        //current harvester direction holder
        public Direction Direction { get; set; } = Direction.Right;
        //harvester elements holder
        public List<Coordinate> HarvesterBack { get; set; } = new List<Coordinate>();

        Border border = new Border();
        public bool outOfRange = false;
        
        //main harvester function
        public void Move()
        {
            //movement
            switch (Direction)
            {
                case Direction.Left:
                    HarvesterCoordinate.X--;
                    break;
                case Direction.Right:
                    HarvesterCoordinate.X++;
                    break;
                case Direction.Up:
                    HarvesterCoordinate.Y--;
                    break;
                case Direction.Down:
                    HarvesterCoordinate.Y++;
                    break;
            }
            //console harvester visualization
            try
            {
                Console.SetCursorPosition(HarvesterCoordinate.X, HarvesterCoordinate.Y);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("╠");
                Console.ResetColor();
                
                HarvesterBack.Add(new Coordinate(HarvesterCoordinate.X, HarvesterCoordinate.Y));
                if(HarvesterBack.Count > 1)
                {
                    var endHarvester = HarvesterBack.First();
                    Console.SetCursorPosition(endHarvester.X, endHarvester.Y);
                    Console.Write(" ");
                    HarvesterBack.Remove(endHarvester);
                }
            }
            catch(ArgumentOutOfRangeException)
            {
                outOfRange = true;
            }
        }
        //harvester crash checker
        public bool HitBorder()
        {
            for(int i = 0; i < border.BorderXCoord.Count; i++)
            {
                if (border.BorderXCoord[i].Equals(HarvesterCoordinate.X) && border.BorderYCoord[i].Equals(HarvesterCoordinate.Y)) return true;  
            }
            return false;
        }
        public bool BorderHitted
        {
            get { return HitBorder(); }
        }
    }
}
