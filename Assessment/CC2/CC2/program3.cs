
using System;
public class Program3
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter a number:");
            
            int number = int.Parse(Console.ReadLine());

            ValidateNumber(number);

            Console.WriteLine($"Number {number} is valid (non-negative).");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($" every exception should be will caught: {ex.Message}");
            Console.ReadLine();
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            

            Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected exception caught: {ex.Message}");
            Console.ReadLine();
        }
    }

    public static void ValidateNumber(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Number cannot be negative.");
        }
    }
    
}
