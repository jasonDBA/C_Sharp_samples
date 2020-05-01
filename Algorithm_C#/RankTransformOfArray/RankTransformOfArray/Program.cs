using System;
using System.Collections.Generic;
using System.Linq;

namespace RankTransformOfArray
{
    class Program
    {
        /*
        Given an array, write a function to output the ranking of each value in the array. 
        Equal values should have the same ranking. 
        For example: input of [25, 7, 54, 90, 7] should result in [2, 1, 3, 4, 1] 
        */
        static void Main(string[] args)
        {
            int[] arr = { 25, 7, 54, 90, 7 };

            foreach (var item in rankingArray(arr))
            {
                Console.Write($"{item}, ");
            }

        }

        public static int[] rankingArray(int[] arr)
        {
            int[] result = new int[arr.Length];                 // create a result array
            int[] arrCopy = new HashSet<int>(arr).ToArray();    // no duplicates are allowed in HashSet

            Array.Sort(arrCopy);    // sort the copy of the input array (no duplicate exists) - arrCopy = {7, 25, 54, 90}

            var rank = new Dictionary<int, int>();

            for (int i = 0; i < arrCopy.Length; i++)
            {
                rank[arrCopy[i]] = i + 1;   // rank is mapping like {7, 1}, {25, 2}, {54, 3}, {90, 4}
            }
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = rank[arr[i]];   // rank[arr[0]] = 2, rank[arr[1]] = 1, rank[arr[2]] = 3, rank[arr[3]] = 4, rank[arr[4]] = 1 
            }
            return result;  // result = {2,1,3,4,1}
        }
    }
}
