namespace AdventureGame

/*
 * Adventure Game
 * Grace Siegwald
 * 2/18/2025
 * 
 * I used ChatGPT to help write the "ClearLastInput" method in the Utility class. Here is the prompt that I used:
 *          
 *          ** I pasted the current iteration of the "VisitCave" method from the Cave class, then asked the following question **
 *          When the player inputs a choice, I want that input to disappear, leaving an empty space. How would I do that? 
 *                 
 * And this is the response I got from ChatGPT:         
 *          
 *          To make the player's input disappear after they enter a choice, you can overwrite the input line using 
 *          Console.SetCursorPosition and Console.Write or simply clear the console and reprint the relevant information.
 *
 *          Solution: Overwriting Input
 *          This method moves the cursor back to the input position and replaces the text with spaces.
 *          
 *          -------------------------------------------------------------------------------------------
 *          string choice1 = Console.ReadLine();
 *
 *          // Move cursor up one line (if possible) and clear the input
 *          if (choice1.Length > 0)
 *          {
 *              Console.SetCursorPosition(0, Console.CursorTop - 1);
 *              Console.Write(new string(' ', Console.WindowWidth)); // Overwrite input line
 *              Console.SetCursorPosition(0, Console.CursorTop - 1); // Reset cursor position
 *          }
 *          -------------------------------------------------------------------------------------------
 */

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            World world = new World();
            world.Setup();
        }
    }
}
