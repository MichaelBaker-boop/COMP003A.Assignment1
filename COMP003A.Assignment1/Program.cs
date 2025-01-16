/*
    Author: Michael Baker.
    Course: COMP003A
    Faculty: Jonathan Cruz
    Purpose: Input/Output Assignment
*/
namespace COMP003A.Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: "); // Prompts user for input //
            string username = Console.ReadLine(); // Saves input as string/variable named username//

            Console.WriteLine("Hello, " + username + "! My name is Michael Baker."); //Returns message with user input and continues to execute code //
            Console.WriteLine("Here are 10 things about me:");
            Console.WriteLine("\t1. I drive a 1994 Miata that just had the clutch go out.");
            Console.WriteLine("\t2. I also drive a 2023 Kona that is much more reliable than my 30 year old car.");
            Console.WriteLine("\t3. My favorite video game is one I grew up with - Minecraft.");
            Console.WriteLine("\t4. Even though I'm not really good at it, I enjoy sim racing.");
            Console.WriteLine("\t5. I like to listen to long form content when I'm doing homework.");
            Console.WriteLine("\t6. My favorite podcasts are P1 with Matt and Tommy for F1 content and Some/Even More News for news content.");
            Console.WriteLine("\t7. My favorite F1 Team is Mclaren; not because they just won the constructors championship but because they are the brand I own the most hot wheels of behind Porsche.");
            Console.WriteLine("\t8. My favorite IMSA team is Bryan Herta Autosport because they run the Hyundai Elantra TCR cars.");
            Console.WriteLine("\t9. I have three cats that I love with all my heart.");
            Console.WriteLine("\t10.I have a girlfriend that I've been with since gradutating high school and she means the world to me.");
        }
    }
}
