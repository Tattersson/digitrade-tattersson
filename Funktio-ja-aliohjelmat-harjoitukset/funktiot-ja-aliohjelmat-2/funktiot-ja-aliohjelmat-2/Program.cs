using System;

namespace funktiot_ja_aliohjelmat_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kaksi lukua. Ohjelma tulostaa pienemmän!");
            Console.Write("Luku 1: ");
            int luku1 = int.Parse(Console.ReadLine());
            Console.Write("Luku 2: ");
            int luku2 = int.Parse(Console.ReadLine());

            Console.WriteLine(pieni(luku1, luku2));
        }
        static string pieni(int luku1, int luku2)
        {
            string lause = "";
            if (luku1 < luku2)
            {
                Console.WriteLine($"Luku {luku1} on pienempi kuin {luku2}.");
            }
            else
            {
                Console.WriteLine($"Luku {luku2} on pienempi kuin {luku1}.");
            }
            return lause;
        }
    }

}
