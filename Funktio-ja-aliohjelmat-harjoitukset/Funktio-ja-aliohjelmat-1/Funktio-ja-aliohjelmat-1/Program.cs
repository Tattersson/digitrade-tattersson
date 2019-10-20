using System;

namespace Funktio_ja_aliohjelmat_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kuinka monta tähteä haluat tulostaa?");
            int tahdet = int.Parse(Console.ReadLine());
            if (tahdet < 1)
            {
                Console.WriteLine($"Numero {tahdet} lukua ei sallita.");
            }
            else
            {
                Console.WriteLine($"{tehtava(tahdet)}");
            }
        }
        static string tehtava(int luku)
        {
            string arvo = "";

            for (int tahdet = 0; tahdet < luku; tahdet++)
            {
                arvo += "*";
            }
            return arvo;
        }
    }
}
