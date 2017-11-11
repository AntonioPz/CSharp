using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace TableroAuto.Clases
{
    class Tablero
    {
        public void EntornoTablero()
        {
            //Flecha izquierda


            Console.SetCursorPosition(10, 25);
            Console.WriteLine("     v/           ");
            Console.SetCursorPosition(10, 26);
            Console.WriteLine("   +mMN           ");
            Console.SetCursorPosition(10, 27);
            Console.WriteLine(".sNMMMMMMMMMM");
            Console.SetCursorPosition(10, 28);
            Console.WriteLine("`omMMMMMMMMMM");
            Console.SetCursorPosition(10, 29);
            Console.WriteLine("  `+mMh           ");
            Console.SetCursorPosition(10, 30);
            Console.WriteLine("    `v\\           ");

            //Flecha derecha

            Console.SetCursorPosition(100, 25);
            Console.WriteLine("      \\v,   ");
            Console.SetCursorPosition(100, 26);
            Console.WriteLine("      NMm+   ");
            Console.SetCursorPosition(100, 27);
            Console.WriteLine("NMMMMMMMMMMs.");
            Console.SetCursorPosition(100, 28);
            Console.WriteLine("MMMMMMMMMMmo´");
            Console.SetCursorPosition(100, 29);
            Console.WriteLine("      hMm+´  ");
            Console.SetCursorPosition(100, 30);
            Console.WriteLine("      /v´    ");

            // Tacometro

            Console.SetCursorPosition(35, 15);
            Console.WriteLine("      .:shmmdddmms:.     ");
            Console.SetCursorPosition(35, 16);
            Console.WriteLine("    +mms: - 70  - :smm.  ");
            Console.SetCursorPosition(35, 17);
            Console.WriteLine("  .dNo` 50      90 `oNd. ");
            Console.SetCursorPosition(35, 18);
            Console.WriteLine("  hM/ -            - /Mh ");
            Console.SetCursorPosition(35, 19);
            Console.WriteLine(" .Md  30    O     110 dM.");
            Console.SetCursorPosition(35, 20);
            Console.WriteLine(" .Md -     /        - dM.");
            Console.SetCursorPosition(35, 21);
            Console.WriteLine("  hM/ 10 ./      120 /Mh ");
            Console.SetCursorPosition(35, 22);
            Console.WriteLine("    `nmshmmdddmmhsmmm'   ");

            //Volante
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.SetCursorPosition(45, 20);
            Console.WriteLine("           `-//+oo+++/:.           ");
            Console.SetCursorPosition(45, 21);
            Console.WriteLine("       `:oyhhhdhhyyhhhhhhs/`       ");
            Console.SetCursorPosition(45, 22);
            Console.WriteLine("smnsm.ohddho:.`      .:+yddds-     ");
            Console.SetCursorPosition(45, 23);
            Console.WriteLine("   `sddmo.               .+mdds`   ");
            Console.SetCursorPosition(45, 24);
            Console.WriteLine("  .ddmmds:`             `:sdmmdd-  ");
            Console.SetCursorPosition(45, 25);
            Console.WriteLine(" .ddNddmmmmho:`     `-+yddddhhmdm. ");
            Console.SetCursorPosition(45, 26);
            Console.WriteLine(" ydmhshdhhhdmmmhssshddddhhyhyohNdy ");
            Console.SetCursorPosition(45, 27);
            Console.WriteLine("`mdN.  .+yhyyhmdhhhdmhyyys/.  `NdN`");
            Console.SetCursorPosition(45, 28);
            Console.WriteLine(".Ndm`     ./ydddddddmdy/.      mmN-");
            Console.SetCursorPosition(45, 29);
            Console.WriteLine("`mdN-       `smddddmNo`       `mdN`");
            Console.SetCursorPosition(45, 30);
            Console.WriteLine(" smmy         ydddmmy         ommy ");
            Console.SetCursorPosition(45, 31);
            Console.WriteLine(" `ddNo        +hhhdd+        /mdm. ");
            Console.SetCursorPosition(45, 32);
            Console.WriteLine("  `hdmy.      :hhhdd/      `omdd.  ");
            Console.SetCursorPosition(45, 33);
            Console.WriteLine("   `odmms.    -dhhdm:    .oddms`   ");
            Console.SetCursorPosition(45, 34);
            Console.WriteLine("     .oddmho:./dhhddo.:oyddds.     ");
            Console.SetCursorPosition(45, 35);
            Console.WriteLine("       `/shdddmddddddddddy/`       ");
            Console.SetCursorPosition(45, 36);
            Console.WriteLine("          `.:+osyyyss+/-`          ");

        }

            public void EntornoTableroEncendido()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.SetCursorPosition(10, 25);

            Console.WriteLine("     v/           ");
            Console.SetCursorPosition(10, 26);
            Console.WriteLine("   +mMN           ");
            Console.SetCursorPosition(10, 27);
            Console.WriteLine(".sNMMMMMMMMMM");
            Console.SetCursorPosition(10, 28);
            Console.WriteLine("`omMMMMMMMMMM");
            Console.SetCursorPosition(10, 29);
            Console.WriteLine("  `+mMh           ");
            Console.SetCursorPosition(10, 30);
            Console.WriteLine("    `v\\           ");

            //Flecha derecha

            Console.SetCursorPosition(100, 25);
            Console.WriteLine("      \\v,   ");
            Console.SetCursorPosition(100, 26);
            Console.WriteLine("      NMm+   ");
            Console.SetCursorPosition(100, 27);
            Console.WriteLine("NMMMMMMMMMMs.");
            Console.SetCursorPosition(100, 28);
            Console.WriteLine("MMMMMMMMMMmo´");
            Console.SetCursorPosition(100, 29);
            Console.WriteLine("      hMm+´  ");
            Console.SetCursorPosition(100, 30);
            Console.WriteLine("      /v´    ");

            // Tacometro

            Console.SetCursorPosition(35, 15);
            Console.WriteLine("      .:shmmdddmms:.     ");
            Console.SetCursorPosition(35, 16);
            Console.WriteLine("    +mms: - 70  - :smm.  ");
            Console.SetCursorPosition(35, 17);
            Console.WriteLine("  .dNo` 50      90 `oNd. ");
            Console.SetCursorPosition(35, 18);
            Console.WriteLine("  hM/ -            - /Mh ");
            Console.SetCursorPosition(35, 19);
            Console.WriteLine(" .Md  30    O     110 dM.");
            Console.SetCursorPosition(35, 20);
            Console.WriteLine(" .Md -     /        - dM.");
            Console.SetCursorPosition(35, 21);
            Console.WriteLine("  hM/ 10 ./      120 /Mh ");
            Console.SetCursorPosition(35, 22);
            Console.WriteLine("    `nmshmmdddmmhsmmm'   ");
            //Volante

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(45, 20);
            Console.WriteLine("           `-//+oo+++/:.           ");
            Console.SetCursorPosition(45, 21);
            Console.WriteLine("       `:oyhhhdhhyyhhhhhhs/`       ");
            Console.SetCursorPosition(45, 22);

            Console.ForegroundColor=ConsoleColor.Blue;
            Console.Write("smnsm");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(".ohddho:.`      .:+yddds-     ");
            Console.SetCursorPosition(45, 23);
            Console.WriteLine("   `sddmo.               .+mdds`   ");
            Console.SetCursorPosition(45, 24);
            Console.WriteLine("  .ddmmds:`             `:sdmmdd-  ");
            Console.SetCursorPosition(45, 25);
            Console.WriteLine(" .ddNddmmmmho:`     `-+yddddhhmdm. ");
            Console.SetCursorPosition(45, 26);
            Console.WriteLine(" ydmhshdhhhdmmmhssshddddhhyhyohNdy ");
            Console.SetCursorPosition(45, 27);
            Console.WriteLine("`mdN.  .+yhyyhmdhhhdmhyyys/.  `NdN`");
            Console.SetCursorPosition(45, 28);
            Console.WriteLine(".Ndm`     ./ydddddddmdy/.      mmN-");
            Console.SetCursorPosition(45, 29);
            Console.WriteLine("`mdN-       `smddddmNo`       `mdN`");
            Console.SetCursorPosition(45, 30);
            Console.WriteLine(" smmy         ydddmmy         ommy ");
            Console.SetCursorPosition(45, 31);
            Console.WriteLine(" `ddNo        +hhhdd+        /mdm. ");
            Console.SetCursorPosition(45, 32);
            Console.WriteLine("  `hdmy.      :hhhdd/      `omdd.  ");
            Console.SetCursorPosition(45, 33);
            Console.WriteLine("   `odmms.    -dhhdm:    .oddms`   ");
            Console.SetCursorPosition(45, 34);
            Console.WriteLine("     .oddmho:./dhhddo.:oyddds.     ");
            Console.SetCursorPosition(45, 35);
            Console.WriteLine("       `/shdddmddddddddddy/`       ");
            Console.SetCursorPosition(45, 36);
            Console.WriteLine("          `.:+osyyyss+/-`          ");
        }
         

         

        
            

        }
    }

