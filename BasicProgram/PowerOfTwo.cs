using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    class PowerOfTwo
    {
        public static void poweroftwo()
        {
            int powerofn = 2;
            Console.WriteLine("...Power of N...");
            Console.WriteLine("Enter the Value of N:");
            int Valueofn = Convert.ToInt32(Console.ReadLine());
            if (Valueofn > 0 && Valueofn < 32)
            {
                for (int i = 1; i <= Valueofn; i++)
                {
                    powerofn = powerofn * 2;
                }
                Console.WriteLine("Two to the power of " + Valueofn + " is " + powerofn);
            }
            else
            {
                Console.WriteLine("Enter the number between 0 and 32");
            }
        }
    }
}