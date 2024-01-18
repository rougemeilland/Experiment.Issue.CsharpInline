using System;
using ClassLibrary;

namespace ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = 10;
            var y = 2;
            var result = SimpleCalc.Add10(x, y); // <= Set a breakpoint here. And track it on the "Disassembly" window.
            Console.WriteLine($"{x} + {y} * 10 => {result}");
        }
    }
}
