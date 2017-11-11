using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using WMPLib;
using TableroAuto.Clases;

namespace TableroAuto.Clases
{
    class Motor
    {
        private WindowsMediaPlayer sound = new WindowsMediaPlayer();

        Tablero elTablero = new Tablero();
        public void EncenderMotor()
        {

            Console.Read();
            sound.URL = "arranque.mp3";
            sound.controls.play();
            elTablero.EntornoTableroEncendido();
            Thread.Sleep(5000);
            sound.controls.stop();


        }
    }
}
