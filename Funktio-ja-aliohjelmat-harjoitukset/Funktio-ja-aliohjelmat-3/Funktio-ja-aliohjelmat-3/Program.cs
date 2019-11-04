using System;

namespace Funktio_ja_aliohjelmat_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int retNumber = numberFromRange(1, 100);
            Console.WriteLine($"Your input {retNumber} passed the test!!!");
        }
        static int numberFromRange(int lowerBound, int upperBound)
        {
            bool isNum = false;
            int inputNum = 0;

            do
            {
                Console.Write("Give a number between 100 and 1, then press enter: ");
                isNum = int.TryParse(Console.ReadLine(), out inputNum);
                if (inputNum >= lowerBound && inputNum <= upperBound)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error, Try again!!!  ");
                }
            }
            while (isNum == false && inputNum < lowerBound || inputNum > upperBound);
            return inputNum;
        }
    }
}