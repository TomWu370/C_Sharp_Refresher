using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner_Course.Source
{
    internal class MethodTest
    {
        public static void Run()
        {
            say("this is a method");
            Console.ReadLine();
        }

        static void say(string message)
        {
            Console.WriteLine(message);
        }
    }
}
