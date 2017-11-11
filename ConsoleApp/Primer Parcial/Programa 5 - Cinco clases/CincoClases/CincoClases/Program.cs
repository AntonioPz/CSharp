using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CincoClases.Clases;

namespace CincoClases
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar la clase
            Producto miProducto = new Producto();
            miProducto.setNombreProducto("Chips");
            miProducto.setCodigoProducto(174625);
            miProducto.setContenidoProducto("45 g");
            miProducto.setMarcaProducto("Barcel");
            miProducto.setPrecioProducto(9);

            Console.WriteLine(miProducto.getNombreProducto());
            Console.WriteLine(miProducto.getMarcaProducto());
            Console.WriteLine(miProducto.getContenidoProducto());
            Console.WriteLine(miProducto.getCodigoProducto());
            Console.WriteLine(miProducto.getPrecioProducto());
            Console.WriteLine();


            Mueble miMueble = new Mueble();
            miMueble.setTipoMueble("Mesa");
            miMueble.setMaderaMueble("Roble");
            miMueble.setColorMueble("Rojo claro");
            miMueble.setTamañoMueble("Largo: 2 m, Ancho: 1.2 m, Alto: 1 m");
            miMueble.setPrecioMueble(7000);
            Console.WriteLine(miMueble.getTipoMueble());
            Console.WriteLine(miMueble.getMaderaMueble());
            Console.WriteLine(miMueble.getColorMueble());
            Console.WriteLine(miMueble.getTamañoMueble());
            Console.WriteLine(miMueble.getPrecioMueble());
            Console.WriteLine();

            Auto miAuto = new Auto();
            miAuto.setMarcaAuto("Porshe");
            miAuto.setModeloAuto("Carrera GT");
            miAuto.setTipoAuto("Deportivo");
            miAuto.setNumeroSerie(9450439);
            miAuto.setPlacasAuto("I like NFSMW");
            Console.WriteLine(miAuto.getMarcaAuto());
            Console.WriteLine(miAuto.getModeloAuto());
            Console.WriteLine(miAuto.getTipoAuto());
            Console.WriteLine(miAuto.getNumeroSerie());
            Console.WriteLine(miAuto.getPlacasAuto());
            Console.WriteLine();


            Libro miLibro = new Libro();
            miLibro.setNombreLibro("Dracula");
            miLibro.setAutorLibro("Bram stoker");
            miLibro.setEditorialLibro("Contable & Robimson");
            miLibro.setPrecioLibro(300);
            miLibro.setDescuentoLibro("10 %");
            Console.WriteLine(miLibro.getNombreLibro());
            Console.WriteLine(miLibro.getAutorLibro());
            Console.WriteLine(miLibro.getEditorialLibro());
            Console.WriteLine(miLibro.getPrecioLibro());
            Console.WriteLine(miLibro.getDescuentoLibro());
            Console.WriteLine();

            Alumno miAlumno = new Alumno();
            miAlumno.setNombreAlumno("Kevin Melo R.");
            miAlumno.setParcialUno(8);
            miAlumno.setParcialDos(7);
            miAlumno.setParcialTres(9);
            miAlumno.setCalificacionFinal(8);
            Console.WriteLine(miAlumno.getNombreAlumno());
            Console.WriteLine(miAlumno.getParcialUno());
            Console.WriteLine(miAlumno.getParcialDos());
            Console.WriteLine(miAlumno.getParcialTres());
            Console.WriteLine(miAlumno.getCalificacionFinal());




            Console.Read();

        }
    }
}
