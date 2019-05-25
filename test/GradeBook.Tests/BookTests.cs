using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            // arrange where you put together all of the test data
            var book = new Book("");
            book.AddGrade(30.2);
            book.AddGrade(45.6);
            book.AddGrade(80.5);
            // act (logic and computational actions)
            var result = book.GetStatistics();

            // assert (returns true or false)
            Assert.Equal(52.1, result.Average);
            Assert.Equal(80.5, result.High);
            Assert.Equal(30.0, result.Low);
        }
    }
}
