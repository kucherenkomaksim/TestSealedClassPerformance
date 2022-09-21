namespace TestSealedClassPerformance
{
    public sealed class SealedClass
    {
        private readonly int SomeValue = 100;

        public int ExampleIntMethod(int value) => SomeValue + value;
    }
}
