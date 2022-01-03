namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// The entry point to the project
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            try
            {
                string[] programs =
                {
                "Head&Tails", "LeapYear", "Power Of Two Number",
                "HarmonicNumber", "PrimeFactors"
            };
                int i, number;
                for (i = 0; i < programs.Length; i++)
                {
                    Console.WriteLine("Enter {0} for {1}", i + 1, programs[i]);
                }

                int flag = 1;
                do
                {
                    for (i = 0; i < programs.Length; i++)
                    {
                        Console.WriteLine("Enter {0} for {1}", i + 1, programs[i]);
                    }

                    Console.WriteLine();
                    Console.WriteLine("Enter question number of program to execute it and Enter 0 to close");
                    try
                    {
                        number = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Please try entering value again again");
#pragma warning disable CS8604 // Possible null reference argument.
						number = Utility.IsInteger(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
					}

                    Console.WriteLine("num : {0}", number);
                    switch (number)
                    {
                        case 0:
                            return;
                        case 1:
                            FlipCoin c = new FlipCoin();
                            c.Toss();
                            break;
                        case 2:
                            LeapYear ly = new LeapYear();
                            ly.Leap();
                            break;
                        case 3:
                            PowerOfTwo p = new PowerOfTwo();
                            p.PowerTwo(Convert.ToInt32(args[0]));
                            break;
                        case 4:
                            Harmonic h = new Harmonic();
                            h.NHarmonic();
                            break;
                        case 5:
                            PrimeFactors fa = new PrimeFactors();
                            fa.PrimeFactorsfor();
                            break;
                        default:
                            Console.WriteLine("Not yet created");
                            flag = 0;
                            break;
                    }

                    Console.ReadKey();
                    Console.Clear();
                }
                while (flag == 1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}