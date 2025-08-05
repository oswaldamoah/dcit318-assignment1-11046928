using System;

class GradeCalculator
{
    public static void Run()
    {
        Console.WriteLine("\n--- Grade Calculator ---");
        Console.Write("Enter numerical grade (0-100): ");
        
        if (int.TryParse(Console.ReadLine(), out int grade))
        {
            if (grade >= 0 && grade <= 100)
            {
                string letterGrade = GetLetterGrade(grade);
                Console.WriteLine($"Letter Grade: {letterGrade}");
            }
            else
            {
                Console.WriteLine("Grade must be between 0 and 100.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
    
    private static string GetLetterGrade(int grade)
    {
        if (grade >= 90) return "A";
        if (grade >= 80) return "B";
        if (grade >= 70) return "C";
        if (grade >= 60) return "D";
        return "F";
    }
}