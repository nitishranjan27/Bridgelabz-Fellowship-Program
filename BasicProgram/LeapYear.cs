using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class LeapYear
    {
        public static void Leap_Years()
        {
            Console.WriteLine("Enter Year : ");
            int Year = Convert.ToInt32(Console.ReadLine());
            if (Year >= 1000 && Year <= 9999)
            {
                if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                {
                    Console.WriteLine("{0} is a Leap Year.", Year);
                }
                else
                {
                    Console.WriteLine("{0} is not a Leap Year.", Year);
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Enter the 4 digit number");
                Console.ReadLine();
            }
        }
    }
}