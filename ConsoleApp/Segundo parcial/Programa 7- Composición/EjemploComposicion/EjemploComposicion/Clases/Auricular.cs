using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using System.Threading;
using System.Speech.Synthesis;

namespace EjemploComposicion.Clases
{
    class Auricular
    {
        private Microfono elMicrofono = new Microfono();
        //atributos
        private WindowsMediaPlayer sound = new WindowsMediaPlayer();
        //métodos
        //constructor por defecto
        //int casos;

        public Auricular()
        {
            //Console.WriteLine("Inicilizando el auricular");
        }
        //Inicializar una nueva instancia de SpeechSynthesizer
        SpeechSynthesizer synth = new SpeechSynthesizer();
        public void Marcando()
        {
            Console.SetCursorPosition(5,5);
            Console.WriteLine("Llamando:");

            

            int op = new Random(DateTime.Now.Millisecond).Next(1,4);
            switch (op)
            {
                case 1:
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("Llamando:");
                    sound.URL = "llamando.mp3";
                    sound.controls.play();

                    for (int i = 0; i < 2; i++)
                    {
                        Console.SetCursorPosition(14, 5);
                        Console.Write("           ");
                        Console.SetCursorPosition(14, 5);

                        for (int j = 0; j < 3; j++)
                        {
                            Thread.Sleep(500);
                            Console.Write(" .");
                            Thread.Sleep(500);
                            Console.Write(" ");
                        }
                    }
                    sound.controls.stop();

                    Console.SetCursorPosition(5, 5);
                    Console.Write("Hablando:      ");

                    sound.URL = "telmex.mp3";
                    sound.controls.play();
                    Console.ReadLine();
                    sound.controls.stop();

                    Console.SetCursorPosition(15, 5);
                    Console.Write("           ");
                    Console.SetCursorPosition(15, 5);
                    for (int i = 0; i < 60; i++)
                    {
                        Console.Write(i+":");
                        for (int j = 0; j < 60; j++)
                        {
                            Console.SetCursorPosition(17, 5);
                            Thread.Sleep(1000);
                            Console.Write(j);
                        }
                    }
                    
                    //synth.SetOutputToDefaultAudioDevice();
                    //speak a string
                    //Thread.Sleep(5000);
                    //sound.controls.stop();
                    //synth.Speak("si, bueno ?");
                    //Console.SetCursorPosition(0,25);

                    break;

                case 2:
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("Ocupado:           ");
                    sound.URL = "ocupado.mp3";
                    sound.controls.play();
                    Console.SetCursorPosition(14, 5);
                    Thread.Sleep(5000);
                    sound.controls.stop();
                    Console.SetCursorPosition(0,25);
                    break;
                case 3:
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("Buzón de voz:       ");
                    sound.URL = "buzon.mp3";
                    sound.controls.play();
                    Thread.Sleep(5000);
                    sound.controls.stop();
                    Console.SetCursorPosition(0,25);

                    break;
            }
            
        
                           

        }
        
    }
}
