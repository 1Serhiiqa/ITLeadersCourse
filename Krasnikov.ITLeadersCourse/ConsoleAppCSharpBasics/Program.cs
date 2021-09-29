using System;
using static ConsoleAppCSharpBasics.IO.Output;

namespace ConsoleAppCSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            int intVar = 1;
            int intVar2 = 2;

            Out.WriteLine(intVar2);
            Out.Write(intVar);

            intVar = intVar2 = 3;

            Out.WriteLine(intVar2);
            Out.Write(intVar);

            //double doubleVar1, doubleVar2 = 2.3;

            //Out.WriteLine(doubleVar1);
            //Out.WriteLine(doubleVar2);

            Out.WriteLine(double.MinValue);
            Out.WriteLine(decimal.MaxValue);
        }
    }
}
