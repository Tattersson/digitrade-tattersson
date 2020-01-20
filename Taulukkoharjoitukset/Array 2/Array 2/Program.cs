using System;

namespace Array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lotto = new int[40];
            intro();
            rndLotteryN(ref lotto, 7, 1);
            rndLotteryN(ref lotto, 2, 1);
            printLottery(lotto);
        }


        static void intro()
        {
            string name;
            Console.WriteLine("Lottery program");
            Console.Write("\nLet's start with your name: ");
            name = Console.ReadLine();
            Console.WriteLine($"\nWelcome {name}");
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }

        static void rndLotteryN(ref int[] mainLotto, int count, int value)
        {
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                int rndNumb = rnd.Next(mainLotto.Length);
                if (mainLotto[rndNumb] == 0)
                {
                    mainLotto[rndNumb] = value;
                }
                else
                    i--;
            }

        }
        static void printLottery(int[] mainLotto)
        {
            Random rnd = new Random();
            Console.WriteLine($"\nTodays lottery numbers are: ");
            for (int i = 0; i < mainLotto.Length; i++)
            {
                if (mainLotto[i] == 1)
                {
                    Console.Write($": {i + 1}  ");
                }

            }
            Console.WriteLine("\nAnd for the extra numbers!");

            for (int i = 0; i < mainLotto.Length; i++)
                if (mainLotto[i] == 2)
                {
                    Console.WriteLine($"{i} ");
                }
            Console.WriteLine($"\nTodays double number is: {rnd.Next(mainLotto.Length)}");
        }
    }

}
