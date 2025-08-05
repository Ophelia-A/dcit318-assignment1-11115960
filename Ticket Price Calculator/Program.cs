using System;

class Program
{
    static void Main()
    {
        int age;

        while (true)
        {
            Console.Write("How old are you? ");
            if (int.TryParse(Console.ReadLine(), out age) && age >= 0)
                break;

            Console.WriteLine("Invalid input. Please enter a valid non-negative whole number.\n");
        }

        int ticketPrice;

        if (age <= 12 || age >= 65)
        {
            ticketPrice = 7;
        }
        else
        {
            ticketPrice = 10;
        }

        Console.WriteLine($"Your ticket price is: GHC{ticketPrice}");
    }
}
