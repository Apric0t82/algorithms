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
    public void TestListIsEmpty(){
        // Arrange
        var uniqueInts = new UniqueIntegers();

        // Act
        var list = UniqueIntegers.WithDictionary(Array.Empty<int>());

        // Assert
        Assert.Empty(list);
    }

    [Theory]
    [InlineData(new[] {1, 10, -4, 2, 7, 8, 45, -32, 2, 9, -4, 33}, "1,10,7,8,45,-32,9,33")]
    [InlineData(new[] {17, 5, 25, 26, 0, 8}, "17,5,25,26,0,8")]
    public void CanReturnHashSetOfUniqueIntegers(int[] array, string expected)
    {
        // Arrange
        var uniqueInts = new UniqueIntegers();

        // Act
        var list = UniqueIntegers.WithExceptingDuplicatesHashSet(array);

        // Assert
        Assert.Equal(expected, string.Join(",", list));
    }

    [Theory]
    [InlineData(new[] {1, 10, -4, 2, 7, 8, 45, -32, 2, 9, -4, 33}, "1,10,7,8,45,-32,9,33")]
    [InlineData(new[] {17, 5, 25, 26, 0, 8}, "17,5,25,26,0,8")]
    public void CanReturnListOfUniqueIntegers(int[] array, string expected)
    {
        // Arrange
        var uniqueInts = new UniqueIntegers();

        // Act
        var list = UniqueIntegers.WithDictionary(array);

        // Assert
        Assert.Equal(expected, string.Join(",", list));
    }

    [Theory]
    [InlineData(new[] {1, 10, -4, 2, 7, 8, 45, -32, 2, 9, -4, 33}, "-32,1,7,8,9,10,33,45")]
    [InlineData(new[] {6,-2,1,3,-42,85,-140}, "-140,-42,-2,1,3,6,85")]
    public void CanReturnSortedListOfUniqueIntegers(int[] array, string expected)
    {
        // Arrange
        var uniqueInts = new UniqueIntegers();

        // Act
        var list = UniqueIntegers.WithSortAndLinearScan(array);

        // Assert
        Assert.Equal(expected, string.Join(",", list));
    }
}