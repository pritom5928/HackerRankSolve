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
            int totalPage = int.Parse(Console.ReadLine().TrimEnd());
            int searchPage = int.Parse(Console.ReadLine().TrimEnd());

            int result = pageCount(totalPage, searchPage);
            Console.WriteLine(result);
        }

        private static int pageCount(int totalPage, int searchPage)
        {
            int finalOutput = 0;

            int totalLengthL2R = totalPage / 2;
            int targetLengthL2R = searchPage / 2;

            int targetlengthR2L = totalLengthL2R - targetLengthL2R;

            finalOutput = Math.Min(targetLengthL2R, targetlengthR2L);

            return finalOutput;

        }
    }
}
