using System;
using System.Collections.Generic;

namespace HackerRankChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }




        //        Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero.Print the decimal value of each fraction on a new line with  places after the decimal.

        //Note: This challenge introduces precision problems.The test cases are scaled to six decimal places, though answers with absolute error of up to are acceptable.

        #region #1


        public static void plusMinus(List<int> arr)
        {
            float zeroCount = 0;
            float postiveCount = 0;
            float negativeCount = 0;
            foreach (var item in arr)
            {
                if (item > 0)
                {
                    postiveCount++;
                }
                else if (item < 0)
                {
                    negativeCount++;
                }
                else
                {
                    zeroCount++;
                }
            }
            var arrayLength = arr.Count;

            Console.WriteLine("{0:F6}", postiveCount / arrayLength);
            Console.WriteLine("{0:F6}", negativeCount / arrayLength);
            Console.WriteLine("{0:F6}", zeroCount / arrayLength);
        }
        #endregion



        // Given five positive integers, find the minimum and maximum values that can be calculated
        // by summing exactly four of the five integers.Then print the respective minimum and maximum
        // values as a single line of two space-separated long integers.

        #region #2

        //public static void miniMaxSum(List<int> arr)
        //{
        //    int minValue = arr.Max();
        //    int sumOfAllNumbers = 0;
        //    int maxValue = 0;
        //    for (int i = 0; i < 5; i++)
        //    {
        //        sumOfAllNumbers += arr[i];
        //        if (arr[i] < minValue)
        //        {
        //            minValue = arr[i];
        //        }
        //        if (arr[i] > maxValue)
        //        {
        //            maxValue = arr[i];
        //        }
        //    }
        //    Console.Write("{0} {1}", sumOfAllNumbers - maxValue, sumOfAllNumbers - minValue);
        //}
        #endregion
    }
}
