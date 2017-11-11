using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace EjemploComposicion.Clases
{
    class Pantalla
    {
        //atributos
        public string mensaje;
        //métodos
        public void setMensaje (string msj)
        {
            this.mensaje = msj;
        }

        public string getMensaje()
        {
            return mensaje;
        }
        public void MostrarMensajeEnPantalla()
        {   
            //para mandar una cadena a la pantalla de manera segura
            Console.SetCursorPosition(5,7);
            Console.WriteLine(getMensaje().ToString());
        }

        //contructor por defecto
        public Pantalla()
        {
            //Console.WriteLine("Inicializando la pantalla");
        }
    }
}
