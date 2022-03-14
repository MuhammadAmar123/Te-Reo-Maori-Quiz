//This program is a Te Reo Maori quiz
Console.Write("This is a Te Reo Maori Quiz! \nPress any key to start!");
Console.ReadKey();
Console.WriteLine("\n");
Console.WriteLine("Would you like an easy, medium, or hard level?");
string level = Console.ReadLine();
if (level == "easy")
{
    Console.WriteLine("Great you selected easy!");
    
}
else if (level == "medium")
{
    Console.WriteLine("Great you selected medium!");
}
else if (level == "hard")
{
    Console.WriteLine("Prepare youself for the hardest thing in your life!");
}
else
{
    Console.WriteLine("Please enter your level again and DONT use uppercase letters");
}