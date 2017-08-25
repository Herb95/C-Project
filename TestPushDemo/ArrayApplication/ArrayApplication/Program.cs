using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[20];

            int i, j;

            for (i = 0; i < 20; i++)
            {

                a[i] = i + 100;

            }
            for (j = 0; j < 20; j++)
            {

                Console.WriteLine("数组[{0}] = {1}", j, a[j]);

            }
            Console.ReadKey();
        }
    }
}
