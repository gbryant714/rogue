using System;
using Figgle;

/*Stop making lame round trips from Wowhead to Wowsims to IcyVeins and back...
 * Compiling and keeping all rogue information here for your convenience!
 * Request bis list, optional bis by slot, stat priority, hit cap, exp cap... */

string greeting = "Rogue";

//hide all this junk in config/json file 
Console.WriteLine(FiggleFonts.Slant.Render(greeting));
Console.WriteLine("Make your request... \r\n" +
                  "1. BIS List by Spec \r\n" +
                  "2. BIS for an item slot \r\n" +
                  "3. Stat Priority for my spec \r\n" +
                  "4. My last parse for boss X (WiP)");