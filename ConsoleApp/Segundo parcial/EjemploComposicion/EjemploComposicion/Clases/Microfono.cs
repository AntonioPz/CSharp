using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using System.Threading;

namespace EjemploComposicion.Clases
{
    class Microfono
    {
        //atrubutos
        //métodos
        //contructor por defecto
        private WindowsMediaPlayer sound = new WindowsMediaPlayer();



        public Microfono()
        {
            Console.WriteLine("Iniicializando el microfono");
        }
        public void contesta()
        {
            sound.URL = "titular.mp3";
            sound.controls.play();
            Thread.Sleep(5000);
            sound.controls.stop();
        }
    }
}
