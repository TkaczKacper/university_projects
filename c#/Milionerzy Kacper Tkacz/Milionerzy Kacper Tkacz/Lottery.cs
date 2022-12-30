using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milionerzy_Kacper_Tkacz
{
    class Lottery
    {
        public static Array QuestionNumber(int n, int k)
        {
            Random random = new Random();

            int[] numbers = new int[n];
            int i = 0;
            while (i < n)
            {
                int wylosowana = random.Next(0, k);
                if (!numbers.Contains(wylosowana))
                {
                    numbers[i] = wylosowana;
                    i++;
                }
            }
            return numbers;
        }
    }
}
