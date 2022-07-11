using System;

namespace SmallMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Started");
            var result1 = GetResultRecursively(20_000, 10_000);
            var result2 = GetResultRecursively(10_000, 0);
            Console.WriteLine("Ended");
            Console.ReadLine();
        }

        private static int GetResultRecursively(int start, int end)
        {
            start--;

            if (start == end)
            {
                return 0;
            }

            return GetResultRecursively(start, end);
        }
    }
}