using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6_Kacper_Tkacz
{
    class Strategia3 : Strategy
    {
        private int liczenie = 0;
        public override bool GetNextMove(List<bool> knownMoves)
        {
            liczenie++;
            if (liczenie % 2 == 0) return false;
            else return true;
        }

        public override string ToString()
        {
            return "EveryOddTrue";
        }
    }
}
