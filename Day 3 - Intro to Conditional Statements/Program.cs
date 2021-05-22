using System;

namespace Day_3___Intro_to_Conditional_Statements
{
    class Solution
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine().Trim());

            if (N % 2 != 0)
            {
                Console.Write("Weird");
            }
            else if (N <= 5)
            {
                Console.Write("Not Weird");
            }
            else if (N <= 20)
            {
                Console.Write("Weird");
            }
            else
            {
                Console.Write("Not Weird");
            }
        }
    }

}
