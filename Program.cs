using System;

namespace RepeatLesson
{
    public class Program
    {
        public static int[] MakeValley(int[] arr)
        {
            int leftCount = (arr.Length + (arr.Length % 2)) / 2;
            int rightCount = (arr.Length - (arr.Length % 2)) / 2;
            arr = arr.OrderBy(o => o).ToArray();
            Console.WriteLine("Length: " + arr.Length);
            Console.WriteLine("Left Count: " + leftCount);
            Console.WriteLine("Right Count: " + rightCount);

            int[] leftArray = new int[leftCount];
            int[] rightArray = new int[rightCount];
            for (int i = arr.Length - 1; i >= 0; i -= 2)
            {
                leftArray[i / 2] = arr[i];
            }

            for (int i = arr.Length % 2; i < arr.Length; i += 2)
            {
                rightArray[i / 2] = arr[i];
            }

            int[] finalArray = new int[arr.Length];
            for (int i = 0; i < leftArray.Length; i++)
            {
                finalArray[i] = leftArray[i];
            }
            for (int i = leftArray.Length; i < finalArray.Length; i++)
            {
                finalArray[i] = rightArray[i - leftArray.Length];
            }

            return finalArray;
        }
        public static void Main(string[] args)
        {
            // Inputs
            int[] a = new int[] { 14, 10, 8, 1, 1 };
            int[] r = new int[] { 14, 8, 1, 1, 10 };
            MakeValley(a);
        }
    }
}