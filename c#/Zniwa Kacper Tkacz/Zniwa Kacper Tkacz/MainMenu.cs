using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zniwa_Kacper_Tkacz
{
    class MainMenu
    {
        public static void ShowMenu()
        { 
            while (true)
            {
                Console.SetWindowSize(100, 40);
                Console.CursorVisible = false;
                Console.Clear();
                MenuText();

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    //Menu option 1
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        Console.Clear();
                        Game.PlayGame();
                        Console.ReadKey();
                        ShowMenu();
                        break;
                    //Menu option 2
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        Console.Clear();
                        HowToPlay();
                        ShowMenu();
                        break;
                    //Menu option 3
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.Escape:
                    case ConsoleKey.D3:
                        Environment.Exit(0);
                        break;
                }                
            }
        }
        static void HowToPlay()
        {
            Console.WriteLine("Sterowanie w grze odbywa się za pomoca strzalek.");
            Thread.Sleep(1000);
            Console.WriteLine("Gra polega na zebraniu w jak najkrotszym czasie wszystkich zoltych pol.");
            Thread.Sleep(1700);
            Console.WriteLine("Kombajn ulega zniszczeniu w wysokosci 20% po spotkaniu sie ze sciana.");
            Thread.Sleep(1700);
            Console.WriteLine("Gdy sprawnosc spadnie do 0, przegrywasz i nic nie zarabiasz.");
            Thread.Sleep(1250);
            Console.WriteLine("Po zebraniu wszystkich plonow, nalezy zawiesc je do punktu skupu.");
            Thread.Sleep(1300);
            Console.WriteLine("Gdy podczas jazdy do punktu skupu uderzysz w sciane, przegrywasz.");
            Thread.Sleep(1200);
            Console.WriteLine("Punktem skupu jest czerwona kropka na srodku mapy.");
            Thread.Sleep(900);
            Console.WriteLine("Zaleznie od uplynietego czasu od rozpoczecia zlecenia otrzymasz odpowiednia ilosc $.");
            Thread.Sleep(2000);
            Console.WriteLine("Koniec instrukcji, zycze milej gry!");
            Thread.Sleep(2000);

            Console.WriteLine("");
            Console.WriteLine("Aby wrócić do głównego menu wciśnij dowolny klawisz.");
            Console.ReadKey();
        }

        static void MenuText()
        {
            Console.WriteLine("@@@@@@OOOOOOO@OOo`.*.     .,\\@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@[..............]]**..  .***`,..\\OoOOOO");
            Console.WriteLine("@@@@@@@@@@Ooo/\\OOOOOOOO`........    .\\@@@@@@@@@O@@@@@@@@@O[OOOOOo`..   ...........  .*[**[**/oooOOO");
            Console.WriteLine("OOOOO@@OOOOOOOOo[\\OO[[/[\\`*..........       ,[ ,\\OOOOO@@OOOOOO]...**...........         ..... .*..*");
            Console.WriteLine("OOOOOOOOOOOOOOOoo`/o\\`**.*.......*......      .    ,\\OOO/OOOo^..*********........  ./@@O`.    .....");
            Console.WriteLine("oo\\]***[oO^.....***,o[*******************.*....    ....*****[`********`.....]/O@@@@@@@@@@]O.       ");
            Console.WriteLine("oo/`*...............**...............................................]]/@@@@@@[[`    .,@@@@O`      ");
            Console.WriteLine("****...........................,]]]]]`.`......................]]/@@@@@[[`...`...         \\@@OO     ");
            Console.WriteLine(".....*..*.*....................=Oooo\\oOOOOOOooo/^.......//@@@@@/`.....                    =@@O@    ");
            Console.WriteLine("[[[[\\/[[[[[[`[[[\\OOOOOOO@OOO/[[O@OOOOOo@/\\*.,o/`.]`O@@@/[...........*..........           .@@@\\`   ");
            Console.WriteLine(". ..... ...........   . .]]]]]]/]]]],``.. ,`]@@O]^/OO[` ..  .        .....                 =@@O@`  ");
            Console.WriteLine("*]]]]`*..[[.........     =,O*.*=@O@@@@... .^/`  [.,]/O@O             .              .......=@@O``..");
            Console.WriteLine("    ..     ............ .  =O,=/@O@O@@`\\.. .      .  . ..                         .  .*[`.*]/*`.*..");
            Console.WriteLine("...................... . . .O^O/@@@O@O^`^...    .   ,/^ [[.                       ..........,\\..`*.");
            Console.WriteLine(".... ,]@\\]`.. . ............./@@@@@@@^\\`=]]`.....,O\\]`..             ......  ` .,.,]]]*..........`");
            Console.WriteLine(".....@@@O@@@/@\\O]`....,``.*.....@@@@@@@O..,\\O\\`.../O\\OO.....=*.............   ,^. ..............,.`");
            Console.WriteLine("......=O@@@@@OO\\@@@@OO/\\`...]O@@@@@@[O@@@O^,OOO@.]@@^*O/*[`,[\\`***[[*,,`.     ,..`.,*.]`**[[[[[[[[[");
            Console.WriteLine(".....,`\\[[OO/@\\@@@/\\@@@O]/[[O]/`]..,^O@@@@@/O/`@.[[[`.......  ,.******`.      ......`.......,,...,.");
            Console.WriteLine(".........[\\`.,O@O@\\OO@@OO@@OO\\O]`,[O/\\@@@@.^OO[`..........,./,*^*\\=,*.       ......................");
            Console.WriteLine("..............`O]@@@O@OO@OO@@OOOOOO/O`..,OO/.,.............`O.,/=`/.        .........`.`...,.`....,");
            Console.WriteLine("..............*.[*\\][OOO@@@OO]/O@@@O@@O@@O]\\`,[[O]]......*\\]\\@@@@/         .........`...`..,*.`...`");
            Console.WriteLine("....,..........**..``\\//[[OO@@@@@@@]/\\@@@\\OOO\\OO\\]`]O@@\\/O@@@@/          .........*`...*...,,.`.,,");
            Console.WriteLine("...`.`..`...=.[,`./o/\\`\\/[o/O@@O@O]OO@OOO\\@@@@O//@@@@O/,/@@@.,\\]             ......`.`....*.=..\\...");
            Console.WriteLine(".,.*.`]*.o`]`,^=]=////.,*,\\,^\\^OOOOO@@@@OOOO,*,@@@@OO.@@@@^*,@OOOOOOOO]             ...,.,.*..,.[.,");
            Console.WriteLine("O`,^],=^.`.=,]``.,[,\\=[`\\..,,[,[\\=/O@@@@@OOO\\O@\\OO@@/@@OO/*,@@OOOOOO@O@OO@@\\]`             `.=``\\.,");
            Console.WriteLine("`\\``./\\,``/.^^`=,.//=^==^[`,*.`*.\\[O=@o@OO@@@@@@@@@@@@@@/*=@@@O@OOOOOO@@@@@@@@@@@@]`              [");
            Console.WriteLine("/,,`=^`=/].,.\\**,/\\^^,`,./]`]^=,,=`*=,OO/@@@@@@@@@@@@@O/*=@@@@@@@OO@@@@O@@@@@@@@@@@@@@@@@]`        ");
            Console.WriteLine("`,.\\/,`,*.\\].].[/.`.``,/,]..,*...,.O`^`[\\/@@@@@@@@@@@O/\\/@@@@@@@@OOOOOO@@@@@@@@@@@@@@@@@@@@@@@@]]` ");
            Console.WriteLine("].`*.]^,`Oo^.[`^`.`.\\.````/,*`.,.\\`^.,o\\,O@@@@@@@@@O@@@@@@@@@@@OOOOOOO@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("^....`/,``*^//^^.=.`.\\=,.`,\\=``O./O\\/=\\*O@@@@@@@@@@@@@@@@@@@@@@@OOOOO@@@@@@@@@@@@@@@@@@@@@@@@O@@@@@");
            Console.WriteLine("]`.*,=o..[,^`.=...`.`,=.,^,^,`.\\`O^^^=@O@@@@@@@@@@@@@@@@@@@@@@@@OOOO@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine(".,^.,``\\`,..^,/\\]..\\^*..]^,.=,`,\\/O\\@@@@@@@@@@@@@@@@@@@@@@@@@@@@OOO@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");


            Console.WriteLine("");
            Console.WriteLine("                               1. Rozpocznij gre.");
            Console.WriteLine("                               2. Jak grac?");
            Console.WriteLine("                               3. Zamknij gre.");
        }
    }
}
