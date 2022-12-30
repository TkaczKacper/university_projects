using System;
using System.Collections.Generic;

namespace C5_Kacper_Tkacz
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasicalDesigner clasical = new ClasicalDesigner();
            ModernDesigner modern = new ModernDesigner();
            ScandinavicDesigner scandinavic = new ScandinavicDesigner();

            //first price checker
            int priceFirst = 450;
            Console.WriteLine("Things with price limit $" + priceFirst);
            Console.WriteLine("Clasical\n" + clasical.DeskMaker(priceFirst));
            Console.WriteLine(clasical.WardrobeMaker(priceFirst));
            Console.WriteLine("Modern\n"+modern.DeskMaker(priceFirst));
            Console.WriteLine(modern.WardrobeMaker(priceFirst));
            Console.WriteLine("Scandinavic\n"+scandinavic.DeskMaker(priceFirst));
            Console.WriteLine(scandinavic.WardrobeMaker(priceFirst)+"\n\n");

            //second price checker
            int priceSecond = 550;
            Console.WriteLine("Things with price limit $" + priceSecond);
            Console.WriteLine("Clasical\n" + clasical.DeskMaker(priceSecond));
            Console.WriteLine(clasical.WardrobeMaker(priceSecond));
            Console.WriteLine("Modern\n" + modern.DeskMaker(priceSecond));
            Console.WriteLine(modern.WardrobeMaker(priceSecond));
            Console.WriteLine("Scandinavic\n" + scandinavic.DeskMaker(priceSecond));
            Console.WriteLine(scandinavic.WardrobeMaker(priceSecond)+"\n\n");

            //third price checker
            int priceThird = 1000;
            Console.WriteLine("Things with price limit $" + priceThird);
            Console.WriteLine("Clasical\n" + clasical.DeskMaker(priceThird));
            Console.WriteLine(clasical.WardrobeMaker(priceThird));
            Console.WriteLine("Modern\n" + modern.DeskMaker(priceThird));
            Console.WriteLine(modern.WardrobeMaker(priceThird));
            Console.WriteLine("Scandinavic\n" + scandinavic.DeskMaker(priceThird));
            Console.WriteLine(scandinavic.WardrobeMaker(priceThird));
        }
    }
}
