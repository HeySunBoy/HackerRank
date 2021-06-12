using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        int T = int.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            bool IsPrime = true;
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                IsPrime = false;
            }
            else if (n > 2 && n % 2 == 0)
            {
                IsPrime = false;
            }
            else
            {
                for (int i = 3; i < Math.Sqrt(n) + 1; i += 2)
                {
                    if (n % i == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
            }
            if (IsPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }

}