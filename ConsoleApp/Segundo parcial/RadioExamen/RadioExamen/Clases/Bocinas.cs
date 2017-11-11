using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMPLib;
using System.Threading.Tasks;

namespace RadioExamen.Clases
{
    class Bocinas
    {
        private WindowsMediaPlayer sound = new WindowsMediaPlayer();


        public void ReproducirCancion()
        {

            int n = 0;
        
            for (int i = 0; i < 19; i++)
            {
                ConsoleKeyInfo kb = Console.ReadKey();
                
                if (kb.Key==ConsoleKey.RightArrow & n < 11)
                {                    
                    n++;
                }
                else
                {
                    i--;
                }

                if (kb.Key == ConsoleKey.LeftArrow & n > 0)
                {
                    n--;
                }
                else
                    i--;

                switch (n)
                {
                    case 1:
                        Console.SetCursorPosition(45,18);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("1");
                        sound.URL = "videoplayback (1).mp3";
                        sound.controls.play();
                        break;
                    case 2:          
                        Console.SetCursorPosition(45,18);
                        Console.Write("2");
                        sound.URL = "videoplayback (2).mp3";
                        sound.controls.play();
                        break;
                    case 3:
                        Console.SetCursorPosition(45, 18);
                        Console.Write("3");
                        sound.URL = "videoplayback (3).mp3";
                        sound.controls.play();
                        break;
                    case 4:
                        Console.SetCursorPosition(45, 18);
                        Console.Write("4");
                        sound.URL = "videoplayback (4).mp3";
                        sound.controls.play();
                        break;
                    case 5:
                        Console.SetCursorPosition(45, 18);
                        Console.Write("5");
                        sound.URL = "videoplayback (5).mp3";
                        sound.controls.play();
                        break;
                    case 6:
                        Console.SetCursorPosition(45, 18);
                        Console.Write("6");
                        sound.URL = "videoplayback (6).mp3";
                        sound.controls.play();
                        break;
                    case 7:
                        Console.SetCursorPosition(45, 18);
                        Console.Write("7");
                        sound.URL = "videoplayback (7).mp3";
                        sound.controls.play();
                        break;
                    case 8:
                        Console.SetCursorPosition(45, 18);
                        Console.Write("8");
                        sound.URL = "videoplayback (8).mp3";
                        sound.controls.play();
                        break;
                    case 9:
                        Console.SetCursorPosition(45, 18);
                        Console.Write("9 ");
                        sound.URL = "videoplayback (9).mp3";
                        sound.controls.play();
                        break;
                    case 10:
                        Console.SetCursorPosition(45, 18);
                        Console.Write("10");
                        sound.URL = "videoplayback (10).mp3";
                        sound.controls.play();
                        break;
                }

                if (kb.Key == ConsoleKey.S)
                {
                    i--;
                    Console.SetCursorPosition(45, 18);
                    Console.Write("s");
                    sound.controls.stop();
                            
                }

            }

        }
    }
}
