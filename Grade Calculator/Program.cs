using System;

class Program
{
    static void Main()
    {
    int grade;
    while (true)
        {
            Console.Write("Enter your grade (0–100): ");
            bool isValid = int.TryParse(Console.ReadLine(), out grade);

            if (!isValid || grade < 0 || grade > 100)
            {
                Console.WriteLine("Your input is invalid. Please enter a number between 0 and 100.\n");
            }
            else
            {
                break; // valid input, exit loop
            }
        
        
        }

        // Determine and print letter grade
        if (grade >= 90)
        {
            Console.WriteLine("Your letter grade is: A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Your letter grade is: B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your letter grade is: C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Your letter grade is: D");
        }
        else
        {
            Console.WriteLine("Your letter grade is: F");
        }
    }
}
