using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class reverseNumber
    {
        public static void ReverseProgram(int number)
        {
            int remainder = 0, reverse = 0;

            while (number != 0)
            {
                remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;

                Console.WriteLine("remainder: {0} number: {1} reverse : {2}", remainder, number, reverse);
            }

            Console.WriteLine("Reverse number is " + reverse);
        }
    }
}