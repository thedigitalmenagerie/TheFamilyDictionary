using System;
using System.Collections.Generic;

namespace TheFamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Krista" }, { "age", "42" } });

            foreach (var member in myFamily)
            {
                Console.WriteLine($"{member.Value["name"]} is my {member.Key} and is {member.Value["age"]} years old.");
            }
        }
    }
}
