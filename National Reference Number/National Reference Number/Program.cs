using System;

namespace National_Reference_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            int setting;
            do
            {
                setting = int.Parse(Console.ReadLine());
                switch (setting)
                {
                    case 1:
                        RefNumCheck();
                        break;
                    case 2:
                        RefNumCreate();
                        break;
                    default:
                        Console.Write("Wrong input. Pick number 1 or 2:");
                        break;
                }
            } while (setting != 1 || setting != 2);

        }
        static void Intro()
        {
            Console.WriteLine("1. Program checks your national reference number. \n" +
                "2. Program makes a national reference number.");
            Console.Write("Input numbers 1 or 2 to run a program and hit enter: ");
        }
        static void RefNumCheck()
        {
            string refNum = Input();
            int sum = 0;
            int[] multiplier = new int[] { 7, 3, 1 };
            int[] refArr = new int[refNum.Length];
            for (int i = 0; i < refNum.Length; i++)
            {
                refArr[i] = int.Parse(refNum[i].ToString());
            }
            for (int i = 0; i < refArr.Length - 1; i++)
            {
                sum += refArr[refArr.Length - 2 - i] * multiplier[i % 3];
            }
            int checkNum = 10 - (sum % 10);
            if (checkNum == 10)
            {
                checkNum = 0;
            }
            Console.WriteLine($"Input:{refNum}");
            if (refArr[refArr.Length - 1] == checkNum)
            {
                Console.WriteLine("Reference number is correct.");
            }
            else
            {
                Console.WriteLine("Reference number is incorrect.");
            }
        }

        static string Input()
        {
            string input = "placeholder";
            int inputNum = 0;
            do
            {
                Console.Write("Write a reference number that is 4 to 20 numbers long:");
                input = Console.ReadLine();
            } while (input.Length <= 4 || input.Length >= 20 || !Int32.TryParse(input, out inputNum) || inputNum < 0);
            return input;
        }

        static void RefNumCreate()
        {

            string refNumInput;
            do
            {
                Console.Write("Input a reference number prefix that is 3 to 19 numbers long:");
                refNumInput = Console.ReadLine();
            } while (refNumInput.Length <= 3 || refNumInput.Length >= 19);
            int sum = 0;
            int[] multiplier = new int[] { 7, 3, 1 };
            int[] refArr = new int[refNumInput.Length];
            for (int i = 0; i < refNumInput.Length; i++)
            {
                refArr[i] = int.Parse(refNumInput[i].ToString());
            }
            for (int i = 0; i < refArr.Length; i++)
            {
                sum += refArr[refArr.Length - 1 - i] * multiplier[i % 3];
            }
            int checkNum = 10 - (sum % 10);
            if (checkNum == 10)
            {
                checkNum = 0;
            }
            Console.WriteLine($"Input:{refNumInput}");
            string refNumOutput = refNumInput + checkNum;
            for (int i = 1; i < refNumOutput.Length; i++)
            {
                if (i % 5 == 0)
                {
                    refNumOutput = refNumOutput.Insert(i, " ");
                }
            }
            Console.WriteLine($"New reference number:{refNumOutput}");
        }
    }
}
