using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace check1
{
    class Program
    {
        static void Main()
        {
            int i;
            Console.WriteLine("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("Entered Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Entered Number is an Odd Number");
                Console.Read();
            }
        }
    }
}

