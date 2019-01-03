using System;
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
        public static bool IsMultipleOf(uint multiple, uint value)
        {
            //Check possible DivisionByZero
            if (multiple == 0)
                throw new ArgumentException("O múltiplo deve ser maior do que 0.", nameof(multiple));

            //A number is multiple if the remainder value is 0.
            return (value % multiple) == 0;
        }

        public static uint SumOfMuliples(int quantity, params uint[] possibleMultiples)
        {
            uint sum = 0;

            //Validate if the number is MultipleOf, then sum it
            for (uint value = 1; value < quantity; value++)
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

        /// <summary>
        /// Returns a Fibonacci sequence
        /// </summary>
        /// <param name="maxTerms">Sequence's quantity</param>
        /// <returns>Returns a list of long.</returns>
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

        /// <summary>
        /// Returns the sum of all even numbers in a Fibonacci sequence
        /// </summary>
        /// <param name="maxTerms">Sequence's quantity</param>
        public static long SumOfEvenFibonnaci(long maxTerms)
        {
            var fib = Fibonacci(maxTerms);

            return fib.Where(x => IsEven(x)).Sum();
        }

        /// <summary>
        /// Returns the sum of all odd numbers in a Fibonacci sequence
        /// </summary>
        /// <param name="maxTerms">Sequence's quantity</param>
        public static long SumOfOddFibonnaci(long maxTerms)
        {
            var fib = Fibonacci(maxTerms);

            return fib.Where(x => IsOdd(x)).Sum();
        }
    }
}