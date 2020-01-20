using System;

namespace Array_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1
            int[] ArrayOfNumbers = new int[10];
            intro();
            Console.WriteLine("\nTask 1 - Array 3");
            getArrayOfNumbers(ref ArrayOfNumbers, 0, 20);
            printArrayOfNumbers(ArrayOfNumbers);
            Console.WriteLine("\nTask 2 - Array 3");
            int[,] ArrayOfNumbersSec = new int[10, 20];
            getArrayOfNumbersSec(ref ArrayOfNumbersSec, 0, 100);
            printArrayOfNumbersSec(ArrayOfNumbersSec);

        }
        static void intro()
        {
            Console.WriteLine("I've compiled all 3 assignments in one program.");
        }
        #region ArrayOfNumbers
        static void getArrayOfNumbers(ref int[] ArrayOfNumbers, int low, int high)
        {
            Random rnd = new Random();
            for (int i = 0; i < ArrayOfNumbers.Length; i++)
            {
                int randomnmb = rnd.Next(high);
                if (ArrayOfNumbers[i] == 0)
                {
                    ArrayOfNumbers[i] = randomnmb;
                }
            }
        }
        #endregion ArrayOfNumbers
        #region printArrayOfNumbers
        static void printArrayOfNumbers(int[] ArrayOfNumbers)
        {
            Console.WriteLine($"[X] = Arvo.");
            for (int i = 0; i < ArrayOfNumbers.Length; i++)
                if (ArrayOfNumbers[i] < 10)
                {
                    Console.WriteLine($"[{i}] = 0{ArrayOfNumbers[i]}");
                }
                else
                {
                    Console.WriteLine($"[{i}] = {ArrayOfNumbers[i]}");
                }
        }
        #endregion perintArrayOfNumbers
        static void getArrayOfNumbersSec(ref int[,] ArrayOfNumbersSec, int x, int y)
        {
            Random rnd = new Random();
            for (int i = 0; i < ArrayOfNumbersSec.Length; i++)
            {
                for (int j = 0; j < ArrayOfNumbersSec.Length; j++)
                {
                    ArrayOfNumbersSec[i, j] = rnd.Next(100);
                }
            }
           
        }
        static void printArrayOfNumbersSec (int [,] ArrayOfNumbersSec)
        {
 
        }
    }
}
