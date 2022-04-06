using SortingAPI.Exceptions;
using SortingAPI.Helpers;
using Xunit;

namespace SortingTests
{
    public class InputOutputHelperTests
    {
        [Theory]
        [InlineData("2 3 1 4 5", new int[] { 2, 3, 1, 4, 5})]
        [InlineData("    2 3 1    4 5   ", new int[] { 2, 3, 1, 4, 5})]
        [InlineData("2", new int[] { 2 })]
        public void CorectInputTest(string data, int[] expectedData)
        {
            var numbers = InputOutputHelper.GetInputAsIntNumbers(data);

            Assert.Equal(expectedData, numbers);
        }

        [Theory]
        [InlineData("2 e3 1 4 r5")]
        [InlineData("")]
        [InlineData("25 43 2")]
        public void IncorrectInputTest(string data)
        {
            Assert.Throws<BusinessLogicException>( () => InputOutputHelper.GetInputAsIntNumbers(data));
        }
    }
}
