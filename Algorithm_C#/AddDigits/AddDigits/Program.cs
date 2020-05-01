using System;

namespace AddDigits
{
    class Program
    {
        /*
         Given a non-negative integer num, repeatedly add all its digits until the result has only one digit.
         
         Example:
         Input: 38
         Output: 2 
         Explanation: The process is like: 3 + 8 = 11, 1 + 1 = 2.
         Since 2 has only one digit, return it.
             
             */
        static void Main(string[] args)
        {
            Console.WriteLine(AddDigits(245));
        }


        /*
         * Approach:
         *  1. Start adding from 0'th index -> num % 10
         *  2. The remaining number -> num / 10
         *  3. Repeat the step (1) and (2) and add the remainder to the carry variable.
         *  4. If the carry (result) is less than 10, print out the result.
         */ 

        public static int AddDigits(int num)
        {
            while(num >= 10)
            {
                int carry = 0;
                while (num > 0)
                {
                    carry += (num % 10);    //First loop: 5,   5+4,    5+4+2   //Second loop: 1,   1+1
                    num /= 10;              //First loop: 24,  2,      0       //Second loop: 1,   0
                }

                if(carry < 10)
                {
                    return carry;     // Finally, sum become 1+1 = 2, which is the answer.
                }
                else
                {
                    num = carry;      // num = sum = 5+4+2 = 11, Since num > 10, repeat the above loop again.
                }
            }
            return num;

        }
    }
}
