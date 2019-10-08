using System;

namespace Lippu
{
    class Program
    {
        static void Main(string[] args)
        {
            double discount = 0;
            string isConscript;
            string isMTK;
            string isStudent;
            int a = 16;
            int e = 0;

            Console.WriteLine("Hei, ohjelma laskee sinulle alennuksen. ");
            Console.Write("Oletko Varusmies? [Y / N] :");
            isConscript = Console.ReadLine();
            if (isConscript.ToUpper() == "Y")
            {
                //Tässä lasketaan varusmiehen alennus.
                //50% alennus.
                discount = 0.5;
            }
            else
            {
                //Tässä käyn läpi että onko asiakas vanhus (Yli 65 vuotias).
                //50% alennus.
                Console.WriteLine("Syötä Ikäsi?");
                e = int.Parse(Console.ReadLine());
                if (e > 65)
                {
                    discount = 0.5;
                }
                //Tässä käyn läpi onko asiakas 7 - 15 vuoden ikäinen.
                //Heille on myös 50% alennus.
                else if (e > 7 && e <= 15)
                {
                    discount = 0.5;
                }
                else if (e <= 7)
                {
                    //Tässä käyn läpi onko asiakas alle 7 vuotias.
                    //Heille 100% alennus
                    discount = 1;
                }
                if (e >= 16 && e <= 65)
                {
                    //Tässä kysytään onko asiakas opiskelija ja mtkn jäsen
                    Console.WriteLine("Oletko opiskelija? [Y / N]");
                    isStudent = Console.ReadLine();
                    if (isStudent.ToUpper() == "Y")
                    {
                        Console.WriteLine("Oletko myös MTK:n jäsen? [Y / N]");
                        isMTK = Console.ReadLine();
                        if (isMTK.ToUpper() == "Y")
                        {
                            //On MTK:n jäsen sekä Opiskelija
                            discount = 0.6;
                            
                        }
                        //Ei ole MTK:n jäsen mutta on opiskelija
                        else if (isMTK.ToUpper() == "N")
                        {
                            discount = 0.45; 
                        }
                    }
                    else if (isStudent.ToUpper() == "N")
                    {
                        Console.WriteLine($"Oletko MTK:n Jäsen? Y/N :");
                        isMTK = Console.ReadLine();
                        if (isMTK.ToUpper() == "Y")
                        {
                            discount = 0.15;
                        }
                    }

                    //Jos mikään noista ei täyty niin täysi hinta.
                    else
                    {
                        discount = 0;
                    }
                }
            }
            Console.WriteLine($"Lipun hinta on {a - (a * discount)}");
        }
    }
}