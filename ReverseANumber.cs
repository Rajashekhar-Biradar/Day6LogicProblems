using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProblems
{
    internal class ReverseANumber
    {
        public static int reverseNumber()
        {
            Console.Write("Enter a Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int reminder, reverse = 0;
            while (number > 0)
            {
                //Get the remainder by dividing the number with 10  
                reminder = number % 10;
                //multiply the sum with 10 and then add the reminder
                reverse = (reverse * 10) + reminder;
                //Get the quotient by dividing the number with 10 
                number = number / 10;
            }
            //Console.WriteLine("The Reverse order is : " + reverse);
            return reverse;
        }
    }
}
