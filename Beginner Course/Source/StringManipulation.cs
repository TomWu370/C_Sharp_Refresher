using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner_Course.Source
{
    internal class StringManipulation
    {
        public static void Run()
        {
            string phrase = string.Empty;
            Console.WriteLine("this is a empty string initialisation: " + phrase);
            phrase = "hEllo world";
            Console.WriteLine("this is a reassigned string: " + phrase);
            Console.WriteLine("this is the string length: " + phrase.Length);
            Console.WriteLine("this is a string converted to lowercase: " + phrase.ToLower());
            Console.WriteLine("this is a string converted to uppercase: " + phrase.ToUpper());
            Console.WriteLine("check if string contains 'hello': " + phrase.Contains("hello"));
            Console.WriteLine("check if string contains 'hEllo': " + phrase.Contains("hEllo"));
            Console.WriteLine("get 5th character in string: " + phrase[4]);
            Console.WriteLine("get substring of string from 2nd with length of 4: " + phrase.Substring(1, 4));
            Console.WriteLine("get start index of substring 'world' in string: " + phrase.IndexOf("world"));
            Console.ReadLine();
        }
    }
}
