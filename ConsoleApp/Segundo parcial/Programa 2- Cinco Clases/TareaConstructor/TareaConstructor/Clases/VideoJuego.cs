using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaConstructor.Clases
{
    class VideoJuego
    {
        // Video Juego

        public string nombreJuego;
        public string empresaJuego;
        public string precioJuego;

        // Método constructor por defecto

        public VideoJuego()
        {
            this.nombreJuego = "HALO REACH";
            this.empresaJuego = "MICROSOFT";
            this.precioJuego = "$250";
        }
        public VideoJuego(string nombreJuego,string empresaJuego,string precioJuego)
        {
            this.nombreJuego = nombreJuego;
            this.empresaJuego = empresaJuego;
            this.precioJuego = precioJuego;
        }
        public string getNombreJuego()
        {
            return nombreJuego;
        }
        public string getEmpresaJuego()
        {
            return empresaJuego;
        }
        public string getPrecioJuego()
        {
            return precioJuego;
        }
        

    }
}
