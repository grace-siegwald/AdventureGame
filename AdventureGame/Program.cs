namespace AdventureGame

/*
 * Adventure Game
 * Grace Siegwald
 * 2/18/2025
 */


/*
 * Gameplay Loop:
 * - Enter a chosen location.
 * - Find that location's "key item" in a unique way based on the class you chose.
 *         This key item aquisition should be tied to a randomly chosen "event" or "encounter" 
 *         that occurs each time you enter that location.
 * - Visit all locations and get all key items, and the final location reveals itself.
 * - Complete a final encounter (from a randomized pool of final encounters).
 * - Beat the game!
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
