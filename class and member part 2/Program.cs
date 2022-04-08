using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMathod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();

            Console.WriteLine("Minimun #1: {0}", numbers.FindMinimum(3, 1));
            Console.WriteLine("Minimun #1: {0}", numbers.FindMinimum(3, 2, 4));
            Console.WriteLine();
            Console.WriteLine("Maximum #1: {0}", numbers.FindMaximum(3, 1));
            Console.WriteLine("Maximum #1: {0}", numbers.FindMaximum(3, 2, 4));

            Console.ReadKey();
        }
    }
}
