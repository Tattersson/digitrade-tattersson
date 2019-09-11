using System;

namespace PosOrNeg
{
    class Program
    {
        static void Main(string[] args)
            
        {
            int i;
            Console.WriteLine("Anna luku:");
            i=int.Parse(Console.ReadLine());

            if (i == 0)
            {
                // Luku on tasan nolla
                Console.WriteLine("Annoit luvun nolla!");
            }
            if (i > 0)
            {
                //Luku on isompi kuin nolla (Positiivinen)
                Console.WriteLine("Annoit luvun {0} ja luku on positiivinen", i);
            }
            else if (i < 0)
            {
                //Luku on pienempi kuin nolla (Negatiivinen)
                Console.WriteLine("Annoit luvun {0} ja luku on negatiivinen", i);
            }
            Console.ReadKey();
        }   
    }
}
