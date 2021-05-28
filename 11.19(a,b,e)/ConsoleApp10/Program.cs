using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = new int[4] { 1, 2, 3, 5 };
            int sum = 0;
            int result;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            result = sum / arr.Length;
            Console.WriteLine(sum);
            Console.WriteLine(result);
        }
    }
}