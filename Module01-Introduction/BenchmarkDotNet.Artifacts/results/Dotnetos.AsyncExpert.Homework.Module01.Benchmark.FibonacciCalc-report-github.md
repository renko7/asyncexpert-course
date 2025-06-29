``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.26100
13th Gen Intel Core i7-1360P, 1 CPU, 16 logical and 12 physical cores
.NET Core SDK=9.0.205
  [Host]     : .NET Core 9.0.6 (CoreCLR 9.0.625.26613, CoreFX 9.0.625.26613), X64 RyuJIT
  DefaultJob : .NET Core 9.0.6 (CoreCLR 9.0.625.26613, CoreFX 9.0.625.26613), X64 RyuJIT


```
|                   Method |  n |              Mean |           Error |          StdDev | Ratio | Code Size | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------- |--- |------------------:|----------------:|----------------:|------:|----------:|------:|------:|------:|----------:|
|                **Recursive** | **15** |      **1,154.137 ns** |      **16.8615 ns** |      **15.7723 ns** | **1.000** |     **165 B** |     **-** |     **-** |     **-** |         **-** |
| RecursiveWithMemoization | 15 |          2.978 ns |       0.0310 ns |       0.0259 ns | 0.003 |     495 B |     - |     - |     - |         - |
|                Iterative | 15 |          8.202 ns |       0.0823 ns |       0.0729 ns | 0.007 |      60 B |     - |     - |     - |         - |
|                          |    |                   |                 |                 |       |           |       |       |       |           |
|                **Recursive** | **35** | **21,310,658.542 ns** | **260,498.2780 ns** | **243,670.2509 ns** | **1.000** |     **165 B** |     **-** |     **-** |     **-** |      **10 B** |
| RecursiveWithMemoization | 35 |          3.063 ns |       0.0310 ns |       0.0290 ns | 0.000 |     495 B |     - |     - |     - |         - |
|                Iterative | 35 |         19.603 ns |       0.1450 ns |       0.1286 ns | 0.000 |      60 B |     - |     - |     - |         - |
