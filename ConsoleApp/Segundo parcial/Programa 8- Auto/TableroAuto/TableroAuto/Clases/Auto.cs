using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableroAuto.Clases;

namespace TableroAuto.Clases
{
    class Auto
    {
        private Motor elMotor = new Motor();
        private Tablero elTablero = new Tablero();
        private Acelerador elAcelerador =new Acelerador();
        private Volante elVolante = new Volante();
        private Direccional laDireccional = new Direccional();

        public void EncenderAuto()
        {
            elTablero.EntornoTablero();
            elMotor.EncenderMotor();
            elAcelerador.Acelerar();

        }

    }
}
