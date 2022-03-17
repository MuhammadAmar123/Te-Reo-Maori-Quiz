//This program is a Te Reo Maori quiz, created by Muhammad Amar
Console.Write("This is a Te Reo Maori Quiz! \nPlease start your answers with captial letters for every word \nPress any key to start!");
Console.ReadKey(); //waits for user to input key
Console.WriteLine("\n");
Console.WriteLine("Would you like an Easy, Medium, or Hard level?");
string level = Console.ReadLine();
if (level == "Easy")
{
    Console.WriteLine("Great you selected easy!");
    goto easy;
         
}
else if (level == "Medium")
{
    Console.WriteLine("Great you selected medium!");
}
else if (level == "Hard")
{
    Console.WriteLine("Prepare youself for the hardest thing in your life!");
}
else
{
    Console.WriteLine("Please enter your level again and use uppercase letters");
}


easy:
Console.WriteLine("How do you say well done in Maori?");
Console.Write("A) Kia Ora, B) Ka Pai, C) Taniwha? ");
if (Console.ReadLine() == "Kia Ora")
{
    Console.WriteLine("Ka Pai! You got it correct");
}
