using HolaMundo24.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Programa: Hola Mundo
    Programdo por : Antonio Pérez González
    Fecha:21/Ene/2016
    Universidad Politecnica De Tulancingo
    Ingenieria en Sistemas Computacionales
    Análisis y Diseño Orientado a Objetos
*/
namespace HolaMundo24
{
    // nombre de la clase
    class Program
    {
        //método principal
        static void Main(string[] args)
        {
            // Para enviar a la pantalla
            Console.WriteLine("Hola Mundo 24");

            //Instanciar la clase Mensaje
            Mensaje miMensaje = new Mensaje();
            miMensaje = new Mensaje();
            miMensaje.setMensaje("Desde C#");
            string msg = miMensaje.getMensaje();
            Console.WriteLine(msg);
            // Para hacer una pausa en la ejecución
            Console.Read();
        }
    }
}
