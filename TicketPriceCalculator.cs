using System;

class TicketPriceCalculator
{
    public static void Run()
    {
        Console.WriteLine("\n--- Ticket Price Calculator ---");
        Console.Write("Enter your age: ");
        
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            decimal price = CalculateTicketPrice(age);
            Console.WriteLine($"Ticket Price: GHC{price}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
    
    private static decimal CalculateTicketPrice(int age)
    {
        const decimal regularPrice = 10.0m;
        const decimal discountedPrice = 7.0m;
        
        if (age <= 12 || age >= 65)
        {
            return discountedPrice;
        }
        return regularPrice;
    }
}