using SortingAPI.Exceptions;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SortingAPI.Helpers
{
    public class InputOutputHelper
    {
        public static IEnumerable<int> GetInputAsIntNumbers(string input)
        {
            if (input.Length == 0)
                throw new BusinessLogicException("Empty input!");

            var inputAsStringNumbers = Regex.Split(input.Trim(), @"\s+");

            var numbers = new int[inputAsStringNumbers.Length];
            var index = 0;

            foreach (var item in inputAsStringNumbers)
            {
                if(!int.TryParse(item, out var number)) 
                    throw new BusinessLogicException($"{item} is not a valid number!");

                if (number < 1 || number > 10)
                    throw new BusinessLogicException($"{item} is not in range [1-10]!");

                numbers[index] = number;
                index++;
            }

            return numbers;
        }
    }
}
