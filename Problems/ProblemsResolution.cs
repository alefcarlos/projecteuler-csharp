using Problems.Shared;
using System.Linq;

namespace Problems
{
    public static class ProblemsResolution
    {
        public static uint SumOfMuliples(int quantity, params uint[] possibleMultiples)
        {
            uint sum = 0;

            //Validate if the number is MultipleOf, then sum it
            for (uint value = 1; value < quantity; value++)
                sum += possibleMultiples.Any(multiple => Helpers.IsMultipleOf(multiple, value)) ? value : 0;

            return sum;
        }
    }
}
