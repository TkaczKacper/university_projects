using System;
using System.Collections.Generic;
using System.Text;

namespace C6_Kacper_Tkacz
{
    public class StrategyAlwaysFalse : Strategy
    {
        // placeholder strategy - always betray (always return false)
        public override bool GetNextMove(List<bool> knownMoves)
        {
            return false;
        }
		
        public override string ToString()
        {
            return "StrategyAlwaysFalse";
        }

    }
}
