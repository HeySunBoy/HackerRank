using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = int.Parse(Console.ReadLine());
        for (int j = 0; j < n; j++)
        {
            string s = Console.ReadLine();
            string s_odd = string.Empty;
            string s_even = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    s_even += s[i];
                }
                else
                {
                    s_odd += s[i];
                }
            }
            Console.WriteLine(s_odd + " " + s_even);
        }
    }
}