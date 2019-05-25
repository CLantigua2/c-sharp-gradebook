using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
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

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            if (grades.Count == 0)
            {
                throw new Exception("No grade has been added, please add grades");
            }
            foreach (var grade in this.grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }
            result.Average /= grades.Count;

            return result;
        }
        // this is a field because it's outside of a method
        // made private so that only this class can have access to grades
        private List<double> grades;
        private string name;
    }
}