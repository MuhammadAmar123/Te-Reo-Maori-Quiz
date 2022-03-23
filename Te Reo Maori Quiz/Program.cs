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
            Console.Clear();
            Console.WriteLine("Would you like an easy, medium, or hard level?");
            string level = Console.ReadLine().ToLower();

            switch (level)
            {
                case "easy":
                    Console.WriteLine("Great you selected easy! \nClick enter to begin");
                    Console.ReadKey();
                    Console.Clear();
                    Easy();
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
        static void Easy()
        {
            Q1E:
            Console.WriteLine("Q1: How do you say well done in Maori?");
            Console.Write("A) Kia Ora, B) Ka Pai, C) Taniwha? ");
            string ans1 = Console.ReadLine().ToLower();
            if (ans1 == "ka pai" || ans1 == "b")
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
            Console.WriteLine("\n");
        Q2E:
            
            Console.WriteLine("Q2: How do you say Food in Maori?");
            Console.Write("A) Kai, B) Pā C) Wai ");
            string ans2 = Console.ReadLine().ToLower();
            if (ans2 == "kai" || ans2 == "a")
            {
                Console.WriteLine("You got it correct!");
            }
            else
            {
                Console.WriteLine("Incorrect! Try again?");

                while (Console.ReadLine().ToLower() == "yes")
                {
                    goto Q2E;
                }
            }
        }
        public static string Retry()
        {
            return x % y;
        }
    }

}







