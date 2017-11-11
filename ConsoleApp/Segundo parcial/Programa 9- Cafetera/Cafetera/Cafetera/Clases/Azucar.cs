using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafetera.Clases
{
    class Azucar
    {
        //Atributos
        private int cantidadAzucar;
        //Métodos
        //constructor por defecto
        public Azucar()
        {
            this.cantidadAzucar = 500;
        }
        public void setCantidadAzucar(int cantidadAzucar)
        {
            this.cantidadAzucar = cantidadAzucar;
        }
        public int getCantidadAzucar()
        {
            return cantidadAzucar;
        }
    }
}
