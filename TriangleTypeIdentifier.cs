using System;

class TriangleTypeIdentifier
{
    public static void Run()
    {
        Console.WriteLine("\n--- Triangle Type Identifier ---");
        
        Console.Write("Enter length of side 1: ");
        double side1 = GetPositiveNumber();
        
        Console.Write("Enter length of side 2: ");
        double side2 = GetPositiveNumber();
        
        Console.Write("Enter length of side 3: ");
        double side3 = GetPositiveNumber();
        
        if (IsValidTriangle(side1, side2, side3))
        {
            string triangleType = DetermineTriangleType(side1, side2, side3);
            Console.WriteLine($"Triangle Type: {triangleType}");
        }
        else
        {
            Console.WriteLine("These sides do not form a valid triangle.");
        }
    }
    
    private static double GetPositiveNumber()
    {
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double number) && number > 0)
            {
                return number;
            }
            Console.Write("Invalid input. Please enter a positive number: ");
        }
    }
    
    private static bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
    
    private static string DetermineTriangleType(double a, double b, double c)
    {
        if (a == b && b == c)
        {
            return "Equilateral";
        }
        else if (a == b || a == c || b == c)
        {
            return "Isosceles";
        }
        else
        {
            return "Scalene";
        }
    }
}