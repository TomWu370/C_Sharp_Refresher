using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner_Course.source
{
    public class IOTest
    {
        public static void Run()
        {
            Console.WriteLine("hi");
            string input = Console.ReadLine();
            Console.WriteLine("this is your input: " + input);
            Console.WriteLine("enter a number");
            string stringNumber = Console.ReadLine();
            int number = Convert.ToInt32(stringNumber);
            Console.WriteLine("Casting/Convertion from string to int, String: " + stringNumber + ", check converted type: " + number.GetType());
            Console.ReadLine();
        }
    }
}
