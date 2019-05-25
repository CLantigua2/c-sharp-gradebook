using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Carlos's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(50.7);
            book.AddGrade(70.6);
            book.AddGrade(80.0);
            book.AddGrade(85.0);
            book.AddGrade(66);

            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average}");
            // creating a new array of numbers
            // double[] numbers = new double[3] { 12.7, 5.2, 1.3 };
            // double[] numbers = new[] { 12.7, 5.2, 1.3 };
            // var result = 0.0;
            // List<double> grades = new List<double>() { 12.7, 5.2, 1.3 };
            // grades.Add(56.1);
        }
    }
}
