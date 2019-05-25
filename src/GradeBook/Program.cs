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
            book.AddGrade(90.4);
            book.AddGrade(100);
            book.showStatistics();
            // creating a new array of numbers
            // double[] numbers = new double[3] { 12.7, 5.2, 1.3 };
            // double[] numbers = new[] { 12.7, 5.2, 1.3 };
            // var result = 0.0;
            // List<double> grades = new List<double>() { 12.7, 5.2, 1.3 };
            // grades.Add(56.1);

        }
    }
}
