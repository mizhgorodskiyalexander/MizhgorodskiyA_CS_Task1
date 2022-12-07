using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mizhgorodskiy_CS_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var b = true;
            while (b)
            {
                string name = Console.ReadLine();

                if (name == "Вячеслав")
                    Console.WriteLine("Привет, Вячеслав");
                else
                    Console.WriteLine("Нет такого имени");
            }
        }
    }
}
