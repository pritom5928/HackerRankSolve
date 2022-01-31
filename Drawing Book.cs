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

            int searchPageFromforward = 0;
            int searchPageFromBackward = 0;
            int loopcounter = 0;

            bool oddTotalPage = totalPage % 2 != 0;

            for (int i = 1, j = totalPage; i <= totalPage && j >= 1; i = i + 2, j = j - 2)
            {

                if (i == 1 && i == searchPage)
                    searchPageFromforward = loopcounter;
                else if (i != 1 && (i == searchPage || i - 1 == searchPage))
                    searchPageFromforward = loopcounter;


                if (oddTotalPage)
                {
                    if (j == searchPage || j - 1 == searchPage)
                        searchPageFromBackward = loopcounter;
                    oddTotalPage = false;
                    j--;
                }
                else
                {
                    if (j == totalPage && j == searchPage)
                        searchPageFromBackward = loopcounter;
                    else if (j != totalPage && (j == searchPage || j + 1 == searchPage))
                        searchPageFromBackward = loopcounter;
                }

                loopcounter++;
            }

            if (searchPageFromforward == searchPageFromBackward || searchPageFromforward < searchPageFromBackward)
                finalOutput = searchPageFromforward;
            else
                finalOutput = searchPageFromBackward;

            return finalOutput;
        }
    }
}
