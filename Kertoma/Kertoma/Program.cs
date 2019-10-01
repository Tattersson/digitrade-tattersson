using System;

namespace Kertoma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int i = 1;
            int vastaus = 1;

            Console.WriteLine("Syötä numero mihin asti haluat että ohjelma kertoo.");
            Console.Write("Anna Numero: ");
            n = int.Parse(Console.ReadLine());

            
            if (n >= 1)
            {
                
                while (i <= n)
                {
                    vastaus = (vastaus * i);
                    i++;

                }
                Console.WriteLine("Vastaus on: " + vastaus);
            } 
            else
            {
                Console.WriteLine("Liian pieni luku.");
            }


        }

    }
}


