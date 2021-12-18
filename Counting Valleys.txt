

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PractiseBasicTopic
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine().Trim());
            string paths = Console.ReadLine().TrimEnd();

            int valleyHiked = countingValleys(paths, n);

            Console.WriteLine(valleyHiked);
            Console.ReadKey();
        }

        private static int countingValleys(string path, int n)
        {
            int alter = 0;
            int valleyCount = 0;
            foreach (var ch in path)
            {
                if (ch == 'D')
                    alter--;
                else
                    alter++;

                if (alter == 0 && ch == 'U')
                    valleyCount++;
            }

            return valleyCount;
        }

    }
}
