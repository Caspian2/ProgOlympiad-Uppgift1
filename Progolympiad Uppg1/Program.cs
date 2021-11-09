using System;

namespace Progolympiad_Uppg1
{
    class Program
    {
        static void Main(string[] args)
        {
            double kuvertMängd;
            double affischMängd;
            double bladMängd;

            Console.WriteLine("Skriv tre tal mellan 50 - 200");

            while(true)
            {

                kuvertMängd = int.Parse(Console.ReadLine());

                if(kuvertMängd >= 50 && kuvertMängd <= 200)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Det va inget tal mellan 50-200");
                }
            }
            while(true)
            {

                affischMängd = int.Parse(Console.ReadLine());

                if(affischMängd >= 50 && affischMängd <= 200)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Det va inget tal mellan 50-200");
                }
            }
            while(true)
            {

                bladMängd = int.Parse(Console.ReadLine());

                if(bladMängd >= 50 && bladMängd <= 200)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Det va inget tal mellan 50-200");
                }
            }

            double kuvertVikt = kuvertMängd * (2 * 229 * 324) / 1000000;
            double affischVikt = affischMängd * (2 * 297 * 420) / 1000000;
            double bladVikt = bladMängd * (210 * 297) / 1000000;

            Console.WriteLine(kuvertVikt + affischVikt + bladVikt);
        }
    }
}
