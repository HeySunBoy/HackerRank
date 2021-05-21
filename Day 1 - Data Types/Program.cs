using System;
using System.Collections.Generic;
using System.IO;

namespace Data_Types
{
    class Solution
    {
        static void Main(String[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";


            // Declare second integer, double, and String variables.
            int read_i;
            double read_d;
            string read_s;
            // Read and save an integer, double, and String to your variables.
            read_i = int.Parse(Console.ReadLine());
            read_d = double.Parse(Console.ReadLine());
            read_s = Console.ReadLine();
            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + read_i);
            // Print the sum of the double variables on a new line.
            Console.WriteLine(string.Format("{0:N1}",d + read_d));
            // Concatenate and print the String variables on a new line
            Console.WriteLine(s + read_s);
            // The 's' variable above should be printed first.

        }
    }
}
