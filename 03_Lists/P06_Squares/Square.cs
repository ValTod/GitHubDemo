using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_Squares
{
    class Square
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine() // дуржим всички входни числа
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>(); // ще държим само квадратните числа

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                double square = Math.Sqrt(currentNumber);
                if (square == (int)square)
                {
                    result.Add((int)square);
                }
            }

            result.Sort();
            result.Reverse();

            Console.WriteLine(string.Join("<=", result));
        }
    }
}
