using System;

namespace Toistorakenne_Jatkuu_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int n;
            int i = 0;

            int kruuna = 0, klaava = 0;

            Console.WriteLine("Toistorakenne Jatkuu 4");
            Console.WriteLine("  ");
            Console.WriteLine("Ohjelma heittää kolikkoa");
            Console.Write("Kuinka monta heittoa halua? ");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                int tulos = rnd.Next(2);
                if (tulos == 1)
                {
                    klaava++;
                }
                else if (tulos == 0)
                {
                    kruuna++;
                }
            }
            Console.WriteLine("Kolikkoa on heitetty " + n + " kertaa.");
            Console.WriteLine("Klaavoja heitettiin: " + klaava );
            Console.WriteLine("Kruunoja heitettiin: " + kruuna );
            return; 
        }
    }
}
