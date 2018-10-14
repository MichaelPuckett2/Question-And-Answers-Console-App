using System;

namespace Question_Answer_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Test();

            test.Print();
            ((ITestA)test).Print();
            ((ITestB)test).Print();

            Console.ReadKey();
        }

        // OUTPUT
        // Test
        // ITestA
        // ITestB
    }

    public interface ITestA
    {
        void Print();
    }

    public interface ITestB
    {
        void Print();
    }

    public class Test : ITestA, ITestB
    {
        public void Print() => Console.WriteLine(nameof(Test));
        void ITestA.Print() => Console.WriteLine(nameof(ITestA));
        void ITestB.Print() => Console.WriteLine(nameof(ITestB));
    }
}