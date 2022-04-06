namespace SortingAPI.Services
{
    public class SortingService : ISortingService
    {
        public int[] SortNumbers(int[] numbers)
        {
            if (numbers.Length == 0) return numbers;

            int temp;

            for (int i = numbers.Length-1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] > numbers[j+1])
                    {
                        temp = numbers[j+1];
                        numbers[j+1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            return numbers;
        }
    }
}
