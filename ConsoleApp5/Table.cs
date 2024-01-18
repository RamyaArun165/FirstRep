using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Table
    {
        int a, b;
        public void Getdetails()
        {
            Console.WriteLine("Enter first number");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            b=Convert.ToInt32(Console.ReadLine());  
        }
        public void Display()
        {
         
            for(int i=1; i<=b; i++)
            {
                Console.WriteLine($"{a}*{i}={a * i}");    

            }
        }
    }
}
