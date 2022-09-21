namespace TestSealedClassPerformance
{
    public class OpenedClass
    {
        private readonly int SomeValue = 100;

        public int ExampleIntMethod(int value) => SomeValue + value;
    }
}
