using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafetera.Clases
{
    class Agua
    {
        //atributo
        private int cantidadAgua;
        //método
        //constructor por defecto
        public Agua()
        {
            this.cantidadAgua = 1000;
        }
        public void setCantidadAgua(int cantidadAgua)
        {
            this.cantidadAgua = cantidadAgua;
        }

        public int getCantidadAgua()
        {
            return cantidadAgua;
        }
    }
}
