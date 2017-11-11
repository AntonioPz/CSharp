using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.Clases;
namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduce nombre del empleado");
            string nom = Console.ReadLine();
            Console.WriteLine();


            Empleado empleado1 = new Empleado();
            empleado1.setNombre(nom);
            empleado1.setCuotaHora(100);
            empleado1.setNumeroHoras(8);

            empleado1.setSueldo(
            empleado1.getCuotaHora() *
            empleado1.getNumeroHoras());

            Console.WriteLine("Empleado: " + empleado1.getNombre());
            
            Console.WriteLine("Sueldo: " + empleado1.getSueldo());
            Console.Read();

               

        }
    }
}
