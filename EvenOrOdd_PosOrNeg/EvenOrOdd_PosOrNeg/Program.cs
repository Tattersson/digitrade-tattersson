using System;

namespace EvenOrOdd_PosOrNeg
{
    class Program
    {
        static void Main(string[] args)

        {
            int i;
            Console.WriteLine("Enter a number:");
            i = int.Parse(Console.ReadLine());
            if (i == 0)
            {
                Console.WriteLine("Number you gave is zero!");
                Console.Read();
            }
                                       
                                        //Tässä tarkastetaan onko luku parillinen ja positiivinen
                                        if (i % 2 == 0)
                                        {
                                            //Tässä tarkastetaan onko luku suurempi kuin nolla
                                            if (i > 0)
                                            {
                                                Console.WriteLine("Number {0} is even and positive", i);
                                                Console.Read();
                                            }
                                            //Tässä tarkastateen onko luku pienempi kuin nolla
                                            if (i < 0)
                                            {
                                                Console.WriteLine("Number {0} is even and negative", i);
                                                Console.Read();
                                            }
                                        }
            //Tässä ohjelma on saanut jo selville että luku on pariton.
            //Ainoa mitä tehdään on että ohjelma tarkastaa onko luku positiivinen vai negatiivinen
            else
            {
                if (i > 0)
                {
                    Console.WriteLine("Number {0} is odd and positive", i);
                    Console.Read();
                }
                if (i < 0)
                {
                    Console.WriteLine("Number {0} is odd and negative", i);
                    Console.Read();
                }
            }
          
        }
    }
}
