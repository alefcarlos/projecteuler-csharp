using Shouldly;
using System;
using System.Linq;
using Xunit;

namespace Problems.Tests
{
    public class HelpersTest
    {

        [Theory]
        [InlineData(3, 3)]
        [InlineData(3, 6)]
        [InlineData(3, 9)]
        public void Multiple3_ShouldSuccess(uint multiple, uint value)
        {
            Helpers.IsMultipleOf(multiple, value).ShouldBeTrue();
        }

        [Theory]
        [InlineData(5, 5)]
        [InlineData(5, 10)]
        [InlineData(5, 15)]
        public void Multiple5_ShouldSuccess(uint multiple, uint value)
        {
            Helpers.IsMultipleOf(multiple, value).ShouldBeTrue();
        }

        [Theory]
        [InlineData(3, 1)]
        [InlineData(3, 5)]
        public void Multiple3_ShouldFail(uint multiple, uint value)
        {
            Helpers.IsMultipleOf(multiple, value).ShouldBeFalse();
        }

        [Fact]
        public void MultpleOf_ShouldThrowExpcetion()
        {

            Should.Throw<ArgumentException>(() => {
                Helpers.IsMultipleOf(0, 3).ShouldBeFalse();
            });
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(50)]
        public void EvenNumbers_ShouldSuccess(int number)
        {
            Helpers.IsEven(number).ShouldBeTrue();
        }

        [Fact]
        public void EventNumber_ShouldFail()
        {
            Helpers.IsEven(3).ShouldBeFalse();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]
        public void OddNumbers_ShouldSuccess(int number)
        {
            Helpers.IsOdd(number).ShouldBeTrue();
        }

        [Fact]
        public void OddNumber_ShouldFail()
        {
            Helpers.IsOdd(2).ShouldBeFalse();
        }

        [Theory]
        [InlineData(3, 6)]
        [InlineData(6, 32)]
        public void SumOfFibonacci_ShouldSuccess(long maxTerms, int result)
        {
            //Arrange
            var sum = Helpers.Fibonacci(maxTerms).Sum();

            //Assert
            sum.ShouldBe(result);
        }
    }
}