

namespace Interfaces
{
    internal class Squares
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public IEnumerable<int> Numbers(int begin, int end)
        {
            for (int i = begin; i <= end; i++)
            {
                if (i < 1 || i > numbers.Length)
                    yield break;
                yield return numbers[i - 1] * numbers[i - 1];
            }
        }

    }
}
