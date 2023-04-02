namespace ListArray
{
    internal class Program
    {
        public static List<int> SortAndTrackIndex(List<int> numbers, out int[] indexArray)
        {
            // Create a copy of the original list
            List<int> sortedNumbers = new List<int>(numbers);

            // Sort the copy of the list
            sortedNumbers.Sort();

            // Create an index array to track the original order of the numbers
            indexArray = new int[numbers.Count];
            for (int i = 0; i < numbers.Count; i++)
            {
                indexArray[i] = numbers.IndexOf(sortedNumbers[i]);
            }

            // Return the sorted list
            return sortedNumbers;
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 3, 4, 7, 1, 2, 15 };
            List<int> sortedNumbers = SortAndTrackIndex(numbers, out int[] indexArray);
            foreach (int number in sortedNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // Print the index array
            foreach (int index in indexArray)
            {
                Console.Write(index + " ");
            }
            Console.WriteLine();
        }
    }
}