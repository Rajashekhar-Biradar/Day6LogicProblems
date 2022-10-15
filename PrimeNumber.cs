using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProblems
{
    internal class PrimeNumber
    {
        public static void primeNumber()
        {
            Console.WriteLine(" enter a number ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine("{0} is a Prime Number", n);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
            Console.ReadLine();
        }
    }
}
