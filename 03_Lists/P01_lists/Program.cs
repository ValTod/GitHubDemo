using System;
using System.Collections.Generic;

namespace P01_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>(); // Create a list of strings
            names.Add("Peter");
            names.Add("Maria");
            names.Add("George");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            names.Remove("Maria");
            names.Insert(0, "Иванчо и Марийка");
            Console.WriteLine(String.Join(", ", names));
        }

    }
}
