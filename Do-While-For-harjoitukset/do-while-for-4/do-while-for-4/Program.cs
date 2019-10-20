using System;

namespace do_while_for_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("do-while-for-4 - Tehtävä");
            Console.WriteLine("Anna luku jota lisätään tai vähennetään");
            Console.WriteLine("Luku : ");
            int i = int.Parse(Console.ReadLine());

            int n = 0;
            int v = 0;

            if (i > 0)
            {
                while (n <= i)
                {
                    v = (v + n);
                    n++;
                }
                Console.WriteLine($"Vastaus on: {v}");
            }
            else
            {
               if (i < 0)
                {
                    while (n >= i)
                    {
                        v = (v + n);
                        n--;
                    }
                    Console.WriteLine($"Vastaus on: {v}");

                }
            }
        }
        
       
    }
}
