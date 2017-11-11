using HolaMundo24.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Programa: Hola Mundo
    Programado por: Diego Silva Prieto
    Versión: 1.0
    Fecha: 21/Ene/2016
    Universidad Politécnica de Tulancingo
    Ingerniería en Sistemas Computacionales
    Análisis y Diseño Orientado a Objetos
*/
namespace HolaMundo24
{
    //Nombre de la clase
    class Program
    {
        //Método principal
        static void Main(string[] args)
        {
            //Para enviar a la pantalla
            Console.WriteLine("HOLA MUNDO 24");

            //Instanciar la clase Mensaje
            Mensaje miMensaje = new Mensaje();
            miMensaje.setMensaje("Deste C#");
            string msg = miMensaje.getMensaje();
            Console.WriteLine(msg);

            //Para  hacer una pausa en la ejecución
            Console.Read();
            
        }
    }
}
