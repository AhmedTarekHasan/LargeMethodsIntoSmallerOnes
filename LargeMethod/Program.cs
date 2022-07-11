using System;

namespace LargeMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Started");
            var result = GetResultRecursively(20_000);
            Console.WriteLine("Ended");
            Console.ReadLine();
        }

        private static int GetResultRecursively(int iterationNumber)
        {
            iterationNumber--;

            if (iterationNumber == 0)
            {
                return 0;
            }

            return GetResultRecursively(iterationNumber);
        }
    }
}