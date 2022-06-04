/*This program is a Te Reo Maori quiz, created by Muhammad Amar. This program will help people learn about Te Reo Maori by asking them what certain words mean in Maori.
Start
Beginning tells user what the program is. Waits for user to press enter.
Then asks user for the level they want to pick (easy, medium or hard)
Then informs user the level they selected and asks them to press enter to begin.
When they press enter the screen clears
When program enters level then three integer values are created with two of the value being 0 and one of them being 1
Program enter do while until question int < than 10
Program displays question number through int variable then gets question from questions array depending on the number in int question and options from the answers array
User answer is stored in string userAns
if statement checks answer
if correct text will become green and say it is correct and reward user with 1 point
if wrong text will become red and say incorrect and not increase the point
if its wrong user will be asked if they want to repeat question
if true then program will go to try again label and decrease one point
if not then question and question number int will be increased and code will be repeated until int question < 10
After 10 repeats the program will show your total score at the end
User then presses enter so then the program returns to MainMenu method
User can either choose another level or exit the program
End
*/
using System;

namespace TeReoMaoriQuiz
{
    class Program
    {
        static void Main(string[] args)
        {

            MainMenu();
            static void MainMenu()
            {
                Console.WriteLine("This is a Te Reo Maori Quiz! \nPress Enter to start! or press E to exit");
                if (Console.ReadLine().ToLower() == "e")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Intro();
                }
            }
            
            static void Intro()
            {
               
                Console.WriteLine("Would you like an easy, medium, or hard level?");
                string level = Console.ReadLine().ToLower();
                switch (level)
                {
                    case "easy":
                    case "e":
                        Console.WriteLine("Great you selected easy! \nClick enter to begin");
                        Console.ReadKey();
                        Console.Clear(); // Clear the console for a blank canvas
                        Easy();
                        break;
                    case "medium":
                    case "m":
                        Console.WriteLine("Great you selected medium! \nClick enter to begin");
                        Console.ReadKey();
                        Console.Clear();
                        Medium();
                        break;
                    case "hard":
                    case "h":
                        Console.WriteLine("Prepare youself for the hardest thing in your life! \nClick enter to begin");
                        Console.ReadKey();
                        Console.Clear();
                        Hard();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter your level again"); // If user doesn't input the approriate words then it will go to the start
                        while (level != "easy" || level != " medium" || level != "hard")
                        {
                            Console.ResetColor();
                            Console.WriteLine("\n");
                            Intro(); // go to the starting of the method
                        }
                        break;
                }
            }

            static void Easy() // Easy questions
            {
                int score = 0;
                int question = 0;
                int questionNum = 1;
                do
                {
                tryAgain:
                    string[] questions = { "How do you say well done in Maori?", "How do you say Food in Maori?", "How do you say tribe in Maori?",
                    "How do you say sea in Maori?","What does mahi mean?", "What does Aotearoa mean?", "What does Whānau mean?", "What does Kia Kaha mean?",
                     "How do you say love in Maori?","What is a Kiwi?" }; // One place for easy questions
                    string[] answers = { "A) Kia Ora, B) Ka Pai, C) Taniwha", "A) Kai, B) Pā C) Wai", "A) Iwi B) Kauri C) Mahi", // One place for options
                    "A) Puku B) Motu C) Moana", "A) Work B) Pencil C) Water","A) Auckland B) New Zealand C) Wellington","A) Building B) Family C) Supermarket",
                    "A) Stay Strong B) Believe C) Good Night","A) Waiata B) Marae C) Aroha","A) A lizard B) The word for people C) Native NZ bird" };
                    string[] realAns = { "b", "a", "a", "c", "a", "b", "b", "a", "c", "c" }; // One place for the correct answers

                    Console.WriteLine($"\nQ{questionNum}: {questions[question]}   \n{answers[question]} "); // Ask user the question
                    string userAns = Console.ReadLine().ToLower();
                    if (!string.IsNullOrEmpty(userAns))

                    {
                        if (userAns == realAns[question]) // Checks for the correct answer
                        {
                            score++; // increases score
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"You got it correct! Your score is {score}");
                            Console.ResetColor();
                            questionNum++; // increases questions number
                            question++;  // increases quesion
                        }
                        else if (userAns != realAns[question]) // if answer is wrong this will be executed
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is incorrect!");
                            Console.ResetColor();
                        WrongUserInput:
                            Console.WriteLine("Would you like to try again?");
                            string again = Console.ReadLine().ToLower();
                            if (again == "yes" || again == "y")
                            {
                                score--;
                                goto tryAgain;
                            }
                            else if (again == "no" || again == "n")
                            {
                                questionNum++;
                                question++;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nPlease enter yes or no"); // If user answer wrong type of answer, it will execute
                                Console.ResetColor();
                                goto WrongUserInput;
                            }
                        } 
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter something");
                        Console.ResetColor();
                    }
                    
                }

                    while (question < 10) ;

