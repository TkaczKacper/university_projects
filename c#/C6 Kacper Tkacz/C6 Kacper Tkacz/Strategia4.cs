using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6_Kacper_Tkacz
{
    class Strategia4 : Strategy
    {
        private Player player = new Player();

        public override bool GetNextMove(List<bool> knownMoves)
        {
            if (player.PartnerMoves.Contains(true)) return true;
            else return false;
        }

        public override string ToString()
        {
            return "TrueIfEnemyTrue";
        }
    }
}
