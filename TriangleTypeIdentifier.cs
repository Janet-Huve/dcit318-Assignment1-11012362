using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.Write("Enter the length of side A: ");
        double sideA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side B: ");
        double sideB = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side C: ");
        double sideC = Convert.ToDouble(Console.ReadLine());

        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            Console.WriteLine("Invalid input. All sides must be positive.");
            return;
        }

        if (sideA == sideB && sideB == sideC)
        {
            Console.WriteLine("Triangle Type: Equilateral");
        }
        else if (sideA == sideB || sideA == sideC || sideB == sideC)
        {
            Console.WriteLine("Triangle Type: Isosceles");
        }
        else
        {
            Console.WriteLine("Triangle Type: Scalene");
        }
    }
}
