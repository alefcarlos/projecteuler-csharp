using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public static class Helpers
    {
        /// <summary>
        /// Validadtes if a value is multiple of other number
        /// </summary>
        /// <param name="multiple">The desired multiple.</param>
        /// <param name="value">Value to check.</param>
        /// <returns>Returns true if value is multiple of multiple</returns>
        public static bool IsMultipleOf(int multiple, int value)
        {
            //Check possible DivisionByZero
            if (multiple == 0)
                throw new ArgumentException("O múltiplo deve ser maior do que 0.", nameof(multiple));

            //A number is multiple if the remainder value is 0.
            return (value % multiple) == 0;
        }

        public static int SumOfMuliples(int max, params int[] possibleMultiples)
        {
            int sum = 0;

            //Validate if the number is MultipleOf, then sum it
            for (int value = 1; value < max; value++)
                sum += possibleMultiples.Any(multiple => Helpers.IsMultipleOf(multiple, value)) ? value : 0;

            return sum;
        }

        /// <summary>
        /// Checks if a number is odd
        /// </summary>
        /// <param name="value">Value to check</param>
        /// <returns>Returns true if the value is odd.</returns>
        public static bool IsOdd(int value) => !IsEven(value);

        /// <summary>
        /// Checks if a number is even
        /// </summary>
        /// <param name="value">Value to check</param>
        /// <returns>Returns true if the value is even.</returns>
        public static bool IsEven(int value) => value % 2 == 0;

        /// <summary>
        /// Returns a Fibonacci sequence
        /// </summary>
        /// <param name="maxTerms">Sequence's quantity</param>
        public static List<int> Fibonacci(int maxTerms)
        {
            var result = new List<int> { 1, 2 };

            var p = 2;
            while (p < maxTerms)
            {
                result.Add(result[p - 1] + result[p - 2]);
                p++;
            }

            return result;
        }

        /// <summary>
        /// Returns the sum of all even numbers in a Fibonacci sequence
        /// </summary>
        /// <param name="maxTerms">Sequence's quantity</param>
        public static long SumOfEvenFibonnaci(int maxTerms)
        {
            var fib = Fibonacci(maxTerms);

            return fib.Where(x => IsEven(x)).Sum();
        }

        /// <summary>
        /// Returns the sum of all odd numbers in a Fibonacci sequence
        /// </summary>
        /// <param name="maxTerms">Sequence's quantity</param>
        public static long SumOfOddFibonnaci(int maxTerms)
        {
            var fib = Fibonacci(maxTerms);

            return fib.Where(x => IsOdd(x)).Sum();
        }

        /// <summary>
        /// Find prime numbers in a range of integers usng Sieve of Eratosthenes.
        /// </summary>
        /// <param name="max">The max value.</param>
        /// <returns>Returns a list of integer.</returns>
        public static List<int> EratosthenesSieve(int max)
        {
            if (max < 2)
                return new List<int>();

            if (max == 2)
                return new List<int> { 2 };

            var checkTarget = (int)Math.Ceiling(Math.Sqrt(max));
            var result = new List<int>();

            var range = Enumerable.Range(2, max - 1).ToList();
            var resultRange = Enumerable.Range(2, max - 1).ToList();

            var checkTargetIndex = range.FindIndex(x => x == checkTarget);

            for (int i = 0; i <= checkTargetIndex; i++)
                resultRange.RemoveAll(x => range[i] != x && IsMultipleOf(range[i], x));

            return resultRange;
        }

        /// <summary>
        /// Returs a list of PrimeFactors
        /// Based on https://stackoverflow.com/questions/5872962/prime-factors-in-c-sharp
        /// </summary>
        /// <param name="value">Value to get factors.</param>
        public static List<int> PrimeFactors(int value)
        {
            var retval = new List<int>();
            for (int b = 2; value > 1; b++)
            {
                while (value % b == 0)
                {
                    value /= b;
                    retval.Add(b);
                }
            }
            return retval;
        }

        /// <summary>
        /// Returs a list of PrimeFactors
        /// Based on https://stackoverflow.com/questions/5872962/prime-factors-in-c-sharp
        /// </summary>
        /// <param name="value">Value to get factors.</param>
        public static List<long> PrimeFactors(long value)
        {
            var retval = new List<long>();
            for (long b = 2; value > 1; b++)
            {
                while (value % b == 0)
                {
                    value /= b;
                    retval.Add(b);
                }
            }
            return retval;
        }
    }
}