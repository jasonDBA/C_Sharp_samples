using System;
using System.Text;

namespace AddStrings
{
    class Program
    {
        /*
         * Given two non-negative integers num1 and num2 represented as string, 
         * return the sum of num1 and num2.
         * 
         * Note:
         *  1. The length of both num1 and num2 is < 5100.
         *  2. Both num1 and num2 contains only digits 0-9.
         *  3. Both num1 and num2 does not contain any leading zero.
         *  4. You must not use any built-in BigInteger library or convert the inputs to integer directly.
         *  
         */
        static void Main(string[] args)
        {
            Console.WriteLine(AddStrings("56", "87"));
        }


        /*
         * Approach:
         *  1. Reverse both strings.
         *  2. Keep adding digits one by one from 0'th index to end of smaller string
         *  3. Append the sum % 10 to end of result and keep track of carry as sum / 10
         *  4. Finally reverse the result.
         */

        public static string AddStrings(string num1, string num2)   // Example: num1 = 56, num2 = 87
        {
            int carry = 0;              // carry = 0
            int i = num1.Length - 1;    // i = 1
            int j = num2.Length - 1;    // j = 1

            StringBuilder sb = new StringBuilder();

            while(i >= 0 | j >= 0 | carry != 0)
            {
                if (i >= 0)
                {
                    carry += (num1[i] - '0');   // carry = 0 -> 6
                    i--;    // i = 0
                }
                if(j >= 0)
                {
                    carry += (num2[j] - '0');   // carry = 6 + 7 = 13
                    j--;    // j = 0
                }

                // insert carry % 10 = 3 into 0'th index
                sb.Insert(0, $"{carry % 10}");

                // if carry is greater than 10, then the second digits should remain as the first digit
                carry /= 10;    // carry = 13 / 10 = 1

                // then repeat this with carry = 1, i = 0, j = 0. In the second loop, carry will be 0. 
                // End the while loop.
            }

            return sb.ToString();
        }
    }
}
