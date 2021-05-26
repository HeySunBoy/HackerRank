using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, string> dicPhoneBook = new Dictionary<string, string>();

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            string strName = input.Split(' ')[0];
            string strPhone = input.Split(' ')[1];

            dicPhoneBook.Add(strName, strPhone);
        }

        while (true)
        {
            string strInputName = Console.ReadLine();

            if (string.IsNullOrEmpty(strInputName))
            {
                break;
            }
            else
            {
                if (dicPhoneBook.ContainsKey(strInputName))
                {
                    Console.WriteLine($"{strInputName}={dicPhoneBook[strInputName]}");
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}