//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompañiaSeguros.Clases;

namespace CompañiaSeguros
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedorUno = new Vendedor();
            Console.WriteLine("Introduce nombre del vendedor uno:");
            string nombreUno = Console.ReadLine();
            vendedorUno.setNombreVendedor(nombreUno);
            vendedorUno.setVentaUno(200);
            vendedorUno.setVentaDos(250);
            vendedorUno.setVentaTres(150);
            vendedorUno.setSueldoBase(80);
            vendedorUno.setComisionVendedor(10);

            vendedorUno.setSueldoTotal(
            (((vendedorUno.getVentaUno() +
            vendedorUno.getVentados() +
            vendedorUno.getVentaTres()) *
            vendedorUno.getComisionVendedor()) / 100) +
            vendedorUno.getSueldoBase()
            );


            Console.WriteLine();
            Vendedor vendedorDos = new Vendedor();
            Console.WriteLine("Introduce nombre del vendedor dos:");
            string nombreDos = Console.ReadLine();
            vendedorDos.setNombreVendedor(nombreDos);
            vendedorDos.setVentaUno(2500);
            vendedorDos.setVentaDos(300);
            vendedorDos.setVentaTres(200);
            vendedorDos.setSueldoBase(80);
            vendedorDos.setComisionVendedor(10);

            vendedorDos.setSueldoTotal(
            (((vendedorDos.getVentaUno() +
            vendedorDos.getVentados() +
            vendedorDos.getVentaTres()) *
            vendedorDos.getComisionVendedor()) / 100) +
            vendedorDos.getSueldoBase()
            );
            Console.WriteLine();
            Vendedor vendedorTres = new Vendedor();
            Console.WriteLine("Introduce nombre del vendedor tres:");
            string nombreTres = Console.ReadLine();
            vendedorTres.setNombreVendedor(nombreTres);
            vendedorTres.setVentaUno(250);
            vendedorTres.setVentaDos(2500);
            vendedorTres.setVentaTres(200);
            vendedorTres.setSueldoBase(80);
            vendedorTres.setComisionVendedor(10);

            vendedorTres.setSueldoTotal(
            (((vendedorTres.getVentaUno() +
            vendedorTres.getVentados() +
            vendedorTres.getVentaTres()) *
            vendedorTres.getComisionVendedor()) / 100) +
            vendedorTres.getSueldoBase()
            );

            // Para limpiar la pantalla
            // Nombre o titulo de la ventana
            Console.Title = "MI APLICACIÓN";
            Console.Clear();

            Console.BackgroundColor=ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("NOMBRE DEL VENDEDOR: "+ vendedorUno.getNombreVendedor());
            Console.Write("SUELDO: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("$" + vendedorUno.getSueldoTotal());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("_______________________");

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("NOMBRE DEL VENDEDOR: " + vendedorDos.getNombreVendedor());
            Console.Write("SUELDO: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("$" + vendedorDos.getSueldoTotal());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("_______________________");

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("NOMBRE DEL VENDEDOR: " + vendedorTres.getNombreVendedor());
            Console.Write("SUELDO: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("$" + vendedorTres.getSueldoTotal());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("_______________________");

            Console.Read();
        }
    }
}
