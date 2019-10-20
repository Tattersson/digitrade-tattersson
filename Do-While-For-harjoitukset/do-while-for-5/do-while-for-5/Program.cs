using System;

namespace do_while_for_5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Do-While-For-5 : Tehtävä");
            Console.WriteLine("Anna luku. Ohjelma laskee parittomien summan ja parillisten summan");
            int i = int.Parse(Console.ReadLine());

            int n = 0;
            int EvenSum = 0;
            int OddSum = 0;

            if (i > 0)
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
            }
            else
            {
                while (n >= i)
                {
                    if (n % 2 == 0)
                    {
                        EvenSum = EvenSum + n;
                    }
                    else
                    {
                        OddSum = OddSum + n;
                    }
                    n--;
                }
            }
            Console.WriteLine($"Parillisten Summa on: {EvenSum}");
            Console.WriteLine($"Parittomien Summa on: {OddSum}");
            Console.WriteLine("");
            Console.WriteLine("Kiitos ja hyvää päivänjatkoa");
        }
    }
}
