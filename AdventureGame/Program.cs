namespace AdventureGame

/*
 * Adventure Game
 * Grace Siegwald
 * 2/18/2025
 */


/*
 * Gameplay:
 * - Enter a chosen location.
 * - Find that location's "key item" through a unique encounter based on the class you chose.
 *         - This key item acquisition should be tied to a randomly chosen encounter 
 *           that occurs each time you enter that location.
 *         - Each class has 3 possible encounters per location
 * - Visit all locations and get all key items, and the final location reveals itself.
 * - Complete a final encounter (from a randomized pool of final encounters).
 * - Beat the game!
 *
 * Locations:
 *   "Cave" prefix
 *      - Encounter a troll
 *   "Village" prefix
 *      - Encounter some mean villagers
 *   "Forest" prefix
 *      - Encounter some stubborn forest spirits
 *   "Castle" prefix
 *      - Final Area
 *      - Take the throne.
 *      
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
