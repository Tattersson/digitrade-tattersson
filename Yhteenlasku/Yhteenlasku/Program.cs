using System;

namespace Yhteenlasku
{
    class Program
    {
        static void Main()
        { 
            Console.WriteLine("Syötä numero mihin asti ohjelma laskee yhteen.");
            Console.Write("Anna luku: ");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int vastaus = 0;

            if (n >= 1)
            {
                while (i <= n)
                {
                    vastaus = (vastaus + n);
                    i++;
                }
                Console.WriteLine("Vastaus on: " + vastaus);
            }
            else
            {
                Console.WriteLine("Luku on liian pieni");
            }
        }
    }
}
