using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Algorithms;

BenchmarkRunner.Run<Benchmark>();

[MemoryDiagnoser]
public class Benchmark
{
    private const int _size = 10_000;
    private int[] _array = null!;

    [GlobalSetup]
    public void GlobalSetup() {
        _array = Enumerable.Range(1, _size)
                    .Select((value, index) => index == 5 ||
                                              index == _size * 0.47 ||
                                              index == _size - 1
                                                ? index
                                                : value)
                    .ToArray();
    }


    [Benchmark]
    public List<int> WithDictionary() {
        return UniqueIntegers.WithDictionary(_array);
    }

    [Benchmark]
    public List<int> WithExceptingDuplicatesHashSet() {
        return UniqueIntegers.WithExceptingDuplicatesHashSet(_array);
    }

    [Benchmark]
    public List<int> WithSortAndLinearScan() {
        return UniqueIntegers.WithSortAndLinearScan(_array);
    }

}
