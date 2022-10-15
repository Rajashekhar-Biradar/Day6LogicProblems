using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProblems
{
    internal class FibonacciSeries
    {
        public static void fibonacciSeries()
        {
            Console.WriteLine(" ehter the startting two numbers ");
            int val1=Convert.ToInt32(Console.ReadLine());
            int val2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the counts");
            int n=Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine("Fibonacci series:");
            Console.Write(val1 + " " + val2 + " ");
            for (int i = 2; i < n; ++i)
            {
                int val3 = val1 + val2;
                Console.Write(val3 + " ");
                val1 = val2;
                val2 = val3;
            }
        } 
    }
}
