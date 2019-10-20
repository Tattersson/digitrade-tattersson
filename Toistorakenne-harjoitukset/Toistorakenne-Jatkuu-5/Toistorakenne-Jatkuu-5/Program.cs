using System;

namespace Toistorakenne_Jatkuu_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int i = 1; i < 14; i++)
            {
                double tulos = rnd.NextDouble();

                if (tulos <= 0.4)
                {
                    Console.WriteLine($"{i}. Kotivoitto");
                    Console.WriteLine("  ");
                }
                else if (tulos > 0.4 && tulos <= 0.6)
                {
                    Console.WriteLine($"{i}. Tasapeli");
                    Console.WriteLine("  ");
                }
                else
                {
                    Console.WriteLine($"{i}. Vierasvoitto");
                    Console.WriteLine("  ");
                }
            }
        }
    }
}
