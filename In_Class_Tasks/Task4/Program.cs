using System.Diagnostics.CodeAnalysis;

namespace Task4
{
    internal class Program
    {
        // Main method: entry point of the program
        static void Main(string[] args)
        {
            // Declare and initialize an array of integers
            int[] intArray = { 14, 28, 35, 42, 51, 68 };

            // Print label for array elements
            Console.Write($"Array elements: ");

            // Call method to print array contents on the same line
            PrintArray(intArray);

            // Print label for average value
            Console.Write($"\nThe average is: ");

            // Call method to calculate and print the average of the array
            Console.Write(FindAverage(intArray));

            // Prompt user to enter a number to search for in the array
            Console.Write("\nEnter a number to search for: ");

            // Read user input, convert it to an integer, and store it
            int searchForInt = int.Parse(Console.ReadLine());

            // Call method to search for the entered number in the array
            SearchNumber(searchForInt, intArray);
        }

        // Method to print all elements of an integer array on the same line
        static void PrintArray(int[] intArray)
        {
            // Loop through each element in the array
            for (int i = 0; i < intArray.Length; i++)
            {
                // Print each element followed by a space
                Console.Write(intArray[i] + " ");
            }
        }

        // Method to calculate and return the average of an integer array
        static double FindAverage(int[] intArray)
        {
            // Initialize sum as a double to ensure floating-point division
            double Sum = 0;

            // Loop through each element and add it to the sum
            for (int i = 0; i < intArray.Length; i++)
            {
                Sum += intArray[i];
            }

            // Calculate average by dividing sum by number of elements
            double intAvg = Sum / intArray.Length;

            // Return the computed average
            return intAvg;
        }

        // Method to search for a specific integer in the array
        static void SearchNumber(int searchForInt, int[] intArray)
        {
            // Loop through each element in the array
            for (int i = 0; i < intArray.Length; i++)
            {
                // If the current element matches the search value
                if (intArray[i] == (searchForInt))
                {
                    // Print confirmation that the value was found
                    Console.WriteLine($"{searchForInt} was found in the array!");
                }
            }
        }
    }
}
