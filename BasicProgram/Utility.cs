namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This class has various methods that are used in other programs
    /// </summary>
    public class Utility
    {
        /// <summary>
        ///  IsInteger Determines whether the specified input is integer.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        ///   <c>true</c> if the specified input is integer; otherwise, <c>false</c>.
        /// </returns>
        public static int IsInteger(string input)
        {
            int num;
            //// trying to convert to integer
            if (int.TryParse(input, out num))
            {
                return Convert.ToInt32(input);
            }
            else
            {
                //// method tries to convert the string to integer num untill its succesful
                while (int.TryParse(input, out num) == false)
                {
                    Console.WriteLine("You have not entered an integer number please try again");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
					input = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
				}

                return Convert.ToInt32(input);
            }
        }

        /// <summary>
        /// Determines whether the specified input is double.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>double value</returns>
        public static double IsDouble(string input)
        {
            double num;
            //// trying to convert to double
            if (double.TryParse(input, out num))
            {
                return num;
            }
            else
            {
                //// method tries to convert the string to double num untill its succesful
                while (double.TryParse(input, out num) == false)
                {
                    Console.WriteLine("You have not entered a number please try again");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
					input = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
				}

                return num;
            }
        }

        /// <summary>
        /// Determines whether the specified input is string.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        /// <c>true</c> if the specified input is not having a number and any spaces; otherwise, <c>false</c>.
        /// </returns>
        public static string IsString(string input)
        {
            //// flag will be 1 untill any of the below conditions are matched else it's converted to zero
            int flag = 0, i;
            string[] specialchars = { "!", "|", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", ",", ".", "/" };
            do
            {
                flag = 0;
                //// it checks it the string has spaces
                for (i = 0; i < 10; i++)
				{
#pragma warning disable CS8602 // Dereference of a possibly null reference.
					if (input.Contains(i.ToString()))
#pragma warning restore CS8602 // Dereference of a possibly null reference.
					{
						flag = 1;
						Console.WriteLine("You have entered number in string it should not be please try again");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
						input = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
						break;
					}
					else
					{
						//// to check has space
						if (input.Contains(" "))
						{
							flag = 1;
							Console.WriteLine("You have entered space it should not be, please try again");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
							input = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
							break;
						}
						else
						{
							flag = 0;
						}
					}
				}
			}
            while (flag == 1);
#pragma warning disable CS8603 // Possible null reference return.
			return input;
#pragma warning restore CS8603 // Possible null reference return.
		}

        /// <summary>Determines whether the specified input is boolean.</summary>
        /// <param name="input">The input.</param>
        /// <returns>
        /// <c>true</c> if the specified input is boolean; otherwise, <c>false</c>.</returns>
        public static bool IsBoolean(string input)
        {
            input.ToLower();
            ////this check the value of input if its true or false
            while (string.Equals(input, "true") != true && string.Equals(input, "false") != true)
            {
				//// converting the string to lower case as it could be in upper case too
#pragma warning disable CS8602 // Dereference of a possibly null reference.
				_ = input.ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
				Console.WriteLine("You have not entered a boolean value please try again");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
				input = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
			}

#pragma warning disable CS8602 // Dereference of a possibly null reference.
			return input.Equals("true") ? true : false;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
		}

        /// <summary>
        /// This generic method prints the 2d array of any format.
        /// </summary>
        /// <typeparam name="Template">The type of the Template.</typeparam>
        /// <param name="array">The array.</param>
        public static void Print2DArray<Template>(Template[,] array)
        {
            int rows = 0, cols = 0;
            //// traversing the array to print the elements in the array
            for (rows = 0; rows < array.GetLength(0); rows++)
            {
                for (cols = 0; cols < array.GetLength(1); cols++)
                {
                    Console.Write("{0} ", array[rows, cols]);
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Generates random double value between 0 and 1
        /// </summary>
        /// <returns>returns the random double value</returns>
        public static double RandomDoubleGenerator()
        {
            Random rand = new Random();
            return rand.NextDouble();
        }

        /// <summary>
        /// Randoms the int generator between max and min value.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <returns>random integer number</returns>
        public static int RandomIntGenerator(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max + 1);
        }
    }
}