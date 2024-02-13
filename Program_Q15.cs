using System;

namespace RepeatLesson
{
    public class Program_Q15
    {
        public static void Main_Q15(string[] args)
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

            Console.Write("New value position: ");
            int newNumberIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            // Act
            int[] newNumbers = new int[numbersCount - 1];

            for (int i = 0; i < newNumberIndex; i++)
            {
                newNumbers[i] = numbers[i];
            }

            for (int i = newNumberIndex + 1; i < numbers.Length; i++)
            {
                newNumbers[i - 1] = numbers[i];
            }

            // Outputs
            for (int i = 0; i < newNumbers.Length; i++)
            {
                Console.WriteLine("Number " + (i + 1) + ": " + newNumbers[i]);
            }
        }
    }
}