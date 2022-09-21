using BenchmarkDotNet.Attributes;

namespace TestSealedClassPerformance
{
    [MemoryDiagnoser(false)]
    public class Benchmarks
    {
        private readonly OpenedClass openedClass = new();
        private readonly SealedClass sealedClass = new();

        [Benchmark]
        public int OpenedIntMethod() => openedClass.ExampleIntMethod(100500) + 200500;

        [Benchmark]
        public int SealedIntMethod() => sealedClass.ExampleIntMethod(100500) + 200500;
    }
}
