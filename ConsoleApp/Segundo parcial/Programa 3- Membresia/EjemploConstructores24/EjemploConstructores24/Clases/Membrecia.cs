using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploConstructores24.Clases
{
    class Membrecia
    {
        // Atributos
        public int idMembrecia;
        public string nombreAsociado;
        public double costoMembrecia;
        
        // Métodos


        // Constructores
        public Membrecia()
        {
            
            // Para generar un numero entero aleatorio
            Random objetoAzar = new Random();
            this.idMembrecia = objetoAzar.Next();
        }
        public Membrecia(string nombreAsociado, double costoMembrecia)
        {
            this.nombreAsociado = nombreAsociado;
            this.costoMembrecia = costoMembrecia;
            // Para generar un numero entero aleatorio
            Random objetoAzar = new Random();
            this.idMembrecia = objetoAzar.Next();
        }
        public Membrecia(string nombreAsociado, double costoMembrecia,int idMembrecia)
        {
            this.nombreAsociado = nombreAsociado;
            this.costoMembrecia = costoMembrecia;         
            this.idMembrecia = idMembrecia;
        }


        public int getIdMembrecia()
        {
            return idMembrecia;
        }
        public string getNombreAsociado()
        {
            return nombreAsociado;
        }
        public double getCostoMembrecia()
        {
            return costoMembrecia;
        }
    }
}
