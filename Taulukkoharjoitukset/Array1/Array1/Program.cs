using System;

namespace Array1
{
    class MainClass
    {
        static void Main(string[] args)
        {
            #region Task 1
            Console.WriteLine("Array task 1");
            double[] productPrice = { 7.96, 72.0, 99.90 };
            int[] productAmount = { 1, 3, 2 };

            double[] productTotalPrice = {
                                           (productPrice[0] * productAmount[0]),
                                           (productPrice[1] * productAmount[1]),
                                           (productPrice[2] * productAmount[2])
                                         };
            #region Print
            Console.WriteLine($"Product 1:{productTotalPrice[0]} euroa");
            Console.WriteLine($"Product 2:{productTotalPrice[1]} euroa");
            Console.WriteLine($"Product 3:{productTotalPrice[2]} euroa");
            #endregion Print
            #endregion Task 1

            #region Task 2
            Console.WriteLine();
            Console.WriteLine("Task 2");

            double sum = 0;
            int i = 0;
            int[] iT = new int[100];
            Random rnd = new Random();

            for (int e = 0; e < 100; e++)
            {
                iT[i] = rnd.Next(50);
                i++;

            }
            i = 0;
            for (int e = 0; e < 100; e++)
            {
                sum += iT[i];
                Console.WriteLine($"{i + 1}. {iT[i]}");
                i++;
            }
            Console.WriteLine($"Sum is {sum}.");

            double avrg = (sum / iT.Length);
            Console.WriteLine($"Average is {avrg}");
            #endregion Task 2
        }
    }
}