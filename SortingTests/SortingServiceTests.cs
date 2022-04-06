using SortingAPI.Services;
using Xunit;

namespace SortingTests
{
    public class SortingServiceTests
    {
        private readonly ISortingService _sortingService;

        public SortingServiceTests()
        {
            _sortingService = new SortingService();
        }

        [Theory]
        [InlineData(new int[] { 1 }, new int[] { 1 })]
        [InlineData(new int[] { 4, 9, 1, 8, 2 }, new int[] { 1, 2, 4, 8, 9 })]
        [InlineData(new int[] { 4, 9, 1, 8, 2, 6, 3, 2, 10 }, new int[] { 1, 2, 2, 3, 4, 6, 8, 9, 10 })]
        public void NumberSortingTest(int[] numbers, int[] expectedSortedNumbers)
        {
            var sortedNumbers = _sortingService.SortNumbers(numbers);

            Assert.Equal(expectedSortedNumbers, sortedNumbers);
        }
    }
}
