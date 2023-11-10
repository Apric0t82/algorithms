using Algorithms;

namespace FindUniqueIntegers.Tests;

public class UnitTest1
{

    // TODO test edge cases
    /*
       The list is huge (i.e. several billion numbers or more)
       The list is tiny (0 or 1 items)
       The list is null
       Everything is a duplicate
       Everything is unique
       The list is just the same number repeated many times
    */

    [Fact]
    public void CanReturnListOfUniqueIntegers()
    {
        // Arrange
        var uniqueInts = new UniqueIntegers();
        var array = new int[] {1, 10, -4, 2, 7, 8, 45, -32, 2, 9, -4, 33};

        // Act
        var list = uniqueInts.GetUniqueIntegers(array);

        // Assert
        Assert.Equal("1,10,7,8,45,-32,9,33", string.Join(",", list));
    }

    [Fact]
    public void CanReturnSortedListOfUniqueIntegers()
    {
        // Arrange
        var uniqueInts = new UniqueIntegers();
        var array = new int[] {1, 10, -4, 2, 7, 8, 45, -32, 2, 9, -4, 33};

        // Act
        var list = uniqueInts.GetSortedUniqueIntegers(array);

        // Assert
        Assert.Equal("-32,1,7,8,9,10,33,45", string.Join(",", list));
    }
}