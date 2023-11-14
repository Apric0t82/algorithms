using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Algorithms;

BenchmarkRunner.Run<Benchmark>();

[MemoryDiagnoser]
public class Benchmark
{
    readonly int[] someNumbers = { 3, 9, 5, 943, 25, 578, 21, -4, 2, 9, 77, 21, 578, -443, 21};

    [Benchmark]
    public List<int> WithDictionary() {
        return UniqueIntegers.WithDictionary(someNumbers);
    }

    [Benchmark]
    public List<int> WithExceptingDuplicatesHashSet() {
        return UniqueIntegers.WithExceptingDuplicatesHashSet(someNumbers);
    }

    [Benchmark]
    public List<int> WithSortAndLinearScan() {
        return UniqueIntegers.WithSortAndLinearScan(someNumbers);
    }

}
