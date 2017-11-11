using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafetera.Clases
{
    class Cafe
    {
        //atributos
        private int cantidadCafe;
        //métodos
        public Cafe()
        {
            this.cantidadCafe = 500;
        }
        public void setCantidadCafe(int cantidadCafe)
        {
            this.cantidadCafe = cantidadCafe;
        }
        public int getCantidadCafe()
        {
            return cantidadCafe;
        }
    }
}
