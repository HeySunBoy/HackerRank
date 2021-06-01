using System;
using System.Linq;

class Difference
{
    private int[] elements;
    public int maximumDifference;

    // Add your code here
    public Difference(int[] a)
    {
        elements = a;
    }

    public void computeDifference()
    {
        elements = elements.OrderBy(o => o).ToArray();
        maximumDifference = Math.Abs(elements.First() - elements.Last());
    }

} // End of Difference Class

class Solution
{
    static void Main(string[] args)
    {
        Convert.ToInt32(Console.ReadLine());

        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.computeDifference();

        Console.Write(d.maximumDifference);
    }
}