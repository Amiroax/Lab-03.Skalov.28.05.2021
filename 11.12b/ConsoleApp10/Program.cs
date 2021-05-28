using System;

namespace SimpleNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[30];
            int number = 1, index = 0;
            while (true)
            {
                if (IsSimple(number))
                    arr[index++] = number;
                if (index == 30)
                    break;
                number++;
            }

            foreach (int item in arr)
                Console.Write(item + " ");
            Console.ReadLine();
        }

        private static bool IsSimple(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}