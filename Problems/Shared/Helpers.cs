using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems.Shared
{
    public class Helpers
    {
        /// <summary>
        /// Validadtes if a value is multiple of other number
        /// </summary>
        /// <param name="multiple">The desired multiple.</param>
        /// <param name="value">Value to check.</param>
        /// <returns>Returns true if value is multiple of multiple</returns>
        public static bool IsMultipleOf(uint multiple, uint value)
        {
            //Check possible DivisionByZero
            if (multiple == 0)
                throw new ArgumentException("O múltiplo deve ser maior do que 0.", nameof(multiple));

            //A number is multiple if the remainder value is 0.
            return (value % multiple) == 0;
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
        /// Checks if a number is odd
        /// </summary>
        /// <param name="value">Value to check</param>
        /// <returns>Returns true if the value is odd.</returns>
        public static bool IsOdd(long value) => !IsEven(value);

        /// <summary>
        /// Checks if a number is even
        /// </summary>
        /// <param name="value">Value to check</param>
        /// <returns>Returns true if the value is even.</returns>
        public static bool IsEven(long value) => value % 2 == 0;

        public static List<long> Fibonacci(long maxTerms)
        {
            var result = new List<long> { 1, 2 };

            var p = 2;
            while (p < maxTerms)
            {
                result.Add(result[p - 1] + result[p - 2]);
                p++;
            }

            return result;
        }

        public static long SumOfEvenFibonnaci(long maxTerms)
        {
            var fib = Fibonacci(maxTerms);

            return fib.Where(x => IsEven(x)).Sum();
        }

        public static long SumOfOddFibonnaci(long maxTerms)
        {
            var fib = Fibonacci(maxTerms);

            return fib.Where(x => IsOdd(x)).Sum();
        }
    }
}