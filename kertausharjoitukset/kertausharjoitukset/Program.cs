using System;

namespace kertausharjoitukset
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tehtävä 1
            Console.Write("Write me a string: ");
            string string1 = Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(string1);
            }


            //Tehtävä 2

            Console.Write("\nWrite me a string: ");
            string string2 = Console.ReadLine();

            for (int i = 0; i < string2.Length; i++)
            {
                Console.WriteLine(string2);
            }


            //Tehtävä 3
            Console.WriteLine("\nGive number for as long as you want, '-1' stops program: ");
            int num1 = 0;
            int sum = 0;

            while (num1 != -1)
            {
                num1 = int.Parse(Console.ReadLine());
                sum += num1;
            }

            Console.WriteLine($"Summary is: {sum + 1}");





            //Tehtävä 4

            Console.WriteLine("Quick Maths: ");
            Console.Write("First number: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            double num3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"\n{num2} + {num3} = {num2 + num3}");
            Console.WriteLine($"{num2} - {num3} = {num2 - num3}");
            Console.WriteLine($"{num2} * {num3} = {num2 * num3}");
            Console.WriteLine($"{num2} / {num3} = {num2 / num3}");
        }
    }
}
