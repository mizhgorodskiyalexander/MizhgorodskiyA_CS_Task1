using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mizhgorodskiy_CS_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var b = true;
            while (b)
            {
                string[] d = Console.ReadLine().Split();

                for (int i = 0; i < d.Length; ++i)
                {
                    if (d[i].All(x => Char.IsDigit(x)) && Convert.ToInt32(d[i]) % 3 == 0)
                    {
                        Console.WriteLine(d[i]);
                        b = false;
                        
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
