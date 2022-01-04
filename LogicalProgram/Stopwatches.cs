namespace LogicalProgram
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// this is Stopwatches class.
    /// </summary>
    public class Stopwatches
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Stopwatches"/> class.
        /// </summary>
        public static void stopwatches()
        {
            Stopwatch stopwatch = new Stopwatch();
        validation1:
            Console.WriteLine("To start the stopwatch enter S or s.");
#pragma warning disable CS8604 // Possible null reference argument.
			char start = Convert.ToChar(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
			stopwatch.Start();
            if (start == 's' || start == 'S')
            {
            validation2:
                Console.WriteLine("To stop the stopwatch enter Q or q.");
#pragma warning disable CS8604 // Possible null reference argument.
				char end = Convert.ToChar(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
				if (end == 'q' || end == 'Q')
                {
                    stopwatch.Stop();
                    Console.WriteLine("stopwatch stopped, the time:" + stopwatch.Elapsed);
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                    goto validation2;
                }
            }
            else
            {
                stopwatch.Stop();
                Console.WriteLine("Wrong Input");
                goto validation1;
            }
        }
    }
}