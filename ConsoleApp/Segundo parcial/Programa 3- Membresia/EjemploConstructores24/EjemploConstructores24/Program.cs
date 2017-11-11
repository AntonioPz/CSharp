using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjemploConstructores24.Clases;

namespace EjemploConstructores24
{
    class Program
    {
        static void Main(string[] args)
        {
            Membrecia nuevaMembrecia = new Membrecia();
            Console.WriteLine("El id de la membresia es: "+ nuevaMembrecia.getIdMembrecia());


            Membrecia otraMembrecia = new Membrecia("Antonio", 199.99);
            Console.WriteLine("El id de la membresia es: " + otraMembrecia.getIdMembrecia());
            Console.WriteLine("El nombre del asociado es " + otraMembrecia.getNombreAsociado());
            Console.WriteLine("El costo de la membrecia es: $" + otraMembrecia.getCostoMembrecia());

           
            Membrecia otraMembreciaMas = new Membrecia("Antonio", 199.99,new Membrecia().getIdMembrecia());
            Console.WriteLine("El id de la membresia es: " + otraMembreciaMas.getIdMembrecia());
            Console.WriteLine("El nombre del asociado es " + otraMembreciaMas.getNombreAsociado());
            Console.WriteLine("El costo de la membrecia es: $" + otraMembreciaMas.getCostoMembrecia());



            Console.Read();





        }
       
    }
}
