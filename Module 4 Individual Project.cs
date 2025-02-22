using System;

namespace DivisionConversionExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for two numbers as strings.
            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();
            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();

            try
            {
                // Convert the string inputs to integers.
                int number1 = Convert.ToInt32(input1);
                int number2 = Convert.ToInt32(input2);

                // Perform division using a helper method.
                int result = Divide(number1, number2);
                Console.WriteLine($"The result of dividing {number1} by {number2} is: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: One or both inputs are not in a valid numeric format.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: One or both numbers are too large or too small for an Int32.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        /// <summary>
        /// Divides two integers.
        /// </summary>
        /// <param name="dividend">The number to be divided.</param>
        /// <param name="divisor">The number by which to divide.</param>
        /// <returns>The quotient of the division.</returns>
        static int Divide(int dividend, int divisor)
        {
            return dividend / divisor;
        }
    }
}
