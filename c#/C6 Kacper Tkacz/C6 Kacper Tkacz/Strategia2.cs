using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6_Kacper_Tkacz
{
    class Strategia2 : Strategy
    {
        private Random random;

        public override bool GetNextMove(List<bool> knownMoves)
        {
            random = new Random();
            int liczba = random.Next(0, 9);
            if (liczba % 2 == 0) return false;
            else return true;
        }

        public override string ToString()
        {
            return "RandomPlayer";
        }
    }
}
