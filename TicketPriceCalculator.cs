using System;

class TicketPriceCalculator
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        int ticketPrice;

        if (age <= 12 || age >= 65)
        {
            ticketPrice = 7; // Discounted price
        }
        else
        {
            ticketPrice = 10; // Regular price
        }

        Console.WriteLine($"Ticket Price: GHC{ticketPrice}");
    }
}
