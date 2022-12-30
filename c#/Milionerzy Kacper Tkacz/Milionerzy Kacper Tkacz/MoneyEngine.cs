using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milionerzy_Kacper_Tkacz
{
    class MoneyEngine : Wallet
    {
        public static void EngineMoney()
        {
            switch (QuizGame.CorrectAnswers)
            {
                case 0:
                    CurrentWin = 0;
                    PossibleWin = 500;
                    break;
                case 1:
                    CurrentWin = 0;
                    PossibleWin = 1000;
                    break;
                case 2:
                    CurrentWin = 1000;
                    PossibleWin = 2000;
                    break;
                case 3:
                    CurrentWin = 1000;
                    PossibleWin = 5000;
                    break;
                case 4:
                    CurrentWin = 1000;
                    PossibleWin = 10000;
                    break;
                case 5:
                    CurrentWin = 1000;
                    PossibleWin = 40000;
                    break;
                case 6:
                    CurrentWin = 40000;
                    PossibleWin = 75000;
                    break;
                case 7:
                    CurrentWin = 40000;
                    PossibleWin = 250000;
                    break;
                case 8:
                    CurrentWin = 40000;
                    PossibleWin = 500000;
                    break;
                case 9:
                    CurrentWin = 40000;
                    PossibleWin = 1000000;
                    break;
                case 10:
                    CurrentWin = 1000000;
                    break;
            }  
        }


    }
}
