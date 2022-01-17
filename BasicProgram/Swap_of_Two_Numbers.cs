using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
	public class Swap_of_Two_Numbers
	{
        public static void swapingNumbers()
        {
            Console.WriteLine("...Swaping of Two Numbers...");
            Console.WriteLine("Enter the First number and Second number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swap FirstNumber= " + firstNumber + " SecondNumber= " + secondNumber);
            firstNumber = firstNumber * secondNumber;       
            secondNumber = firstNumber / secondNumber;      
            firstNumber = firstNumber / secondNumber; 
            Console.WriteLine("After Swaping , The numbers are..");
            Console.WriteLine(" FirstNumber= " + firstNumber + " SecondNumber= " + secondNumber);
        }
    }
}
