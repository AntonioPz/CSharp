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
            Console.WriteLine("Inicilizando el auricular");
        }
        public void Marcando()
        {

            sound.URL = "llamando.mp3";
            sound.controls.play();
            Console.SetCursorPosition(27,7);
            Console.WriteLine("Llamando");
            Thread.Sleep(10000);
            sound.controls.stop();
        }

        public void contesta()
        {
            //Inicializar una nueva instancia de SpeechSynthesizer
            SpeechSynthesizer synth = new SpeechSynthesizer();

            //Configurar salida del audio
            synth.SetOutputToDefaultAudioDevice();

            //speak a string
            synth.Speak("si, bueno. quien habla?");
            Thread.Sleep(1000);


        }
        public void ocupado()
        {
            sound.URL = "ocupado.mp3";
            sound.controls.play();
            Thread.Sleep(5000);
            sound.controls.stop();
        }
        public void buzon()
        {
            sound.URL = "buzon.mp3";
            sound.controls.play();
            Thread.Sleep(5000);
            sound.controls.stop();
        }
    }
}
