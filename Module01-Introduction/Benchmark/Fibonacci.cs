using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace Dotnetos.AsyncExpert.Homework.Module01.Benchmark
{
    [DisassemblyDiagnoser(exportCombinedDisassemblyReport: true)]
    [MemoryDiagnoser]
    public class FibonacciCalc
    {
        private Dictionary<ulong, ulong> _memo;
        
        // HOMEWORK:
        // 1. Write implementations for RecursiveWithMemoization and Iterative solutions
        // 2. Add MemoryDiagnoser to the benchmark
        // 3. Run with release configuration and compare results
        // 4. Open disassembler report and compare machine code
        // 
        // You can use the discussion panel to compare your results with other students

        [GlobalSetup(Target = nameof(RecursiveWithMemoization))]
        public void SetupMemoization()
        {
            _memo = new Dictionary<ulong, ulong>();
        }

        [Benchmark(Baseline = true)]
        [ArgumentsSource(nameof(Data))]
        public ulong Recursive(ulong n)
        {
            if (n == 1 || n == 2) return 1;
            return Recursive(n - 2) + Recursive(n - 1);
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public ulong RecursiveWithMemoization(ulong n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            if (_memo.TryGetValue(n, out ulong value))
            {
                return value;
            }

            var result = RecursiveWithMemoization(n - 1) + RecursiveWithMemoization(n - 2); 

            _memo.Add(n, result);

            return result;
        }
        
        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public ulong Iterative(ulong n)
        {
            ulong a = 0;
            ulong b = 1;
            
            for (ulong i = 2; i <= n; i++)
            {
                ulong temp = a + b;
                a = b;
                b = temp;
            }

            return b;
        }

        public IEnumerable<ulong> Data()
        {
            yield return 15;
            yield return 35;
        }
    }
}
