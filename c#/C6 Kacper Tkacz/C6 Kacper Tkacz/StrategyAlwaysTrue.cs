using System;
using System.Collections.Generic;
using System.Text;

namespace C6_Kacper_Tkacz
{
    public class StrategyAlwaysTrue : Strategy
    {
        // placeholder strategy - always cooperate (always return true)
        public override bool GetNextMove(List<bool> knownMoves)
        {
            return true;
        }
		
        public override string ToString()
        {
            return "StrategyAlwaysTrue";
        }

    }
}
