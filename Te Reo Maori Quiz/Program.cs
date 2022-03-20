//This program is a Te Reo Maori quiz, created by Muhammad Amar
using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("This is a Te Reo Maori Quiz! \nPress any key to start!");
            Console.ReadKey(); //waits for user to input key
            Console.WriteLine("\n");
            Console.WriteLine("Would you like an easy, medium, or hard level?");
            string level = Console.ReadLine().ToLower();

            switch (level)
            {
                case "easy":
                    Console.WriteLine("Great you selected easy!");
                    MethodEasy();
                    break;
                case "medium":
                    Console.WriteLine("Great you selected medium!");
                    break;
                case "hard":
                    Console.WriteLine("Prepare youself for the hardest thing in your life!");
                    break;
                default:
                    Console.WriteLine("Please enter your level again and use uppercase letters");
                    break;
            }
        }
        static void MethodEasy()
        {
            Q1E:
            Console.WriteLine("How do you say well done in Maori?");
            Console.Write("A) Kia Ora, B) Ka Pai, C) Taniwha? ");
            if (Console.ReadLine().ToLower() == "ka pai")
            {
                Console.WriteLine("Ka Pai! You got it correct");
            }
            else
            {
                Console.WriteLine("Incorrect! Try again?");
                string again1 = Console.ReadLine().ToLower();
                while (again1 == "yes")
                {
                    goto Q1E;
                }
            }
            Q2E:

        }

    }

}







