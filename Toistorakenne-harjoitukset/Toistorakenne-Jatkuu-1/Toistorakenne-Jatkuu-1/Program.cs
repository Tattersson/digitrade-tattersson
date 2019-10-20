using System;

namespace Toistorakenne_Jatkuu_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Luku     |    Neliöjuuri");
            double i = 0;

            while (i <= 10)
            {
                double nelio = Math.Sqrt(i);
                Console.WriteLine($"{i}        |     {nelio}");
                i++;
            }
            return;
        }
    }
}
