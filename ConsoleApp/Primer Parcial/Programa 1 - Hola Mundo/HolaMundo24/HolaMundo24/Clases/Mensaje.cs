using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo24.Clases
{
    class Mensaje
    {
        //atributos
        public string mensaje;
        //métodos
        public void setMensaje(string msg)
        {
            mensaje = msg;
        }

        public string getmensaje()
        {
            return mensaje;
        }

        internal string getMensaje()
        {
            return mensaje;
        }
    }
}
