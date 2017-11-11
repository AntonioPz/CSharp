using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaConstructor.Clases
{
    class Reloj
    {
        // Atributos

        public string marcaReloj;
        public string tipoReloj;
        public string colorReloj;

        public Reloj()
        {
            this.marcaReloj = "CITIZEN";
            this.tipoReloj = "Digital";
            this.colorReloj = "Negro";
        }
        public Reloj(string marcaReloj,string tipoReloj,string colorReloj)
        {
            this.marcaReloj = marcaReloj;
            this.tipoReloj = tipoReloj;
            this.colorReloj = colorReloj;
        }
        public string getMarcaReloj()
        {
            return marcaReloj;
        }
        public string getTipoReloj()
        {
            return tipoReloj;
        }
        public string getColorReloj()
        {
            return colorReloj;
        }
        

    }

}
