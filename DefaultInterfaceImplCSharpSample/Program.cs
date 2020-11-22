using System;

namespace DefaultInterfaceImplCSharpSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.Sum(3, 4));

            Console.WriteLine(calculator.Sum(3, 4, new NumberManagerDefaultImpl()));

            Console.WriteLine(calculator.Sum(3, 4, new NumberManagerCustomImpl()));
        }
    }

    public class Calculator
    {
        public int Sum(int n1, int n2)
        {
            return n1 + n2;
        }

        public int Sum(int n1, int n2, INumberManager numberManager)
        {
            n1 = numberManager.Change(n1);
            n2 = numberManager.Change(n2);

            return n1 + n2;
        }
    }

    public interface INumberManager
    {
        public int Change(int input)
        {
            return input * 2;
        }
    }

    public class NumberManagerCustomImpl : INumberManager
    {
        public int Change(int input)
        {
            return input * 3;
        }
    }

    public class NumberManagerDefaultImpl : INumberManager
    {

    }
}
