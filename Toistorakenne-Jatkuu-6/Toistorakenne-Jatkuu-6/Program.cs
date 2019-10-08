using System;

namespace Toistorakenne_Jatkuu_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("Toistorakenne-Jatkuu-6 | Tehtävä");
            int kuusi = 0;

            for (int n = 0; n <= 1000; n++)
            {
                int tulos = rnd.Next(6);


                Console.WriteLine($"{n}. {tulos+1}");
                if (tulos + 1 == 6)
                {
                    kuusi++;
                }
              
            }
            Console.WriteLine("");
            Console.WriteLine($"Numero kuusi arvottiin {kuusi} kertaa.");
            return;
           
        }
    }
}
