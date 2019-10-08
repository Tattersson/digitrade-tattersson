using System;

namespace do_while_for_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Do-While-For 3 : Tehtävä");
            Console.WriteLine("Ohjelma laskee parittomien summan ja parillisten summan");
            Console.WriteLine("Anna luku: ");
            int i = int.Parse(Console.ReadLine());

            int n = 1;
            int OddSum = 0;
            int EvenSum = 0;

            if (i >= 1)
            {
                while (n <= i)
                {
                    if (n % 2 == 0)
                    {
                        EvenSum = EvenSum + n;
                    }
                    else
                    {
                        OddSum = OddSum + n;
                    }
                    n++;
                }
                Console.WriteLine($"Parittomien summa = {OddSum}");
                Console.WriteLine($"Parillisten summa = {EvenSum}");
                }

            else { Console.WriteLine("Luku on liian pieni"); }

            }
        }
    }

