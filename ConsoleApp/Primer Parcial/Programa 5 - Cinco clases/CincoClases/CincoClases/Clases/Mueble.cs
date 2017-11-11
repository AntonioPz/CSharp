using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CincoClases.Clases
{
    class Mueble
    {
        //atributos
        public string tipoMueble;
        public string maderaMueble;
        public string colorMueble;
        public string tamañoMueble;
        public double precioMueble;

        //métodos
        public void setTipoMueble(string tipo)
        {
            tipoMueble = tipo;
        }
        public string getTipoMueble()
        {
            return tipoMueble;
        }
        public void setMaderaMueble(string madera)
        {
            maderaMueble = madera;
        }
        public string  getMaderaMueble()
        {
            return maderaMueble;
        }
        public void setColorMueble(string color)
        {
            colorMueble = color;
        }
        public string getColorMueble()
        {
            return colorMueble; 
        }
        public void setTamañoMueble(string tamaño)
        {
            tamañoMueble = tamaño;
        }
        public string getTamañoMueble()
        {
            return tamañoMueble;
        }
        public void setPrecioMueble(Double precio)
        {
            precioMueble = precio;
        }
        public double getPrecioMueble()
        {
            return precioMueble;
        }
    }
}

















