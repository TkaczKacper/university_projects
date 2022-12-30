using System;
using System.Collections.Generic;
using System.Text;

namespace C6_Kacper_Tkacz
{
    public abstract class Strategy
    {
        public int TotalPoints { get; set; } // you can use this property to remember points
		
        public abstract bool GetNextMove(List<bool> knownMoves); // use this method to return your next move in game
    }
}
