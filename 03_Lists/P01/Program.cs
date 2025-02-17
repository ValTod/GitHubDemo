using System;
using System.Collections.Generic;
using System.Linq;

namespace P01
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();

            List<string> items = values.Split(' ').ToList();
            Console.WriteLine("string.Join means:");
            Console.WriteLine(string.Join("<=||=>", items));

            List<int> nums = new List<int>();

            for (int i = 0; i < items.Count; i++)
            {
                nums.Add(int.Parse(items[i]));
            }

            Console.WriteLine("print numbers:");
            Console.WriteLine(string.Join(';', nums));

            //var items = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        }
    }
}
