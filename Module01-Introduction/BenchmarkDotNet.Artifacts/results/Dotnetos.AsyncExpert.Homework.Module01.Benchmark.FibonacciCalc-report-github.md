``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.26100
13th Gen Intel Core i7-1360P, 1 CPU, 16 logical and 12 physical cores
.NET Core SDK=9.0.205
  [Host]     : .NET Core 9.0.6 (CoreCLR 9.0.625.26613, CoreFX 9.0.625.26613), X64 RyuJIT
  DefaultJob : .NET Core 9.0.6 (CoreCLR 9.0.625.26613, CoreFX 9.0.625.26613), X64 RyuJIT


```
|                   Method |  n |              Mean |           Error |          StdDev | Ratio | Code Size | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------- |--- |------------------:|----------------:|----------------:|------:|----------:|------:|------:|------:|----------:|
|                **Recursive** | **15** |      **1,569.641 ns** |      **31.2285 ns** |      **37.1753 ns** | **1.000** |     **165 B** |     **-** |     **-** |     **-** |         **-** |
| RecursiveWithMemoization | 15 |          3.128 ns |       0.0521 ns |       0.0488 ns | 0.002 |     495 B |     - |     - |     - |         - |
|                Iterative | 15 |          8.527 ns |       0.1715 ns |       0.1684 ns | 0.005 |      60 B |     - |     - |     - |         - |
|                          |    |                   |                 |                 |       |           |       |       |       |           |
|                **Recursive** | **35** | **18,936,385.045 ns** | **229,636.5549 ns** | **203,566.8246 ns** | **1.000** |     **165 B** |     **-** |     **-** |     **-** |       **2 B** |
| RecursiveWithMemoization | 35 |          3.043 ns |       0.0382 ns |       0.0357 ns | 0.000 |     495 B |     - |     - |     - |         - |
|                Iterative | 35 |         20.162 ns |       0.3587 ns |       0.4271 ns | 0.000 |      60 B |     - |     - |     - |         - |
