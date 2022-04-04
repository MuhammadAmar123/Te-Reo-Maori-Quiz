﻿//This program is a Te Reo Maori quiz, created by Muhammad Amar
using System;

namespace TeReoMaoriQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            void Intro() //intro method
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
                        Console.Clear(); // Clear the console for a blank canvas
                        Easy();
                        break;
                    case "medium":
                        Console.WriteLine("Great you selected medium! \nClick enter to begin");
                        Console.ReadKey();
                        Console.Clear();
                        Medium();
                        break;
                    case "hard":
                        Console.WriteLine("Prepare youself for the hardest thing in your life! \nClick enter to begin");
                        Console.ReadKey();
                        Console.Clear();
                        Hard();
                        break;
                    default:
                        Console.WriteLine("Please enter your level again"); // If user doesn't input the approriate words then it will go to the start
                        while (level != "easy" || level != " medium" || level != "hard")
                        {
                            Console.WriteLine("\n");
                            Intro(); // go to the starting of the method
                        }
                        break;
                }
            }
            static void Easy() // Easy questions
            {
            Q1E:
                Console.WriteLine("\n");
                Console.WriteLine("Q1: How do you say well done in Maori? \nA) Kia Ora, B) Ka Pai, C) Taniwha ");
                string ans1 = Console.ReadLine().ToLower();
                if (ans1 == "ka pai" || ans1 == "b")
                {
                    Console.WriteLine("Ka Pai! You got it correct");
                }
                else
                {
                    Console.WriteLine("Incorrect! Try again?");
                    while (Console.ReadLine().ToLower() == "yes")
                    {
                        goto Q1E;
                    }
                }
            Q2E:
                Console.WriteLine("\n");
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
            Q3E:
                Console.WriteLine("\n");
                Console.WriteLine("Q3: How do you say tribe in Maori? \nA) Iwi B) Kauri C) Mahi ");
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
                Console.WriteLine("\n");
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
                Console.WriteLine("\n");
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
                Console.WriteLine("\n");
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
                Console.WriteLine("\n");
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
                Console.WriteLine("\n");
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
                Console.WriteLine("\n");
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
                Console.WriteLine("\n");
                Console.WriteLine("Q10: What is a Kiwi? \nA) A lizard B) The word for people C) Native NZ bird");
                string ans10 = Console.ReadLine().ToLower();
                if (ans10 == "native nz bird" || ans10 == "c")
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


            static void Medium() // Medium level questions
            {

                int score = 0;
                int question = 0;
                int questionNum = 1;
                do
                {
                tryAgain:
                    string[] questions = { "What does Motu mean?", "How do you say children in Maori?", "What does puku mean?", "What does hangi mean?",// One whole place for all the questions
                    "What does Wahine mean?", "What does Iti mean?", "How do you say canoe in Maori?", "How do you say water in Maori?","What is a Moa?",
                    "How do you say funeral in Maori?" };
                    string[] answers = { "A) Island, B) Salt, C) Computer", "A) Tapu, B) Moa, C) Tamariki", "A) Belly, B) Brain, C) Moon", // One whole place for options
                    "A) Traditional Maori dance, B) Food made in earth oven, C) Sun", "A) Cousin, B) Flowers, C) Woman/Wife","A) Small, B) Fan, C) Pencil","A) Waka, B) Taonga, C) Whare",
                    "nA) Tapu, B) Wai, C) Tama","A) An extinct bird, B) A type of car, C) A type of parrot","A) Hui, B) Waiata, C) Tangi" };
                    string[] realans = { "a", "c", "a", "b", "c", "a", "a", "b", "a", "c" }; // One whole place for the correct answers

                    Console.WriteLine($"\nQ{questionNum}: {questions[question]}   \n{answers[question]} "); // Ask user the question
                    string userans = Console.ReadLine();
                    if (userans == realans[question]) // Checks for the correct answer
                    {
                        score++; // increases score
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"You got it correct! Your score is {score}");
                        Console.ResetColor();
                        questionNum++; // increases questions number
                        question++;  // increases quesion
                    }
                    else if (userans != realans[question]) // if answer is wrong this will be executed
                    {
                        score--;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That is incorrect!");
                        Console.ResetColor();
                        Console.WriteLine("Would you like to try again?");
                        string again = Console.ReadLine().ToLower();
                        if (again == "yes" || again == "y")
                        {
                            goto tryAgain;
                        }
                        else
                        {
                            questionNum++;
                            question++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter yes or no"); // If user answer wrong type of answer, it will execute
                        goto tryAgain;
                    }

                }

                while (question < 10);

                Console.WriteLine("\n");
                Console.WriteLine($"Congratulations! Your total score was {score} \n Bye!");
            }


           


            static void Hard() // Hard level question
            {
                int score = 0;
                int question = 0;
                int questionNum = 1;
                do
                {
                tryAgain:
                    string[] questions = { "What does Maunga mean?", "What does Tamāhine mean?", "What does Whakapapa mean?", "What does Manuhiri mean?",// One whole place for all the questions
                    "What does Kaumatua mean?", "What does Tama mean?", "What does Tāne mean?", "What does Whāngai mean?","What does Tuahine mean?",
                    "What does Whaikōrero mean?" }; 
                    string[] answers = { "A) Mountain, B) Waiata, C) Tangi", "A) Moon, B) Hair, C) Daughter", "A) Geneology, B) Grandad, C) Store", // One whole place for options
                    "A) Road, B) Guests, C) Mobile Phone", "A) Elder, B) Food, C) Lunch","A) Son, B) Father, C) Grandma","A) Mother, B) Husband, C) Children",
                    "A) Poster, B) Fan, C) Adopted Child","A) Sister of a man, B) Daughter of a Woman, C) Man of a Wife","A) Couch, B) Family, C) To make a speech" };
                    string[] realans = { "a", "c", "a", "b", "a", "a", "b", "c", "a", "c" }; // One whole place for the correct answers

                    Console.WriteLine($"\nQ{questionNum}: {questions[question]}   \n{answers[question]} "); // Ask user the question
                    string userans = Console.ReadLine();
                    if (userans == realans[question]) // Checks for the correct answer
                    {
                        score++; // increases score
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"You got it correct! Your score is {score}");
                        Console.ResetColor();
                        questionNum++; // increases questions number
                        question++;  // increases quesion
                    }
                    else if (userans != realans[question]) // if answer is wrong this will be executed
                    {
                        score--;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That is incorrect!");
                        Console.ResetColor();
                        Console.WriteLine("Would you like to try again?");
                        string again = Console.ReadLine().ToLower();
                        if (again == "yes" || again == "y")
                        {
                            goto tryAgain;
                        }
                        else
                        {
                            questionNum++;
                            question++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter yes or no"); // If user answer wrong type of answer, it will execute
                        goto tryAgain;
                    }

                }

                while (question < 10);
                
                Console.WriteLine("\n");
                Console.WriteLine($"Congratulations! Your total score was {score} \n Bye!");

            }

        }
    }
}











