# Find Unique Numbers

Given an array of numbers, return a list of all the numbers that are unique within that array (i.e. they aren't duplicated).


Example:

Input: [1, 10, -4, 2, 7, 8, 45, -32, 2, 9, -4, 33]

Output: [1, 10, 7, 8, 45, -32, 9, 33]


```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.19045.3693/22H2/2022Update)
Intel Core i7-9750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 7.0.404
  [Host]     : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2


```
| Method                         | Size  | DuplicateLocation | Mean         | Error        | StdDev       | Median       | Gen0     | Gen1     | Gen2     | Allocated |
|------------------------------- |------ |------------------ |-------------:|-------------:|-------------:|-------------:|---------:|---------:|---------:|----------:|
| **WithDictionary**                 | **100**   | **None**              |   **2,438.6 ns** |     **48.22 ns** |    **102.75 ns** |   **2,393.3 ns** |   **1.3657** |   **0.0267** |        **-** |   **8.38 KB** |
| WithExceptingDuplicatesHashSet | 100   | None              |   3,579.6 ns |     71.49 ns |    153.89 ns |   3,528.6 ns |   1.4687 |   0.0191 |        - |      9 KB |
| WithSortAndLinearScan          | 100   | None              |     717.2 ns |     13.61 ns |     13.36 ns |     712.8 ns |   0.1879 |        - |        - |   1.16 KB |
| **WithDictionary**                 | **100**   | **Beginning**         |   **2,526.9 ns** |     **50.57 ns** |    **130.53 ns** |   **2,515.4 ns** |   **1.3657** |   **0.0267** |        **-** |   **8.38 KB** |
| WithExceptingDuplicatesHashSet | 100   | Beginning         |   3,697.3 ns |     70.79 ns |    120.21 ns |   3,742.9 ns |   1.4725 |   0.0191 |        - |   9.04 KB |
| WithSortAndLinearScan          | 100   | Beginning         |     703.6 ns |     10.07 ns |      8.41 ns |     700.5 ns |   0.1879 |        - |        - |   1.16 KB |
| **WithDictionary**                 | **100**   | **FortySevenPercent** |   **2,557.3 ns** |     **51.03 ns** |    **129.90 ns** |   **2,541.7 ns** |   **1.3657** |   **0.0267** |        **-** |   **8.38 KB** |
| WithExceptingDuplicatesHashSet | 100   | FortySevenPercent |   3,721.1 ns |     74.24 ns |    199.45 ns |   3,636.1 ns |   1.4725 |   0.0191 |        - |   9.04 KB |
| WithSortAndLinearScan          | 100   | FortySevenPercent |     741.8 ns |     14.85 ns |     37.26 ns |     747.3 ns |   0.1879 |        - |        - |   1.16 KB |
| **WithDictionary**                 | **100**   | **End**               |   **2,607.5 ns** |     **51.00 ns** |    **143.83 ns** |   **2,553.8 ns** |   **1.3657** |   **0.0267** |        **-** |   **8.38 KB** |
| WithExceptingDuplicatesHashSet | 100   | End               |   3,563.4 ns |     15.08 ns |     12.59 ns |   3,562.3 ns |   1.4725 |   0.0153 |        - |   9.04 KB |
| WithSortAndLinearScan          | 100   | End               |     760.9 ns |     15.12 ns |     32.55 ns |     757.2 ns |   0.1879 |        - |        - |   1.16 KB |
| **WithDictionary**                 | **1000**  | **None**              |  **22,545.3 ns** |    **449.09 ns** |  **1,167.26 ns** |  **22,187.7 ns** |  **12.9700** |   **2.5635** |        **-** |  **79.68 KB** |
| WithExceptingDuplicatesHashSet | 1000  | None              |  34,739.9 ns |    692.05 ns |  1,671.37 ns |  35,058.3 ns |  13.4888 |   2.1973 |        - |  83.06 KB |
| WithSortAndLinearScan          | 1000  | None              |   8,552.1 ns |    181.51 ns |    514.92 ns |   8,377.6 ns |   1.3275 |   0.0153 |        - |   8.23 KB |
| **WithDictionary**                 | **1000**  | **Beginning**         |  **22,505.9 ns** |    **394.78 ns** |    **369.27 ns** |  **22,291.3 ns** |  **12.9700** |   **2.5635** |        **-** |  **79.68 KB** |
| WithExceptingDuplicatesHashSet | 1000  | Beginning         |  31,427.7 ns |    352.96 ns |    275.57 ns |  31,347.6 ns |  13.4888 |   2.1973 |        - |   83.1 KB |
| WithSortAndLinearScan          | 1000  | Beginning         |   8,345.0 ns |    163.38 ns |    277.43 ns |   8,320.5 ns |   1.3275 |   0.0153 |        - |   8.23 KB |
| **WithDictionary**                 | **1000**  | **FortySevenPercent** |  **23,279.3 ns** |    **445.95 ns** |  **1,235.71 ns** |  **22,823.9 ns** |  **12.9395** |   **2.5635** |        **-** |  **79.68 KB** |
| WithExceptingDuplicatesHashSet | 1000  | FortySevenPercent |  32,627.3 ns |    642.04 ns |  1,190.06 ns |  32,323.8 ns |  13.4888 |   2.1973 |        - |   83.1 KB |
| WithSortAndLinearScan          | 1000  | FortySevenPercent |   8,216.2 ns |    124.19 ns |    110.09 ns |   8,180.2 ns |   1.3275 |   0.0153 |        - |   8.23 KB |
| **WithDictionary**                 | **1000**  | **End**               |  **22,528.2 ns** |    **354.07 ns** |    **295.66 ns** |  **22,431.6 ns** |  **12.9700** |   **2.5635** |        **-** |  **79.68 KB** |
| WithExceptingDuplicatesHashSet | 1000  | End               |  32,015.2 ns |    489.96 ns |    481.21 ns |  31,935.7 ns |  13.4888 |   2.1973 |        - |   83.1 KB |
| WithSortAndLinearScan          | 1000  | End               |   8,295.8 ns |    164.26 ns |    245.86 ns |   8,235.2 ns |   1.3275 |   0.0153 |        - |   8.23 KB |
| **WithDictionary**                 | **10000** | **None**              | **354,739.3 ns** |  **5,661.51 ns** |  **6,057.76 ns** | **352,647.6 ns** | **124.5117** | **124.5117** | **124.5117** | **785.65 KB** |
| WithExceptingDuplicatesHashSet | 10000 | None              | 478,233.7 ns |  9,435.98 ns | 19,061.15 ns | 485,615.2 ns | 133.3008 | 133.3008 | 133.3008 | 812.54 KB |
| WithSortAndLinearScan          | 10000 | None              |  98,092.3 ns |  1,629.11 ns |  2,536.32 ns |  97,112.9 ns |  20.7520 |   4.0283 |        - | 128.32 KB |
| **WithDictionary**                 | **10000** | **Beginning**         | **357,311.0 ns** |  **7,067.20 ns** | **10,792.36 ns** | **352,241.3 ns** | **124.5117** | **124.5117** | **124.5117** | **785.65 KB** |
| WithExceptingDuplicatesHashSet | 10000 | Beginning         | 521,334.8 ns | 19,869.47 ns | 57,644.94 ns | 511,058.6 ns | 132.8125 | 132.8125 | 132.8125 | 812.58 KB |
| WithSortAndLinearScan          | 10000 | Beginning         | 103,449.6 ns |  2,063.74 ns |  4,615.85 ns | 100,900.6 ns |  20.7520 |   4.0283 |        - | 128.32 KB |
| **WithDictionary**                 | **10000** | **FortySevenPercent** | **363,836.3 ns** |  **6,932.79 ns** | **11,772.41 ns** | **358,051.7 ns** | **124.5117** | **124.5117** | **124.5117** | **785.65 KB** |
| WithExceptingDuplicatesHashSet | 10000 | FortySevenPercent | 469,751.6 ns |  9,153.55 ns | 11,241.38 ns | 465,067.0 ns | 133.3008 | 133.3008 | 133.3008 | 812.58 KB |
| WithSortAndLinearScan          | 10000 | FortySevenPercent | 102,593.6 ns |  2,047.69 ns |  5,174.78 ns | 101,494.8 ns |  20.7520 |   4.0283 |        - | 128.32 KB |
| **WithDictionary**                 | **10000** | **End**               | **353,482.8 ns** |  **6,615.74 ns** | **12,903.50 ns** | **346,561.8 ns** | **124.5117** | **124.5117** | **124.5117** | **785.65 KB** |
| WithExceptingDuplicatesHashSet | 10000 | End               | 483,711.9 ns |  9,614.93 ns | 18,524.70 ns | 493,619.8 ns | 133.3008 | 133.3008 | 133.3008 | 812.58 KB |
| WithSortAndLinearScan          | 10000 | End               | 102,773.4 ns |  2,034.48 ns |  5,178.40 ns | 101,826.0 ns |  20.7520 |   4.0283 |        - | 128.32 KB |
