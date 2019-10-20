using System;

namespace IF4
{
    class Program
    {
        static void Main(string[] args)
        {
            int first;
            int second;
            int last;

            Console.WriteLine("Anna kolme lukua. Ohjelma tulostaa oikean järjestyksen pienimmästä suurimpaan.");

            int i1, i2, i3;

            Console.Write("1. : ");
            i1 = int.Parse(Console.ReadLine());
            Console.Write("2. : ");
            i2 = int.Parse(Console.ReadLine());
            Console.Write("3. : ");
            i3 = int.Parse(Console.ReadLine());


            if (i1 > i2) { second = i1; first = i2; }
            else { second = i2; first = i1; }

            if (second > i3)
            {
                last = second; if (first > i3)
                {
                    second = first; first = i3;
                }
                else
                {
                    second = i3;
                }
            }
            else last = i3;

            Console.Write("Järjestys on: " + first + ", " + second + ", " + last + ".");




        }
    }
}