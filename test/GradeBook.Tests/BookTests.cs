using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact] //attribute
        public void BookCalculatesAnAverageGrade()
        {
            //ARRANGE - put together all test data
            //          and value that we are gonna to use
            
            var book = new Book("");
            book.AddGrade(13.1);
            book.AddGrade(54.1);
            book.AddGrade(32.5);

            //ACT - do smething to produce a result,
            //      the actual result
            var result = book.GetStatistics();
            
            
            //ASSERT - assert something about the value
            //         that was computed inside of ACT
            //Equal(expectedValue, actualValue) -> true if match
            Assert.Equal(33.2, result.Average, 1);
            Assert.Equal(54.1, result.High, 1);
            Assert.Equal(13.1, result.Low, 1);

        }
    }
}

