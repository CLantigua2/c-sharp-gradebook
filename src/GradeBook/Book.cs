using System;
using System.Collections.Generic;
namespace GradeBook
{
    class Book
    {
        // constructor
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }


        public void AddGrade(double grade)
        {
            if (grade > 100)
            {
                throw new Exception("Grade is over 100");
            }
            else if (grade < 0)
            {
                throw new Exception("Grade must be greater than 0");
            }
            else
            {
                this.grades.Add(grade);
            }
        }

        public void showStatistics()
        {
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            var result = 0.0;
            foreach (var number in this.grades)
            {
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine(value: $"\nThe average grade is {result:N1}\n The highest grade is {highGrade:N1}\n The lowest grade is {lowGrade:N1}");
        }
        // this is a field because it's outside of a method
        // made private so that only this class can have access to grades
        private List<double> grades;
        private string name;
    }
}