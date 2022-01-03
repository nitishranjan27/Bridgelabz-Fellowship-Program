namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The class is to execute the Harmonic number program
    /// </summary>
    public class Harmonic
    {
        /// <summary>
        /// Executes the harmonic functions
        /// </summary>
        public void NHarmonic()
        {
            try
            {
                int num, count = 0, numerator = 0, denominator = 1;

                Console.WriteLine("Enter the number to find the Nth Harmonic value");
#pragma warning disable CS8604 // Possible null reference argument.
				num = Utility.IsInteger(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
							  //// to check if the entered value is number
							  //// Multiplying denominators
				for (count = 1; count <= num; count++)
                {
                    denominator = denominator * count;
                }
                ////calculating numerator for harmonic 
                for (count = 1; count <= num; count++)
                {
                    numerator += denominator / count;
                }

                Console.WriteLine("The {0}th harmonic number is {1} / {2} or {3} ", num, numerator, denominator, numerator * 1.0 / denominator);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}