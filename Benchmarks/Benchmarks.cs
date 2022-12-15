using BenchmarkDotNet.Attributes;
using Shared.Models;
using Shared.Helpers;
using SwitchPatternMatching;

namespace Benchmarks
{
    [MemoryDiagnoser(false)]
    public class PatternMatchingBenchmarks
    {
        private Product _product = Helper.GetRandomProduct();

        [Benchmark]
        public void PatternMatching()
        {
            WithPatternMatching.Print(_product);
        }

        [Benchmark]
        public void WithoutMatching()
        {
            WithoutPatternMatching.Print(_product);
        }
    }
}
