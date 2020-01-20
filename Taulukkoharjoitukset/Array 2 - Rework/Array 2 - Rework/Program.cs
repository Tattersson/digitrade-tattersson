using System;

namespace Array_2___Rework
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lotto = new int[40];
            intro();
            summonrnd(ref lotto, 7, 1);
            summonrnd(ref lotto, 1, 2);
            summonrnd(ref lotto, 1, 3);
            print(lotto);
        }
        static void intro()
        {
            Console.WriteLine("Hello.");
            Console.WriteLine("Welcome to Lottery!\n\nToday we will summon 7 numbers between 1 - 40.\nAre you ready?");
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        } 
        static void summonrnd(ref int[] lotto, int count, int value)
        {
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                int random = rnd.Next(lotto.Length);
                if (lotto[random] == 0)
                {
                    lotto[random] = value;
                }
                else
                {
                    i--; //arpoo taulukosta uuden luvun
                }
            }
        }
        static void print(int[] lotto)
        {
            Random rnd = new Random();
            for (int i = 0; i < lotto.Length; i++)
            {
                if (lotto[i] == 1)
                {
                    Console.Write($" : {i + 1}");
                }
                else
                {
                    continue;
                }
            }
            for (int i = 0; i < lotto.Length; i++)
            {
                if(lotto[i] == 2)
                {
                    Console.WriteLine($"\nLisänumero: {i}");
                }
                else
                {
                    continue;
                }
            }
            for (int i = 0; i < lotto.Length; i++)
            {
                if(lotto[i] == 3)
                {
                    Console.WriteLine($"Tuplausnumero: {i}");
                }
                else
                {
                    continue;
                }
            }
           

        }

    }
}
