using System;

namespace Funktio_ja_aliohjelmat_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(numbers());
        }
        static string numbers()
        {
            int MaxIn = 1;
            int input;
            int count = 1;
            int highNum = 0;
            string output = "";
            string finalOutput = "";

            Console.WriteLine("Give me ten positive numbers.");

            while (count <= 10)
            {
                Console.Write($"{count}: ");
                input = int.Parse(Console.ReadLine());

                if (input > 0)
                {
                    if (input > highNum)
                    {
                        highNum = input;
                        MaxIn = count;
                    }
                    output += $"{input}";
                    count++;
                }
                else if (input < 0)
                {
                    Console.WriteLine("Wrong input.");
                }
            }
            finalOutput = $"You have given these numbers: {output}\n Highest number was {highNum}\n Your {highNum} was {MaxIn} in order.";
            return finalOutput;
        }
    }
}
