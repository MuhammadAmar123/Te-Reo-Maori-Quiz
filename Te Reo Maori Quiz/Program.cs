//This program is a Te Reo Maori quiz, created by Muhammad Amar
using System;

namespace methods
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


            static void Medium() // Medoum level questions
            {
            Q1M:
                Console.WriteLine("\n");
                Console.WriteLine("Q1: What does motu mean? \nA) Island, B) Salt, C) Computer");
                string ans1 = Console.ReadLine().ToLower();
                if (ans1 == "island" || ans1 == "a")
                {
                    Console.WriteLine("You got it correct");
                }
                else
                {
                    Console.WriteLine("Incorrect! Try again?");
                    while (Console.ReadLine().ToLower() == "yes")
                    {
                        goto Q1M;
                    }
                }
            Q2M:
                Console.WriteLine("\n");
                Console.WriteLine("Q2: How do you say children in Maori? \nA) Tapu, B) Moa, C) Tamariki");
                string ans2 = Console.ReadLine().ToLower();
                if (ans2 == "tamariki " || ans2 == "c")
                {
                    Console.WriteLine("You got it correct");
                }
                else
                {
                    Console.WriteLine("Incorrect! Try again?");
                    while (Console.ReadLine().ToLower() == "yes")
                    {
                        goto Q2M;
                    }
                }
            Q3M:
                Console.WriteLine("\n");
                Console.WriteLine("Q3: What does puku mean? \nA) Belly, B) Brain, C) Moon");
                string ans3 = Console.ReadLine().ToLower();
                if (ans3 == "belly" || ans3 == "a")
                {
                    Console.WriteLine("You got it correct");
                }
                else
                {
                    Console.WriteLine("Incorrect! Try again?");
                    while (Console.ReadLine().ToLower() == "yes")
                    {
                        goto Q3M;
                    }
                }
            Q4M:
                Console.WriteLine("\n");
                Console.WriteLine("Q4: What does hangi mean? \nA) Traditional Maori dance, B) Food made in earth oven, C) Sun");
                string ans4 = Console.ReadLine().ToLower();
                if (ans4 == "Food made in earth oven " || ans4 == "b")
                {
                    Console.WriteLine("You got it correct");
                }
                else
                {
                    Console.WriteLine("Incorrect! Try again?");
                    while (Console.ReadLine().ToLower() == "yes")
                    {
                        goto Q4M;
                    }
                }
            Q5M:
                Console.WriteLine("\n");
                Console.WriteLine("Q5: What does wahine? \nA) Cousin, B) Flowers, C) Woman/Wife ");
                string ans5 = Console.ReadLine().ToLower();
                if (ans5 == "woman" || ans5 == "c" || ans5 == "woman/wife")
                {
                    Console.WriteLine("You got it correct");
                }
                else
                {
                    Console.WriteLine("Incorrect! Try again?");
                    while (Console.ReadLine().ToLower() == "yes")
                    {
                        goto Q5M;
                    }
                }
            Q6M:
                Console.WriteLine("\n");
                Console.WriteLine("Q6: What does Iti mean? \nA) Small, B) Fan, C) Pencil ");
                string ans6 = Console.ReadLine().ToLower();
                if (ans6 == "small" || ans6 == "a")
                {
                    Console.WriteLine("You got it correct");
                }
                else
                {
                    Console.WriteLine("Incorrect! Try again?");
                    while (Console.ReadLine().ToLower() == "yes")
                    {
                        goto Q6M;
                    }
                }
            Q7M:
                Console.WriteLine("\n");
                Console.WriteLine("Q7: How do you say canoe in Maori? \nA) Waka, B) Taonga, C) Whare ");
                string ans7 = Console.ReadLine().ToLower();
                if (ans7 == "Waka" || ans7 == "a")
                {
                    Console.WriteLine("You got it correct");
                }
                else
                {
                    Console.WriteLine("Incorrect! Try again?");
                    while (Console.ReadLine().ToLower() == "yes")
                    {
                        goto Q7M;
                    }
                }
            Q8M:
                Console.WriteLine("\n");
                Console.WriteLine("Q8: How do you say water in Maori? \nA) Tapu, B) Wai, C) Tama ");
                string ans8 = Console.ReadLine().ToLower();
                if (ans8 == "Wai" || ans8 == "b")
                {
                    Console.WriteLine("You got it correct");
                }
                else
                {
                    Console.WriteLine("Incorrect! Try again?");
                    while (Console.ReadLine().ToLower() == "yes")
                    {
                        goto Q8M;
                    }
                }
            Q9M:
                Console.WriteLine("\n");
                Console.WriteLine("Q9: What is a Moa? \nA) An extinct bird, B) A type of car, C) A type of parrot ");
                string ans9 = Console.ReadLine().ToLower();
                if (ans9 == "an extinct bird" || ans9 == "a")
                {
                    Console.WriteLine("You got it correct");
                }
                else
                {
                    Console.WriteLine("Incorrect! Try again?");
                    while (Console.ReadLine().ToLower() == "yes")
                    {
                        goto Q9M;
                    }
                }
            Q10M:
                Console.WriteLine("\n");
                Console.WriteLine("Q10: How do you say funeral in Maori? \nA) Hui, B) Waiata, C) Tangi ");
                string ans10 = Console.ReadLine().ToLower();
                if (ans10 == "tangi" || ans10 == "c")
                {
                    Console.WriteLine("You got it correct");
                }
                else
                {
                    Console.WriteLine("Incorrect! Try again?");
                    while (Console.ReadLine().ToLower() == "yes")
                    {
                        goto Q10M;
                    }
                }

            }


            static void Hard() // Hard level questions
            {
            Q1H:
                string[] questions = { "What does Maunga mean?", "What does Tamāhine mean?", "What does Whakapapa mean?", "What does Manuhiri mean?", 
                    "What does Kaumatua mean?", "What does Tama mean?", "What does Tāne mean?", "What does Whāngai mean?","What does Tuahine mean?" };
                Console.WriteLine("\n");
                Console.WriteLine($"Q1: {questions[0]}  \nA) Mountain, B) Waiata, C) Tangi ");
                string ans1 = Console.ReadLine().ToLower();
                if (ans1 == "mountain" || ans1 == "a")
                {
                    Console.WriteLine("You got it correct");
                }
                else
                {
                    Console.WriteLine("Incorrect! Try again?");
                    while (Console.ReadLine().ToLower() == "yes")
                    {
                        goto Q2H;
                    }

                }
            Q2H:
                    Console.WriteLine("\n");
                    Console.WriteLine($"Q2: {questions[1]} \nA) Moon, B) Hair, C) Daughter ");
                    string ans2 = Console.ReadLine().ToLower();
                    if (ans2 == "daughter" || ans2 == "c")
                    {
                        Console.WriteLine("You got it correct");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! Try again?");
                        while (Console.ReadLine().ToLower() == "yes")
                        {
                            goto Q2H;
                        }

                    }
                Q3H:
                    Console.WriteLine("\n");
                    Console.WriteLine($"Q3: {questions[2]} \nA) Geneology, B) Grandad, C) Store ");
                    string ans3 = Console.ReadLine().ToLower();
                    if (ans3 == "geneology" || ans3 == "a")
                    {
                        Console.WriteLine("You got it correct");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! Try again?");
                        while (Console.ReadLine().ToLower() == "yes")
                        {
                            goto Q3H;
                        }

                    }
                Q4H:
                    Console.WriteLine("\n");
                    Console.WriteLine($"Q4: {questions[3]} \nA) Road, B) Guests, C) Mobile Phone ");
                    string ans4 = Console.ReadLine().ToLower();
                    if (ans4 == "guests" || ans4 == "b")
                    {
                        Console.WriteLine("You got it correct");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! Try again?");
                        while (Console.ReadLine().ToLower() == "yes")
                        {
                            goto Q4H;
                        }

                    }
                Q5H:
                    Console.WriteLine("\n");
                    Console.WriteLine($"Q5: {questions[4]} \nA) Elder, B) Food, C) Lunch ");
                    string ans5 = Console.ReadLine().ToLower();
                    if (ans5 == "elder" || ans5 == "a")
                    {
                        Console.WriteLine("You got it correct");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! Try again?");
                        while (Console.ReadLine().ToLower() == "yes")
                        {
                            goto Q5H;
                        }

                    }
                Q6H:
                    Console.WriteLine("\n");
                    Console.WriteLine($"Q6: {questions[5]} \nA) Son, B) Father, C) Grandma ");
                    string ans6 = Console.ReadLine().ToLower();
                    if (ans6 == "son" || ans6 == "a")
                    {
                        Console.WriteLine("You got it correct");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! Try again?");
                        while (Console.ReadLine().ToLower() == "yes")
                        {
                            goto Q6H;
                        }

                    }
                Q7H:
                    Console.WriteLine("\n");
                    Console.WriteLine($"Q7: {questions[6]} \nA) Mother, B) Husband, C) Children ");
                    string ans7 = Console.ReadLine().ToLower();
                    if (ans7 == "husband" || ans7 == "b")
                    {
                        Console.WriteLine("You got it correct");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! Try again?");
                        while (Console.ReadLine().ToLower() == "yes")
                        {
                            goto Q7H;
                        }

                    }
                Q8H:
                    Console.WriteLine("\n");
                    Console.WriteLine($"Q8: {questions[7]} \nA) Poster, B) Fan, C) Adopted Child ");
                    string ans8 = Console.ReadLine().ToLower();
                    if (ans8 == "adopted child" || ans8 == "c")
                    {
                        Console.WriteLine("You got it correct");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! Try again?");
                        while (Console.ReadLine().ToLower() == "yes")
                        {
                            goto Q8H;
                        }

                    }
                Q9H:
                    Console.WriteLine("\n");
                    Console.WriteLine($"Q9: {questions[8]} \nA) Sister of a man, B) Daughter of a Woman, C) Man of a Wife ");
                    string ans9 = Console.ReadLine().ToLower();
                    if (ans9 == "sister of a man" || ans9 == "a")
                    {
                        Console.WriteLine("You got it correct");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! Try again?");
                        while (Console.ReadLine().ToLower() == "yes")
                        {
                            goto Q9H;
                        }

                    }
                





                }
            }
        }
    }










