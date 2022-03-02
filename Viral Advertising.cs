using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PractiseBasicTopic
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine().Trim());
            int shared = 5;
            int liked;
            int cum = 0;
            for (int i = 0; i < n; i++)
            {
                if (i > 0)
                    shared = getShared(shared);

                liked = shared / 2;
                cum += liked;
            }

            Console.WriteLine(cum);
        }

        private static int getShared(int shared)
        {
            return (shared / 2) * 3;
        }
    }

}

