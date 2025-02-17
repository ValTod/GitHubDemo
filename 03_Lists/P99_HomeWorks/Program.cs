using System;
using System.Collections.Generic;
using System.Linq;

namespace P99_HomeWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<double> resultList = new List<double>();

            for (int i = 0; i < numbers.Count; i++)
            {
                var tool = numbers[i];
                double checkSqrt = Math.Sqrt(tool);
                if (checkSqrt == (int)checkSqrt)
                {
                    resultList.Add(numbers[i]);
                }
            }
            resultList.Sort();
            resultList.Reverse();
            Console.WriteLine(string.Join(", ", resultList));
        }
    }
}
