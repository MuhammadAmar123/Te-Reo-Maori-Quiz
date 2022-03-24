//This program is a Te Reo Maori quiz, created by Muhammad Amar
using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            void Intro()
            {
                Console.Write("This is a Te Reo Maori Quiz! \nPress any key to start!");
                Console.ReadKey(); //waits for user to input key
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
                        while (level != "easy" || level != " medium" || level != "hard")
                        {
                            Intro();
                        }
                        break;
                }
            }
            static void Easy()
            {
            Q1E:
                Console.WriteLine("Q1: How do you say well done in Maori? \nA) Kia Ora, B) Ka Pai, C) Taniwha? ");
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

                Console.WriteLine("Q2: How do you say Food in Maori? \nA) Kai, B) Pā C) Wai ");
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
                Console.WriteLine("\n");
            Q3E:
                Console.WriteLine("Q3: How do you say tribe in Maori? \nA) Iwi B) Kauri C)Mahi ");
                string ans3 = Console.ReadLine().ToLower();
                if (ans3 == "iwi" || ans3 == "a")
                {
                    Console.WriteLine("You got it correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect! Try again?");

                    while (Console.ReadLine().ToLower() == "yes")
                    {
                        goto Q3E;
                    }
                }

            Q4E:
                Console.WriteLine("Q4: How do you say sea in Maori? \nA) Puku B) Motu C) Moana");
                string ans4 = Console.ReadLine().ToLower();
                if (ans4 == "moana" || ans4 == "c")
                {
                    Console.WriteLine("You got it correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect! Try again?");

                    while (Console.ReadLine().ToLower() == "yes")
                    {
                        goto Q4E;
                    }
                }
            Q5E:
                Console.WriteLine("Q5: What does mahi mean? \nA) Work B) Pencil C) Water");
                string ans5 = Console.ReadLine().ToLower();
                if (ans5 == "work" || ans5 == "a")
                {
                    Console.WriteLine("You got it correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect! Try again?");

                    while (Console.ReadLine().ToLower() == "yes")
                    {
                        goto Q5E;
                    }
                }
            Q6E:
                Console.WriteLine("Q6: What does Aotearoa mean? \nA) Auckland B) New Zealand C) Wellington");
                string ans6 = Console.ReadLine().ToLower();
                if (ans6 == "new zealand" || ans6 == "b")
                {
                    Console.WriteLine("You got it correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect! Try again?");

                    while (Console.ReadLine().ToLower() == "yes")
                    {
                        goto Q6E;
                    }
                }
            Q7E:
                Console.WriteLine("Q7: What does Whānau mean? \nA) Building B) Family C) Supermarket");
                string ans7 = Console.ReadLine().ToLower();
                if (ans7 == "family" || ans7 == "b")
                {
                    Console.WriteLine("You got it correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect! Try again?");

                    while (Console.ReadLine().ToLower() == "yes")
                    {
                        goto Q7E;
                    }
                }
            Q8E:
                Console.WriteLine("Q8: What does Kia Kaha mean? \nA) Stay Strong B) Believe C) Good Night");
                string ans8 = Console.ReadLine().ToLower();
                if (ans8 == "stay strong" || ans8 == "a")
                {
                    Console.WriteLine("You got it correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect! Try again?");

                    while (Console.ReadLine().ToLower() == "yes")
                    {
                        goto Q8E;
                    }
                }
            Q9E:
                Console.WriteLine("Q9: How do you say love in Maori? \nA) Waiata B) Marae C) Aroha");
                string ans9 = Console.ReadLine().ToLower();
                if (ans9 == "aroha" || ans9 == "c")
                {
                    Console.WriteLine("You got it correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect! Try again?");

                    while (Console.ReadLine().ToLower() == "yes")
                    {
                        goto Q9E;
                    }
                }
            Q10E:
                Console.WriteLine("Q10: How do you say love in Maori? \nA) Waiata B) Marae C) Aroha");
                string ans10 = Console.ReadLine().ToLower();
                if (ans10 == "aroha" || ans10 == "c")
                {
                    Console.WriteLine("You got it correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect! Try again?");

                    while (Console.ReadLine().ToLower() == "yes")
                    {
                        goto Q10E;
                    }
                }
                



            }


        }

    }
}







