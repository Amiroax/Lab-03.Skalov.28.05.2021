using System;
using System.Linq;

class Program
{
    public static void Main()
    {
        Console.WriteLine(String.Join(", ", Enumerable.Range(300, 17 * 20).Where(x => x % 13 == 0 || x % 17 == 0).Take(20)));
    }
}