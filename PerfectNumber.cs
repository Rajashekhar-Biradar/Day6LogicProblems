using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProblems
{
    internal class PerfectNumber
    {
        public static void perfectNumber()
        {
            int sum = 0;
            Console.WriteLine("enter the Number ");
            int number = Convert.ToInt32(Console.ReadLine());
           
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == number)
            {
                Console.WriteLine("Entered number is a perfect number");
               
            }
            else
            {
                Console.WriteLine("Entered number is not a perfect number");
               
            }
        }
    }
    
}
