using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> City = new Dictionary<string, int>();
            City.Add("İstanbul", 34);
            City.Add("Kocaeli", 41);
            City.Add("Giresun", 28);
            Console.WriteLine(City.Count);
        }
    }
}


        