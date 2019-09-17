using System;

namespace hello
{
    static int Main()
    {
                //Tässä kysyn asikkaalla summaa
                Console.WriteLine("Anna laskun summa:");
                int lasku = Convert.ToInt32(Console.ReadLine());

                //Tässä kysyn alennuksen prosentti määrää
                Console.WriteLine("Anna alennuksen prosentti määrä:");
                int alennus = Convert.ToInt32(Console.ReadLine());

                //Tässä kerron koko summan alennuksineen
                int alennusmsg = lasku - (lasku * alennus / 100);
                Console.WriteLine(value: "After discount your bill is: " + alennusmsg);

    }
}
