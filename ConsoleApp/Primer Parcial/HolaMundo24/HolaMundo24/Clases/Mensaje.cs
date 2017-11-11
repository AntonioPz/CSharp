using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo24.Clases
{
    class Mensaje
    {
        //Atributos
        public string mensaje;

        //Métodos
        public void setMensaje(string msg)
        {
            mensaje = msg;
        }

        public string getMensaje()
        {
            return mensaje;
        }
           
    }
}
