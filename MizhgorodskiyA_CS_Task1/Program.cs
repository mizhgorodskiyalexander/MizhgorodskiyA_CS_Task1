using System;

namespace MizhgorodskiyA_CS_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var b = true;
            while (b)
            {
                string num = Console.ReadLine();
                bool isDig = true;
                for (int i = 0; i < num.Length; ++i)
                {
                    if (!Char.IsDigit(num[i]))
                    {
                        isDig = false;
                        break;
                    }
                }

                if (!isDig) continue;
                else if (Convert.ToInt32(num) > 7)
                {
                    Console.WriteLine("Привет");
                    b = false;
                }
                Console.ReadLine();
            }
        }
    }
}
