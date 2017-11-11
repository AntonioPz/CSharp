using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaConstructor.Clases;
namespace TareaConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular miCelular = new Celular();

            Console.WriteLine(miCelular.getMarcaCelular());
            Console.WriteLine(miCelular.getModeloCeluar());
            Console.WriteLine(miCelular.getPrecioCelular());
            Console.WriteLine();

            VideoJuego miVideoJuego = new VideoJuego();

            Console.WriteLine(miVideoJuego.getNombreJuego());
            Console.WriteLine(miVideoJuego.getEmpresaJuego());
            Console.WriteLine(miVideoJuego.getPrecioJuego());
            Console.WriteLine();

            Reloj miReloj = new Reloj();

            Console.WriteLine(miReloj.getMarcaReloj());
            Console.WriteLine(miReloj.getTipoReloj());
            Console.WriteLine(miReloj.getColorReloj());
            Console.WriteLine();

            Cartera miCartera = new Cartera();

            Console.WriteLine(miCartera.getMarcaCartera());
            Console.WriteLine(miCartera.getMaterialCartera());
            Console.WriteLine(miCartera.getColorCartera());
            Console.WriteLine();

            Pantalon miPantalon = new Pantalon();

            Console.WriteLine(miPantalon.getMarcaPantalon());
            Console.WriteLine(miPantalon.getModeloPantalon());
            Console.WriteLine(miPantalon.getPrecioPantalon());

            Console.WriteLine();

            Cartera miOtraCartera = new Cartera("CURT","Piel","Negra");
            Console.WriteLine("Marca: " + miOtraCartera.getMarcaCartera());
            Console.WriteLine("Material: " + miOtraCartera.getMaterialCartera());
            Console.WriteLine("Color: " + miOtraCartera.getColorCartera());

            Console.WriteLine();

            Celular miOtroCelular = new Celular("Samsung", "S6", 12000);
            Console.WriteLine("Marca: "+miOtroCelular.getMarcaCelular());
            Console.WriteLine("Modelo: "+miOtroCelular.getModeloCeluar());
            Console.WriteLine("Precio: "+miOtroCelular.getPrecioCelular());

            Console.WriteLine();

            Pantalon miOtroPantalon = new Pantalon("OGGI","SLM", "$300");
            Console.WriteLine("Marca: " + miOtroPantalon.getMarcaPantalon());
            Console.WriteLine("Modelo: " + miOtroPantalon.getModeloPantalon());
            Console.WriteLine("Precio: " + miOtroPantalon.getPrecioPantalon());

            Console.WriteLine();

            Reloj miOtroReloj = new Reloj("OMEGA", "Mecánico", "Plateado");
            Console.WriteLine("Marca:" + miOtroReloj.getMarcaReloj());
            Console.WriteLine("Tipo: " + miOtroReloj.getTipoReloj());
            Console.WriteLine("Color: " + miOtroReloj.getColorReloj());

            Console.WriteLine();

            VideoJuego miOtroJuego = new VideoJuego("Gears of Wars", "EPIC GAMES", "$250");
            Console.WriteLine("Nombre: "+ miOtroJuego.getNombreJuego());
            Console.WriteLine("Empresa :" + miOtroJuego.getEmpresaJuego());
            Console.WriteLine("Precio: " + miOtroJuego.getPrecioJuego());

            Console.Read();


        }
    }
}
