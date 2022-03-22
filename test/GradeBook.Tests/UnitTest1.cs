using Xunit;

namespace GradeBook.Tests;

public class UnitTest1
{
    [Fact] //attribute
    public void Test1()
    {
        //ARRANGE - put together all test data
        //          and value that we are gonna to use
        var x = 5;
        var y = 2;
        var expected = 7;

        //ACT - do smething to produce a result,
        //      the actual result
        var actual = x + y;

        //ASSERT - assert something about the value
        //         that was computed inside of ACT
        //Equal(expectedValue, actualValue) -> true if match
        Assert.Equal(expected, actual);
    }
}