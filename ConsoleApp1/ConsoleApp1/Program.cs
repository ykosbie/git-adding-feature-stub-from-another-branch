using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many fib digits> ");
            var digitsRaw = Console.ReadLine();
            if(int.TryParse(digitsRaw, out var max))
            {
                foreach(var digit in Fib().Take(max))
                {
                    Console.WriteLine(digit);
                }
            }
        }

        private static IEnumerable<long> Fib()
        {
            yield return 1;
            yield return 1;

            var prev = 1;
            var cur = 1;
            while (true)
            {
                var next = prev + cur;
                yield return next;

                prev = cur;
                cur = next;
            }
        }
    }
}
