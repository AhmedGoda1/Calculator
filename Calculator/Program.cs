using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            double firstNum;
            double secondNum;
            string operation;
            string anotherOperation;
            

            Console.WriteLine("Welcome to standard calculator!");
            Console.WriteLine("");
            Console.WriteLine("Please enter your first number: ");
            firstNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Enter a second number: ");
            secondNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Which operation would you like to perform?");
            Console.WriteLine("Enter 'a' for addition, 's' for subtract, 'm' for multiplication and 'd' for division: ");
            operation = Console.ReadLine();

            if (operation == "a")
            {
                result = firstNum + secondNum;
            }
            else if (operation == "s")
            {
                result = firstNum - secondNum;
            }
            else if (operation == "m")
            {
                 result = firstNum * secondNum;
            }
            else if(operation == "d")
            {
                result = firstNum / secondNum;
            }
            else
            {
                Console.WriteLine("Please enter a correct operation letter");
            }
            Console.WriteLine("The result is: " + result);

            Console.WriteLine("Would you like to do another operation? (Y/N)");
            anotherOperation = Console.ReadLine();
            if (anotherOperation == "Y")
            {

            }
                



            Console.ReadKey();
        
        }

        
    }
}
