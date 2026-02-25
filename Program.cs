using System;
using System.Collections.Generic;
namespace COMP003A.LectureActivity7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 85, 90, 78, 92, 88 };
            Console.WriteLine("Displaying array values using for loop:");
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"score at index {i}: {scores[i]}");
            }
            List<string> names = new List<string>();
            names.Add("Alice");
            names.Add("Jordan");
            names.Add("Taylor");
            Console.WriteLine("\nDisplaying list values using foreach loop:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\nDisplaying list values using for loop:");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"name at index {i}: {names[i]}");
            }
            Console.WriteLine("\nEnter a number between 1 and 3:");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int validatedNumber))
            {
                if (validatedNumber >= 1 && validatedNumber <= 3)
                {
                    Console.WriteLine("Valid number entered!");
                }
                else
                {
                    Console.WriteLine("Number is out of range.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Pleas enter a numeric value.");
            }
            Console.WriteLine("\nTesting try-catch:");
            Console.WriteLine("Enter a number between 1 and 3:");
            input = Console.ReadLine();
            try
            {
                int choice = int.Parse(input);
                if (choice >= 1 && choice <= 3)
                {
                    Console.WriteLine("Valid number entered!");
                }
                else
                {
                    Console.WriteLine("Number is out of range.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(" Invalid number emtered");
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
