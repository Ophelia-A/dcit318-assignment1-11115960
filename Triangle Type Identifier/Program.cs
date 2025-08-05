using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Triangle Type Identifier");
    Console.WriteLine("-----------------------");
   
      // Prompt user for three sides
      Console.Write("Enter length of side 1: ");
      if (!double.TryParse(Console.ReadLine(), out double side1) || side1 <= 0)
      {
        Console.WriteLine("Invalid input. Please enter a positive side length.");
        return;
      }

      Console.Write("Enter length of side 2: ");
      if (!double.TryParse(Console.ReadLine(), out double side2) || side2 <= 0)
      {
        Console.WriteLine("Invalid input. Please enter a positive side length.");
        return;
      }

      Console.Write("Enter length of side 3: ");
      if (!double.TryParse(Console.ReadLine(), out double side3) || side3 <= 0)
      {
        Console.WriteLine("Invalid input. Please enter a positive side length.");
        return;
      }

      // Check if triangle is valid using triangle inequality theorem( which states that the sum of the lengths of any two sides of a triangle must be greater than the length of the third side.)
      if (side1 + side2 <= side3 || side2 + side3 <= side1 || side1 + side3 <= side2)
      {
        Console.WriteLine("These side lengths cannot form a valid triangle according to the triangle inequality theorem.");
        return;
    
      }

      // Determine triangle type
      string triangleType;
      if (side1 == side2 && side2 == side3)
      {
        triangleType = "Equilateral";
      }
      else if (side1 == side2 || side2 == side3 || side1 == side3)
      {
        triangleType = "Isosceles";
      }
      else
      {
        triangleType = "Scalene";
      }

      // Display result
      Console.WriteLine($"\nThe triangle is {triangleType}.");
    
    }
  
}