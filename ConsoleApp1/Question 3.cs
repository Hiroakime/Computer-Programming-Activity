using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq; 

namespace Sample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Activity.RunMethod(); 
            Console.ReadKey();
        }
    }

    public class Activity
    {
        public static void RunMethod() 
        {
            List<int> ListOne = new List<int> {1, 20, 3, 6, 8, 9, 10, 7, 12, 21, 18};
            List<int> ListTwo = new List<int> {10, 2, 30, 15, 8, 21, 13, 18, 28, 25, 16};
            List<int> common = ListOne.Intersect(ListTwo).ToList();
            
            System.Console.WriteLine($"All common numbers on both list: {string.Join(", ", common)}");
        }
    }
}
