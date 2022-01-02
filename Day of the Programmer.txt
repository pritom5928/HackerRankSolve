using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PractiseBasicTopic
{
    public class Program
    {
        public static void Main()
        {
            int year = int.Parse(Console.ReadLine().Trim());

            string result = string.Empty;

            //for julian calender
            if (year < 1918)
            {
                if (year % 4 == 0)
                    result = GetDateForLeapYear(year, 256);
                else
                    result = GetDateForNonLeapYear(year, 256);
            }
            else if (year == 1918)
            {
                result = GetDateForTransitionYear(year, 256);
            }
            //for gregorian calender
            else
            {
                if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                    result = GetDateForLeapYear(year, 256);
                else
                    result = GetDateForNonLeapYear(year, 256);
            }



            Console.WriteLine(result);
        }

        private static string GetDateForTransitionYear(int year, int day)
        {
            int expectedDay = (day - (31 + 28 + 31 + 30 + 31 + 30 + 31 + 31)) + 13;

            return expectedDay.ToString() + ".09." + year.ToString();
        }

        private static string GetDateForNonLeapYear(int year, int day)
        {
            int expectedDay = day - (31 + 28 + 31 + 30 + 31 + 30 + 31 + 31);

            return expectedDay.ToString() + ".09." + year.ToString();
        }

        private static string GetDateForLeapYear(int year, int day)
        {
            int expectedDay = day - (31 + 29 + 31 + 30 + 31 + 30 + 31 + 31);

            return expectedDay.ToString() + ".09." + year.ToString();
        }
    }
}

