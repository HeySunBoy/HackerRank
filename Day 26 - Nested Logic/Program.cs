using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int[] date_return = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
        int[] date_due = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);

        int fine = 0;

        if (date_return[0] <= date_due[0] && date_return[1] <= date_due[1] && date_return[2] <= date_due[2])
        {
            fine = 0;
        }
        else if (date_return[0] > date_due[0] && date_return[1] == date_due[1] && date_return[2] == date_due[2])
        {
            fine = 15 * (date_return[0] - date_due[0]);
        }
        else if (date_return[1] > date_due[1] && date_return[2] == date_due[2])
        {
            fine = 500 * (date_return[1] - date_due[1]);
        }
        else if (date_return[2] > date_due[2])
        {
            fine = 10000;
        }
        Console.WriteLine(fine);
    }
}