using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner_Course.Source
{
    internal class ArrayManipulation
    {
        public static void Run()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            Console.WriteLine("printing array: [{0}]", string.Join(", ", array)); // 0 will take the first given variable, after the comma, string.join returns a string
            Console.WriteLine("5th item in array: " + array[4]);
            array[4] = 19123;
            Console.WriteLine("Updated 5th item in array: " + array[4]);
            int[] subarray = array.Skip(1).Take(7).ToArray();
            Console.WriteLine("subarray between 2nd and 8th item: " + string.Join(", ", subarray));
            Console.ReadLine();
        }
    }
}
