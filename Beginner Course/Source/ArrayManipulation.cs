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

            int[,] array2d = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("this is a 2d array: ");
            for (int i = 0; i < array2d.GetLength(0); i++) {
                for (int j = 0; j < array2d.GetLength(1); j++){
                    Console.Write(array2d[i, j]);
                }
                Console.WriteLine();
            }
            int[][] jaggedarray2d = new int[3][]; // jagged 2d array don't have to have fixed inner array length, can specify length in declaration
            jaggedarray2d[0] = new int[]{1,2,3};
            jaggedarray2d[1] = new int[]{4,5,6,7};
            jaggedarray2d[2] = new int[] {8,9,10,11};
            Console.WriteLine("this is a jagged 2d array: ");
            for (int i = 0; i <jaggedarray2d.GetLength(0); i++)
            {
                Console.WriteLine("[{0}]", string.Join(", ", jaggedarray2d[i]));
            }

            Console.WriteLine("this is the 2nd subarray and 2nd item from that subarray: " + array2d[1, 1]);
            Console.ReadLine();
        }
    }
}
