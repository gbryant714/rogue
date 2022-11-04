using System;
using Figgle;
using Rogue.Services;
using Rogue.Records;

/*Stop making lame round trips from Wowhead to Wowsims to IcyVeins and back...
 * Compiling and keeping all rogue information here for your convenience!
 * Request bis list, optional bis by slot, stat priority, hit cap, exp cap... */
public class RogueEngine
{
    static void Main()
    {

        string greeting = "Rogue Engine";

        //hide all this junk in config/json file 
        Console.WriteLine(FiggleFonts.Slant.Render(greeting));
        Console.WriteLine("Make your request... \r\n" +
                          "1. BIS List by Spec \r\n" +
                          "2. BIS for an item slot \r\n" +
                          "3. Stat Priority for my spec \r\n" +
                          "4. Wowhead build for X spec \r\n" +
                          "5. Should I roll? \r\n" +
                          "6. Sim my current gear \r\n" +
                          "7. Update my gear \r\n" +
                          "8. My last parse for boss X (WiP)");

        var opt = Console.ReadKey().KeyChar;

        switch (opt)
        {
            case '1':
                Console.Clear();
                Console.WriteLine(FiggleFonts.Slant.Render("BIS List"));
                break;
            case '2':
                Console.Clear();
                Console.WriteLine(FiggleFonts.Slant.Render("BIS by Slot"));
                Console.WriteLine("ENTER YOUR SPEC: \r\n" +
                                    "1. Assassination \r\n" +
                                    "2. Combat Swords \r\n" +
                                    "3. Subtlety PvE (wyd?) \r\n" +
                                    "4. Subtlety PvP");
                Console.ReadKey();
                break;
            case '5':
                Console.Clear();
                Console.WriteLine("Enter partial or full item name: \r\n");
                var item = Console.ReadLine();
                break;
            default:
                break;
        }
    }
}