                    Console.WriteLine("\n");
                    Console.WriteLine($"Congratulations! Your total score was {score} \nPress Enter to go to Main Menu");
                    Console.ReadKey();
                    Console.Clear();
                    MainMenu();

                }

            static void Medium() // Medium level questions
            {
                int score = 0;
                int question = 0;
                int questionNum = 1;
                do
                {
                tryAgain:
                    string[] questions = { "What does Motu mean?", "How do you say children in Maori?", "What does puku mean?", "What does hangi mean?",
                    "What does Wahine mean?", "What does Iti mean?", "How do you say canoe in Maori?", "How do you say water in Maori?","What is a Moa?",
                    "How do you say funeral in Maori?" }; // One place for all medium questions
                    string[] answers = { "A) Island, B) Salt, C) Computer", "A) Tapu, B) Moa, C) Tamariki", "A) Belly, B) Brain, C) Moon", // One place for options
                    "A) Traditional Maori dance, B) Food made in earth oven, C) Sun", "A) Cousin, B) Flowers, C) Woman/Wife","A) Small, B) Fan, C) Pencil","A) Waka, B) Taonga, C) Whare",
                    "A) Tapu, B) Wai, C) Tama","A) An extinct bird, B) A type of car, C) A type of parrot","A) Hui, B) Waiata, C) Tangi" };
                    string[] realAns = { "a", "c", "a", "b", "c", "a", "a", "b", "a", "c" }; // One place for the correct answers

                    Console.WriteLine($"\nQ{questionNum}: {questions[question]}   \n{answers[question]} "); // Asks user the question
                    string userAns = Console.ReadLine().ToLower();
                    if (!string.IsNullOrEmpty(userAns))
                    {
                        if (userAns == realAns[question]) // Checks for the correct answer
                        {
                            score++; // increases score
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"You got it correct! Your score is {score}");
                            Console.ResetColor();
                            questionNum++; // increases questions number
                            question++;  // increases quesion
                        }
                        else if (userAns != realAns[question]) // if answer is wrong this will be executed
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is incorrect!");
                            Console.ResetColor();
                        WrongUserInput:
                            Console.WriteLine("Would you like to try again?");
                            string again = Console.ReadLine().ToLower();
                            if (again == "yes" || again == "y")
                            {
                                score--;
                                goto tryAgain;
                            }
                            else if (again == "no" || again == "n")
                            {
                                questionNum++;
                                question++;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nPlease enter yes or no"); // If user answer wrong type of answer, it will execute
                                Console.ResetColor();
                                goto WrongUserInput;
                            }
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter something");
                        Console.ResetColor();
                    }
                }
                while (question < 10);

                Console.WriteLine("\n");
                Console.WriteLine($"Congratulations! Your total score was {score} \nPress Enter to go to Main Menu");
                Console.ReadKey();
                Console.Clear();
                MainMenu();
            }


            static void Hard() // Hard level question
            {
                int score = 0;
                int question = 0;
                int questionNum = 1;
                do
                {
                tryAgain:
                    string[] questions = { "What does Maunga mean?", "What does Tamāhine mean?", "What does Whakapapa mean?", "What does Manuhiri mean?",// One whole place for hard questions
                    "What does Kaumatua mean?", "What does Tama mean?", "What does Tāne mean?", "What does Whāngai mean?","What does Tuahine mean?",
                    "What does Whaikōrero mean?" };
                    string[] answers = { "A) Mountain, B) Waiata, C) Tangi", "A) Moon, B) Hair, C) Daughter", "A) Geneology, B) Grandad, C) Store", // One place for options
                    "A) Road, B) Guests, C) Mobile Phone", "A) Elder, B) Food, C) Lunch","A) Son, B) Father, C) Grandma","A) Mother, B) Husband, C) Children",
                    "A) Poster, B) Fan, C) Adopted Child","A) Sister of a man, B) Daughter of a Woman, C) Man of a Wife","A) Couch, B) Family, C) To make a speech" };
                    string[] realAns = { "a", "c", "a", "b", "a", "a", "b", "c", "a", "c" }; // One place for the correct answers

                    Console.WriteLine($"\nQ{questionNum}: {questions[question]}   \n{answers[question]} "); // Asks user the question
                    string userAns = Console.ReadLine().ToLower();
                    if (!string.IsNullOrEmpty(userAns))
                    {
                        if (userAns == realAns[question]) // Checks for the correct answer
                        {
                            score++; // increases score
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"You got it correct! Your score is {score}");
                            Console.ResetColor();
                            questionNum++; // increases question number
                            question++;  // increases quesion
                        }
                        else if (userAns != realAns[question])
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is incorrect!");
                            Console.ResetColor();
                        WrongUserInput:
                            Console.WriteLine("Would you like to try again?");
                            string again = Console.ReadLine().ToLower();
                            if (again == "yes" || again == "y")
                            {
                                score--;
                                goto tryAgain;
                            }
                            else if (again == "no" || again == "n")
                            {
                                questionNum++;
                                question++;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nPlease enter yes or no");
                                Console.ResetColor();
                                goto WrongUserInput;
                            }
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter something");
                        Console.ResetColor();
                    }
                }
                while (question < 10);
                Console.WriteLine("\n");
                Console.WriteLine($"Congratulations! Your total score was {score} \nPress Enter to go to Main Menu");
                Console.ReadKey();
                Console.Clear();
                MainMenu();

            }

        }
    }
}
