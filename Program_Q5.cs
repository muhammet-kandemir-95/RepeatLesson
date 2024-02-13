using System;

namespace RepeatLesson
{
    public class Program_Q5
    {
        public static void Main_Q5(string[] args)
        {
            // Inputs
            Console.Write("Please enter the numbers count: ");
            int numbersCount = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[numbersCount];
            bool[] numbersChecked = new bool[numbersCount];
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

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int numberToBeCompared = numbers[j];
                    bool numberToBeComparedIsAvailable = numbersChecked[j];

                    if (numberToBeComparedIsAvailable == false)
                    {
                        if (currentNumberToBeChecked == numberToBeCompared) // Here's a match.
                        {
                            numbersChecked[j] = true;
                            isThereAMatch = true;
                        }
                    }
                }

                if (isThereAMatch == true)
                {
                    result++;
                }
            }

            Console.WriteLine("Result: " + result);
        }
    }
}