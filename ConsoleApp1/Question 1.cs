using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Activity activity = new Activity();
            activity.RunMethod();
            Console.ReadKey();
        }
    }

    public class Activity
    {
    double number1, number2, number3, number4;
    public void RunMethod()
    {
        System.Console.WriteLine("Enter the first number: ");
        number1 = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("Enter the second number: ");
        number2 = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("Enter the third number: ");
        number3 = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("Enter the fourth number: ");
        number4 = Convert.ToDouble(Console.ReadLine());

        double average = (number1 + number2 + number3 + number4) / 4;

        System.Console.WriteLine($"The average of {number1}, {number2}, {number3}, {number4} is {average}");  
    }
    }
}