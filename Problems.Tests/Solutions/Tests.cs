using Shouldly;
using Xunit;

namespace Problems.Tests.Solutions
{
    public class Tests
    {
        /// <summary>
        /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        //  Find the sum of all the multiples of 3 or 5 below 1000.
        /// </summary>
        [Theory]
        [InlineData(10, new uint[] { 3, 5 }, 23)]
        [InlineData(10, new uint[] { 3 }, 18)]
        [InlineData(1000, new uint[] { 3, 5 }, 233168)]
        public void SumOfMultiples_ShouldSuccess(int maxAmout, uint[] possibleMultiples, uint result)
        {
            ProblemsResolution.SumOfMuliples(maxAmout, possibleMultiples).ShouldBe(result);
        }
    }
}
