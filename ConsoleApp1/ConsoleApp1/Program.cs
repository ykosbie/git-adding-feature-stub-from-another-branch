﻿using ConsoleApp1.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var loggerFactory = new DefaultLoggerFactory();
            var logger = loggerFactory.GetLogger();

            Console.Write("Name> ");
            var name = Console.ReadLine();

            logger.Log($"Hello {name}!");
            
            Console.Write("How many fib digits> ");
            var digitsRaw = Console.ReadLine();
            if(int.TryParse(digitsRaw, out var max))
            {
                logger.Log($"Will show {max} digits of fibo");
                foreach(var digit in Fib().Take(max))
                {
                    Console.WriteLine(digit);
                }
            }
            else
            {
                logger.Log($"Failed to parse {digitsRaw}, not a valid int");
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
