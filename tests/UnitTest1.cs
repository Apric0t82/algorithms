using Algorithms;
using BenchmarkDotNet.Running;

namespace FindUniqueIntegers.Tests;

public class UnitTest1
{

    [Fact]
    public void TestBenchmark() => BenchmarkRunner.Run<Benchmark>();

    [Fact]
    public void TestListIsEmpty()
    {
        // Arrange

        // Act
        var list = UniqueIntegers.WithDictionary(Array.Empty<int>());

        // Assert
        Assert.Empty(list);
    }

    [Theory]
    [MemberData(nameof(UniqueIntegers.Data), MemberType = typeof(UniqueIntegers))]
    public void Test_CanReturnWithExceptingDuplicatesHashSet(int[] array, List<int> expected)
    {
        // Arrange

        // Act
        var list = UniqueIntegers.WithExceptingDuplicatesHashSet(array);

        // Assert
        Assert.Equal(expected, list);
    }

    [Theory]
    [MemberData(nameof(UniqueIntegers.Data), MemberType = typeof(UniqueIntegers))]
    public void Test_CanReturnWithDictionary(int[] array, List<int> expected)
    {
        // Arrange

        // Act
        var list = UniqueIntegers.WithDictionary(array);

        // Assert
        Assert.Equal(expected, list);
    }

    [Theory]
    [MemberData(nameof(UniqueIntegers.SortedData), MemberType = typeof(UniqueIntegers))]
    public void Test_CanReturnWithSortAndLinearScan(int[] array, List<int> expected)
    {
        // Arrange

        // Act
        var list = UniqueIntegers.WithSortAndLinearScan(array);

        // Assert
        Assert.Equal(expected, list);
    }
}