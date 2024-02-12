using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner_Course.Source
{
    internal class IfAndLoops
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number to iterate");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number of times to iterate");
            int iterations = Convert.ToInt32(Console.ReadLine());
            if (input % 2 == 0){
                Console.WriteLine("the input number is even");
                for (int i = 0; i < iterations; i++){
                    Console.WriteLine("this is the number in for loop: " + input);
                }
            }
            else{
                Console.WriteLine("the input number is odd");
                int counter = iterations;
                while (counter > 0) { 
                    Console.WriteLine("this is the number in while loop: " + input);
                    counter -= 1;
                }
                Console.WriteLine();
                counter = iterations;
                do {
                    Console.WriteLine("this is the number in do while loop: " + input);
                    counter -= 1;
                } while (counter > 0);
            }

            Console.ReadLine();

        }
    }
}
