using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milionerzy_Kacper_Tkacz
{
    class EndingScreen : Wallet
    {
        public static void BestEnding()
        {
            Console.Clear();

            Console.WriteLine($" Gratulacje udalo Ci sie wygrac glowna nagrode w wysokosci ${CurrentWin} " +
                "\n A to oznacza ze masz bardzo duza wiedze. " +
                "\n\n Pamietaj, ze wciaz mozesz zagrac ponownie aby zwiekszysc swoje punkty w rankingu B) " +
                "\n\n\n Wcisnij dowolny klawisz aby wrocic do menu...");
        }
        public static void Ending()
        {
            Console.Clear();

            Console.WriteLine(" Nie udalo Ci sie wygrac glownej nagrody, ale na szczescie nie wychodzisz bez niczego." +
                $"\n Dzieki tej grze udalo Ci sie zarobic ${CurrentWin} " +
                "\n Dodalismy rowniez zdobyte punkty do rankingu, jednak nie zobaczysz ich dopoki nie bedziesz w top 3 graczy." +
                "\n Takze zyczymy powodzenia we wbijaniu rankingu. " +
                "\n\n\n Wcisnij dowolny klawisz aby wrocic do menu...");
        }
        public static void TimesUpEnding()
        {
            Console.Clear();
            Console.WriteLine(" Niestety skonczyl Ci sie czas, wiec nie mozemy uznac tego pytania. \n");

            if (CurrentWin == 0) Console.WriteLine(" Poniewaz nie uzyskales pulapu gwarantowanej nagrody, nie udalo Ci sie nic wygrac. " +
                                                            "\n Jednak wciaz mozesz zagrac ponownie.");
            else Console.WriteLine($" Jednak udalo Ci sie wygrac ${CurrentWin}");

            Console.WriteLine("\n\n\n Wcisnij dowolny klawisz, aby wrocic do menu.");
            Console.ReadKey();
        }
    }
}
