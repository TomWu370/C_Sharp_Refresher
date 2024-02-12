using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner_Course.Source
{
    internal class SwitchEnum
    {
        enum Month {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        public static void Run()
        {
            Console.WriteLine("Enter a Month capitalised: ");
            string input = Console.ReadLine();
            if (Enum.TryParse(input, out Month month))
            {
                Console.WriteLine(month);
                switch (month)
                {
                    case Month.January:
                        Console.WriteLine("The inputted month is: " + month + " and it's the 1st month of the year");
                        break;

                    case Month.February:
                        Console.WriteLine("the month is feb and it's the 2nd month of the year");
                        break;

                    default:
                        Console.WriteLine("The inputted month is: " + month + " and its corresponding index is: " + (int)month);
                        break;
                }
            }
            else
            {
                Console.WriteLine("failed parse, enter an existing month");
            }

            Console.ReadLine();
        }
    }
}
