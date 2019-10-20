using System;

namespace Toistorakenne_jatkuu_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, k, p;
            for (i=1; i<=10; i++)
            {
                for (k=1; k<=10; k++)
                {
                    p = i * k;
                    Console.Write(i+ "x" + k + "=" +p + "  ");
                }
                Console.WriteLine("   ");
                Console.WriteLine("   ");
            }

        }
    }
}




/*
          for (int i = 1; i <= 10; i++)
          {
              for (int j = 1; j <= 10; j++)
              {
                  Console.WriteLine ((i * j) + " ");
              }
          */

