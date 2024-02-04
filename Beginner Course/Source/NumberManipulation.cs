using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner_Course.Source
{
    internal class NumberManipulation
    {
        public static void Run()
        {
            int number1 = 100;
            float number2 = 5.5f;
            double number3 = 9.5;
            Console.WriteLine("int: " + number1);
            Console.WriteLine("float: " + number2);
            Console.WriteLine("double: " + number3);
            Console.WriteLine("int with float arithmetic operation int*float: " + (number1 * number2)); // remains int when result is int
            Console.WriteLine("int with float arithmetic operation int/float: " + (number1 / number2)); // converts to float if result is not int
            Console.WriteLine("int with double arithmetic operation int*double: " + (number1 * number3)); // remains int
            Console.WriteLine("int with double arithmetic operation int/double: " + (number1 / number3)); // converts to double
            Console.WriteLine("int with double arithmetic operation int%double: " + (number1 % number3));
            Console.WriteLine("int with double arithmetic operation floor division int,double: " + Math.Floor(number1/number3));
            Console.WriteLine("Power operation with int^double: " + Math.Pow(number1, number3));
            Console.WriteLine("Square Root operation with int: " + Math.Sqrt(number1));
            Console.WriteLine("Find max and min number between number1 and number 2: " + Math.Max(number1, number2) + ", " + Math.Min(number1, number3));
            Console.WriteLine("Round double 5.66664 to 2 decimal points: " + Math.Round(5.66664, 2));

            Console.ReadLine();
        }
    }
}
