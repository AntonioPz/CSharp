using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjemploComposicion.Clases;

namespace EjemploComposicion
{
    class Program
    {
        static void Main(string[] args)
        {
            Interfaz laInterfaz = new Interfaz();
            laInterfaz.InicioInterfaz();
            Telefono elTelefono = new Telefono();
            elTelefono.setNumeroTelefono("");

        }
    }
}
