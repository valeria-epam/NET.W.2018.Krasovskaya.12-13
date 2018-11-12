using System;
using System.Collections.Generic;

namespace FibonacciTask
{
    public static class Fibonacci
    {
        /// <summary>
        /// Generate a sequence of Fibonacci numbers.
        /// </summary>
        public static IEnumerable<int> FibonacciGenerator() => FibonacciGenerator(1, 1);

        /// <summary>
        /// Generate a sequence of Fibonacci numbers.
        /// </summary>
        /// <param name="firstNumber">The first number from which the sequence of numbers will be started.</param>
        /// <param name="secondNumber">The second number from which the sequence of numbers will be started.</param>
        public static IEnumerable<int> FibonacciGenerator(int firstNumber, int secondNumber)
        {
            if (firstNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(firstNumber));
            }

            if (secondNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(secondNumber));
            }

            yield return firstNumber;
            yield return secondNumber;

            int first = firstNumber;
            int second = secondNumber;

            while (true)
            {
                int next = unchecked(first + second);
                if (next <= 0)
                {
                    yield break;
                }

                yield return next;
                first = second;
                second = next;
            }
        }
    }
}