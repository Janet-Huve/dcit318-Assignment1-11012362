using System;

class GradeCalculator
{
    static void Main()
    {
        Console.Write("Enter a numerical grade (0-100): ");
        int grade = Convert.ToInt32(Console.ReadLine());

        if (grade >= 90 && grade <= 100)
        {
            Console.WriteLine("Letter Grade: A");
        }
        else if (grade >= 80 && grade < 90)
        {
            Console.WriteLine("Letter Grade: B");
        }
        else if (grade >= 70 && grade < 80)
        {
            Console.WriteLine("Letter Grade: C");
        }
        else if (grade >= 60 && grade < 70)
        {
            Console.WriteLine("Letter Grade: D");
        }
        else if (grade < 60 && grade >= 0)
        {
            Console.WriteLine("Letter Grade: F");
        }
        else
        {
            Console.WriteLine("Invalid grade entered. Please enter a grade between 0 and 100.");
        }
    }
}
