using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Pyramid
    {
        int i, j;
        public void Pyr()
        {
            for (i = 1; j <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("1");
                }

                Console.WriteLine();
            }
        }
    }
}
