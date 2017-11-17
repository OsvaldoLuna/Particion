using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[1];
            Console.WriteLine("Igresa un numero de 9 digitos");
            int num = n[1];

            int c = 0;
            for (int m = num; m > 0;)
            {
                m = m / 10;
                c++;
            }

            if (c == 9)
            {
                Console.Write("[");
                for (int nm = 0; nm >= 0; nm++)
                {
                    Console.Write("{0},", n[nm]);
                }
                Console.WriteLine("]");
            }
            Console.ReadKey();
        }
    }
}
