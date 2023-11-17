using Algorithms;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters;

BenchmarkRunner.Run<Benchmark>();

internal class BenchmarkConfig : ManualConfig
{
    public BenchmarkConfig()
    {
        AddExporter(MarkdownExporter.GitHub);
    }
}

[Config(typeof(BenchmarkConfig))]
[MemoryDiagnoser]
public class Benchmark
{
    [Params(100, 1_000, 10_000)]
    public int Size { get; set; }

    [Params(DuplicateLocation.None, DuplicateLocation.Beginning, DuplicateLocation.FortySevenPercent, DuplicateLocation.End)]
    public DuplicateLocation DuplicateLocation { get; set; }
    
    private int[] _array = null!;

    [GlobalSetup]
    public void GlobalSetup() {
        _array = GetArray();
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

    private int? GetDuplicateIndex() => DuplicateLocation switch {
        DuplicateLocation.None => default,
        DuplicateLocation.Beginning => 1,
        DuplicateLocation.FortySevenPercent => (int)(Size * 0.47),
        DuplicateLocation.End => Size - 1,
        _ => throw new NotSupportedException()
    };

    private int[] GetArray() {

        var duplicateIndex = GetDuplicateIndex();

        var items = duplicateIndex.HasValue 
            ? Enumerable
                .Range(1, Size)
                .Select((value, index) => index == duplicateIndex.Value ? index : value)
            : Enumerable
                .Range(1, Size);

        return items.ToArray();
    }
}
