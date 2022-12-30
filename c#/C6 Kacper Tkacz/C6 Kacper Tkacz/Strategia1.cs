using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6_Kacper_Tkacz
{
    public class Strategia1 : Strategy
    {
        private int liczenie = 0;
        public override bool GetNextMove(List<bool> knownMoves)
        {
            liczenie++;
            if (liczenie % 2 == 0) return true;
            else return false;
        }

        public override string ToString()
        {
            return "EveryEvenTrue";
        }
    }
}
