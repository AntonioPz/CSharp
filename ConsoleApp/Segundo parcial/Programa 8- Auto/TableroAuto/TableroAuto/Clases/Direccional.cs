using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using TableroAuto.Clases;
using WMPLib;

namespace TableroAuto.Clases
{
    class Direccional
    {
        Tablero elTablero = new Tablero();
        private WindowsMediaPlayer sound = new WindowsMediaPlayer();


        public void IntermitenteIzquierda()
        {

            for (int i = 0; i < 5; i++)
            {


                Console.ForegroundColor = ConsoleColor.DarkYellow;

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

                Thread.Sleep(300);
                Console.ForegroundColor = ConsoleColor.Yellow;

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

                Thread.Sleep(300);
            }
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


        }
        public void IntermitenteDerecha()
        {
            for(int i=0;i<5;i++)
            {


                Console.ForegroundColor = ConsoleColor.DarkYellow;

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

                Thread.Sleep(300);
                 Console.ForegroundColor = ConsoleColor.Yellow;

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
                Thread.Sleep(300);


            }


            Console.ForegroundColor = ConsoleColor.Blue;

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
        }
        

    }
}

