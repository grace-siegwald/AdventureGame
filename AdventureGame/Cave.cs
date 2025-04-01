using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AdventureGame.Utility;

namespace AdventureGame
{
    class Cave : Location
    {
        // The cave has a troll in it. 
        static List<string> PossibleTrollNames = new List<string>()
        {
            "Gornak the Stonefist",
            "Throggar Mudshroud",
            "Karruk Blackclaw",
            "Gulkath the Grim",
            "Drogor Ironbellow",
            "Vrogg the Deepstalker",
            "Krullor the Caveheart",
            "Grokthar Bonecrusher",
            "Ulgoth Skullsplitter",
            "Balgor Rocktusk"
        };
        new NPC troll = new NPC()
        {
            NPCName = $"{PossibleTrollNames[GetRandomNumber(0, PossibleTrollNames.Count)]}"
        };
        new Item RedKey = new Item()
        {
            ItemName = "Red Key",
            ItemDescription = "A key... that's red..."
        };

        public Cave()
        {

        }

        public void VisitCave(string Job, List<Item> playerInventory) 
        {
            Console.Clear();
            if (Job == "Sorcerer")
            {
                Print("___________________________________________________________________________________________________");
                Print($"You step into the mouth of {LocationName}. Its walls are covered in brilliant red crystals. " +
                      $"\nAs you walk deeper, the light from the outside becomes dimmer, until eventually you cannot see a thing!");

            Choice1:
                while (true)
                {
                    DisplayItemChoices(playerInventory);
                    string choice1 = Console.ReadLine();
                    ClearLastInput(choice1);

                    if (choice1 == "1")
                    {
                        Use("Wand of Wonder");
                        Print("___________________________________________________________________________________________________");
                        PrintWithColor($"A flicker of light  sprouts from the tip of your wand. You're standing in a large grey cavern. " +
                              $"\nIt has been stripped of the beautiful red crystals that lined the cave's entrance.", "light", "DarkYellow");
                        PrintWithColor("\nBefore you stands a pile of those very red crystals. Atop this pile sits the Red ", "Red", "Red");
                        PrintWithColor("Key .\n", "Key", "Red");

                        List<string> choices2 = new List<string>() { "Take the Key!", "Look around some more..." };
                        DisplayChoices(choices2);

                    Choice2:
                        while (true)
                        {
                            string choice2 = Console.ReadLine();
                            ClearLastInput(choice2);

                            if (choice2 == "1")
                            {
                                Decide(choices2[0]);
                                Print("___________________________________________________________________________________________________");
                                Print($"As you step towards the key, you feel the breath of something behind you. You quickly turn around..." +
                                    "\nBefore you stands a Troll that is double your size!" +
                                    "\nThe Troll lets out a deep, gravelly laugh.");
                                PrintWithColor($"   Troll : \"You think you can just take the Red Key? I am {troll.NPCName}, Keeper of the Crystals! " +
                                    $"\n           \"No one takes my shiny red things without facing me!\"", "Troll", "Black");
                                Print("\nHe grips a massive club made of the same red crystals that once lined the cave." +
                                    "\nThe ground trembles as he takes a heavy step toward you.");

                            Choice3v1:
                                while (true)
                                {
                                    DisplayItemChoices(playerInventory);
                                    string choice3 = Console.ReadLine();
                                    ClearLastInput(choice3);

                                    if (choice3 == "1")
                                    {
                                        Use("Wand of Wonder");
                                        Print("___________________________________________________________________________________________________");
                                        Print("You raise the Wand of Wonder and give it a flick. A burst of wild magic crackles through the air!" +
                                            $"\nA thick cloud of golden dust explodes from the tip of the wand, swirling around {troll.NPCName}." +
                                            $"\nHe stumbles back, waving his arms.");
                                        PrintWithColor($"   Troll : \"Bah! What is this sorcery?!\"", "Troll", "Black");
                                        Print("\nHe sways, his eyes droop, and with a heavy thud—he collapses, fast asleep.");
                                        PrintWithColor($"   Troll : \"Tricksy little sorcerer...\" he mumbles before letting out a loud snore.", "Troll", "Black");
                                        PrintWithColor("\nYou step forward, climb the pile of crystals, and take the Red ", "Red", "Red");
                                        PrintWithColor("Key !", "Key", "Red");
                                        playerInventory.Add(RedKey);
                                        goto Overworld;
                                    }
                                    if (choice3 == "2")
                                    {
                                        Use("Never-ending Grimoire");
                                        Print("___________________________________________________________________________________________________");
                                        Print($"You open the Never-ending Grimoire, and the pages begin flipping on their own." +
                                            $"\nYou speak an incantation to life. Bright blue chains shoot from the book, wrapping tightly around {troll.NPCName}." +
                                            $"\nHe thrashes against them, but they do not budge.");
                                        PrintWithColor($"   Troll : \"Bah! You magic-users always have tricks\"", "Troll", "Black");
                                        Print($"\nThe chains fade, and {troll.NPCName} slumps to the ground, fast asleep.");
                                        PrintWithColor("\nYou step forward, climb the pile of crystals, and take the Red ", "Red", "Red");
                                        PrintWithColor("Key !", "Key", "Red");
                                        playerInventory.Add(RedKey);
                                        goto Overworld;
                                    }
                                    else
                                    {
                                        Print("Invalid input");
                                        TryAgain();
                                    }
                                }
                            }
                            if (choice2 == "2")
                            {
                                Decide(choices2[1]);
                                Print("___________________________________________________________________________________________________");
                                Print($"Just as you begin to look around the cavern, you feel the breath of something behind you. You quickly turn around..." +
                                    "\nBefore you stands a Troll that is double your size!" +
                                    "\nThe Troll lets out a deep, gravelly laugh.");
                                PrintWithColor($"   Troll : \"You think you can just take the Red Key? I am {troll.NPCName}, Keeper of the Crystals! " +
                                    $"\n           \"No one takes my shiny red things without facing me!\"", "Troll", "Black");
                                Print("\nHe grips a massive club made of the same red crystals that once lined the cave." +
                                    "\nThe ground trembles as he takes a heavy step toward you.");
                            
                            Choice3v2:
                                while (true)
                                {
                                    DisplayItemChoices(playerInventory);
                                    string choice3 = Console.ReadLine();
                                    ClearLastInput(choice3);

                                    if (choice3 == "1")
                                    {
                                        Use("Wand of Wonder");
                                        Print("___________________________________________________________________________________________________");
                                        Print("You raise the Wand of Wonder and give it a flick. A burst of wild magic crackles through the air!" +
                                            $"\nA thick cloud of golden dust explodes from the tip of the wand, swirling around {troll.NPCName}." +
                                            $"\nHe stumbles back, waving his arms.");
                                        PrintWithColor($"   Troll : \"Bah! What is this sorcery?!\"", "Troll", "Black");
                                        Print("\nHe sways, his eyes droop, and with a heavy thud—he collapses, fast asleep.");
                                        PrintWithColor($"   Troll : \"Tricksy little sorcerer...\" he mumbles before letting out a loud snore.", "Troll", "Black");
                                        PrintWithColor("\nYou step forward, climb the pile of crystals, and take the Red ", "Red", "Red");
                                        PrintWithColor("Key !", "Key", "Red");
                                        playerInventory.Add(RedKey);
                                        goto Overworld;
                                    }
                                    if (choice3 == "2")
                                    {
                                        Use("Never-ending Grimoire");
                                        Print("___________________________________________________________________________________________________");
                                        Print($"You open the Never-ending Grimoire, and the pages begin flipping on their own." +
                                            $"\nYou speak an incantation to life. Bright blue chains shoot from the book, wrapping tightly around {troll.NPCName}." +
                                            $"\nHe thrashes against them, but they do not budge.");
                                        PrintWithColor($"   Troll : \"Bah! You magic-users always have tricks\"", "Troll", "Black");
                                        Print($"The chains fade, and {troll.NPCName} slumps to the ground, fast asleep.");
                                        PrintWithColor("You step forward, climb the pile of crystals, and take the Red ", "Red", "Red");
                                        PrintWithColor("Key !", "Key", "Red");
                                        playerInventory.Add(RedKey);
                                        goto Overworld;
                                    }
                                    else
                                    {
                                        Print("Invalid input");
                                        TryAgain();
                                    }
                                }
                            }
                            else
                            {
                                Print("Invalid input");
                                TryAgain();
                            }
                        }
                    }
                    if (choice1 == "2")
                    {
                        Use("Never-ending Grimoire");
                        Print("___________________________________________________________________________________________________");
                        Print("You open the Grimoire to look for an incantation, but can't read anything because it's... dark. " +
                            "\nPerhaps the wand might be simpler?");
                        TryAgain();
                    }
                    else
                    {
                        Print("Invalid input");
                        TryAgain();
                    }
                }
            Overworld:;
            }
            if (Job == "Thief")
            {
                Warning("The scope of this project quickly spiraled out of control, so this section is not complete yet :(");
            }
            if (Job == "Bard")
            {
                Warning("The scope of this project quickly spiraled out of control, so this section is not complete yet :(");
            }
        }
    }
}
