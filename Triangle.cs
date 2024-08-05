using System;

class Triangle
{
    static void Main()
    {
        // Get the height of the triangle from the user
        Console.Write("Enter the height of the triangle: ");
        string input = Console.ReadLine();

        // Try to parse the input as an integer
        if (int.TryParse(input, out int height) && height > 0)
        {
            PrintTriangle(height);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
    }

    static void PrintTriangle(int height)
    {
        for (int i = 1; i <= height; i++)
        {
            // Print a row of '*' characters
            for (int j = 1; j <= i; j++)
            {
                Console.Write('*');
            }
            // Move to the next line
            Console.WriteLine();
        }
    }
}
