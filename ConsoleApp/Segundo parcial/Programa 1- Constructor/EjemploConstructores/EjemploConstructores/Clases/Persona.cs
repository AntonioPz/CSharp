using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploConstructores.Clases
{
    class Persona
    {
        //atributos
        public int edadPersona;
        public string nombrePersona;
        public double sueldoPersona;
        //metodos   
        //metodo constructor por defecto 
        public Persona()
        {
            this.sueldoPersona = 1499.85;
            
        }
        // Método constructor con base de parametros
        public Persona(string nombrePersona, double sueldoPersona)
        {
            this.nombrePersona = nombrePersona;
            this.sueldoPersona = sueldoPersona;
        }
        public void setEdadPersona(int edad)
        {
            this.edadPersona=edad;
        }
        public int getEdadPersona()
        {
            return edadPersona;
        }
        public string getNombrePersona()
        {
            return nombrePersona;
        }
        public double getSueldoPersona()
        {
            return sueldoPersona;
        }
    }
}
