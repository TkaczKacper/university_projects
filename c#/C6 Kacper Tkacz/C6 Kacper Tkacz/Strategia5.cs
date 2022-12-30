using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6_Kacper_Tkacz
{
    class Strategia5 : Strategy
    {
        private int licznik = 15;
        public override bool GetNextMove(List<bool> knownMoves)
        {
            licznik--;
            if (licznik > 0) return true;
            else return false;
        }

        public override string ToString()
        {
            return "FirstHalfTrueThanFalse";
        }
    }
}
