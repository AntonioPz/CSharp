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
    class Acelerador
    {

        private WindowsMediaPlayer sound = new WindowsMediaPlayer();

        public void Acelerar()
        {

            Direccional laDireccional = new Direccional();
            Volante elVolante = new Volante();

            int velocidad = 0;
            


            do
            {
                ConsoleKeyInfo kb = Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(44, 20);
                if (kb.Key== ConsoleKey.I)
                {
                    sound.URL = "Inter.mp3";
                    sound.controls.play();
                    laDireccional.IntermitenteIzquierda();
                    sound.controls.stop();
                }
                else if (kb.Key == ConsoleKey.D)
                {
                    sound.URL = "Inter.mp3";
                    sound.controls.play();
                    laDireccional.IntermitenteDerecha();
                    sound.controls.stop();
                }

                switch (kb.Key)
                {
                    case ConsoleKey.LeftArrow:
                        elVolante.MensajeDeDireccionIzquierda();
                        velocidad--;
                        Console.WriteLine();
                        Thread.Sleep(150);
                        Console.SetCursorPosition(44, 20);
                        Console.WriteLine(velocidad + " Km/h ");


                        break;
                    case ConsoleKey.RightArrow:
                        elVolante.MensajeDeDireccionDerecha();
                        velocidad--;
                        Thread.Sleep(150);
                        Console.SetCursorPosition(44, 20);
                        Console.WriteLine(velocidad + " Km/h ");

                        break;
                    case ConsoleKey.UpArrow:
                        if (velocidad <=120)
                        {
                            velocidad++;
                            Thread.Sleep(100);
                            Console.SetCursorPosition(44, 20);
                            Console.WriteLine(velocidad + " Km/h");


                            if (velocidad==10)
                            {
                                Console.SetCursorPosition(100, 15);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                
                                Console.SetCursorPosition(100, 16);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(100, 17);
                                Console.WriteLine(velocidad);
                                Console.SetCursorPosition(98, 18);
                                Console.WriteLine("km/h");




                            }
                            else if (velocidad==20)
                            {
                                
                                Console.ForegroundColor = ConsoleColor.Green;

                                Console.SetCursorPosition(104, 15);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(104, 16);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(104,17);
                                Console.WriteLine(velocidad);
                            }

                            else if (velocidad == 30)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;

                                Console.SetCursorPosition(108, 14);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(108, 15);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(108, 16);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(108, 17);
                                Console.WriteLine(velocidad);
                            }

                            else if (velocidad == 40)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;

                                Console.SetCursorPosition(112, 13);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(112, 14);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(112, 15);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(112, 16);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(112, 17);
                                Console.WriteLine(velocidad);
                            }
                            if (velocidad==50)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.SetCursorPosition(116, 12);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(116, 13);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(116, 14);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(116, 15);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(116, 16);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(116, 17);
                                Console.WriteLine(velocidad);
                            }

                            if (velocidad == 60)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.SetCursorPosition(120, 11);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(120, 12);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(120, 13);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(120, 14);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(120, 15);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(120, 16);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(120, 17);
                                Console.WriteLine(velocidad);
                            }

                            if (velocidad == 70)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.SetCursorPosition(124, 10);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(124, 11);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(124, 12);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(124, 13);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(124, 14);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(124, 15);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(124, 16);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(124, 17);
                                Console.WriteLine(velocidad);
                            }
                            if (velocidad == 80)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.SetCursorPosition(128, 9);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(128, 10);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(128, 11);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(128, 12);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(128, 13);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(128, 14);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(128, 15);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(128, 16);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(128, 17);
                                Console.WriteLine(velocidad);

                            }
                            if (velocidad == 90)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(132, 8);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(132, 9);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(132, 10);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(132, 11);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(132, 12);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(132, 13);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(132, 14);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(132, 15);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(132, 16);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(132, 17);
                                Console.WriteLine(velocidad);

                            }
                            if (velocidad == 100)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.SetCursorPosition(136, 7);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(136, 8);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(136, 9);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(136, 10);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(136, 11);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(136, 12);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(136, 13);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(136, 14);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(136, 15);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(136, 16);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(136, 17);
                                Console.WriteLine(velocidad);
                            }
                            if (velocidad == 110)
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.SetCursorPosition(140, 6);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(140, 7);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(140, 8);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(140, 9);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(140, 10);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(140, 11);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(140, 12);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(140, 13);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(140, 14);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(140, 15);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(140, 16);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(140, 17);
                                Console.WriteLine(velocidad);
                            }
                            if (velocidad == 120)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.SetCursorPosition(144, 5);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(144, 6);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(144, 7);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(144, 8);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(144, 9);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(144, 10);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(144, 11);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(144, 12);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(144, 13);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(144, 14);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(144, 15);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(144, 16);
                                Console.WriteLine("**");
                                Console.SetCursorPosition(144, 17);
                                Console.WriteLine(velocidad);
                            }

                        }
                        

                        break;
                    case ConsoleKey.DownArrow:


                        velocidad--;
                        Thread.Sleep(150);
                        Console.SetCursorPosition(44, 20);
                        Console.WriteLine(velocidad + " Km/h  ");

                        break;
                    case ConsoleKey.F:

                        sound.URL = "frenar.mp3";
                        sound.controls.play();
                        Console.SetCursorPosition(44, 20);
                        Console.WriteLine(" 0" + " Km/h  ");
                        Thread.Sleep(5000);
                        sound.controls.stop();
                        velocidad = 0;

                        break;


                }

            } while (true);

            

        
            
        }
    }
}
