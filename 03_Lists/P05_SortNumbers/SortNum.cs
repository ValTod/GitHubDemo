using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_SortNumbers
{
    class SortNum
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            numbers.Sort();
           
            Console.WriteLine(string.Join("<=", numbers));
        }
    }
}
