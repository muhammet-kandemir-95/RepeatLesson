using System;

namespace RepeatLesson
{
    public class Program_Q6
    {
        public static void Main_Q6(string[] args)
        {
            // Inputs
            Console.Write("Please enter the numbers count: ");
            int numbersCount = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[numbersCount];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Please enter " + (i + 1) + ". number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Outputs
            int result = 0;

            // Act
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumberToBeChecked = numbers[i];

                bool isThereAMatch = false;
                for (int j = 0; j < numbers.Length; j++)
                {
                    int numberToBeCompared = numbers[j];

                    if (i != j && currentNumberToBeChecked == numberToBeCompared) // Here's a match.
                    {
                        isThereAMatch = true;
                        break;
                    }
                }

                if (isThereAMatch == false)
                {
                    result++;
                }
            }

            Console.WriteLine("Result: " + result);
        }
    }
}