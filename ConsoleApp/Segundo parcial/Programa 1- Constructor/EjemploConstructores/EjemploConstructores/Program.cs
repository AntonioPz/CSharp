using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjemploConstructores.Clases;

namespace EjemploConstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona miPersonaEmpleado = new Persona();

            miPersonaEmpleado.setEdadPersona(25);

            Console.WriteLine("La edad del empleado es: " +
                miPersonaEmpleado.getEdadPersona());
            Console.WriteLine("El sueldo del empleado es: " +
                miPersonaEmpleado.getSueldoPersona());

            Persona miPersonaGerente = new Persona("Felipe", 1897.56);

            miPersonaGerente.setEdadPersona(38);
            Console.WriteLine("El gerente tiene una edad de: " +
                miPersonaGerente.getEdadPersona());
            Console.WriteLine("El nombre del gerente es: " +
                miPersonaGerente.getNombrePersona());
            Console.WriteLine("El sueldo del gerente es: $" +
                miPersonaGerente.getSueldoPersona());

            Console.Read();

        }
    }
}
