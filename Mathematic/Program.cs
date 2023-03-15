using System;

namespace Mathematic
{
    class Program
    {
        static void Main(string[] args)
        {
            // instance
            Calculator calculator = new Calculator();
            calculator.Sum(5, 6);

            calculator.Sum(3.4, 5.66);

        }
    }
}