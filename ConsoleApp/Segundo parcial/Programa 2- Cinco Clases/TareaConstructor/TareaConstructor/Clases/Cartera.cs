using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaConstructor.Clases
{
    class Cartera
    {
        // Atributos
        public string marcaCartera;
        public string materialCartera;
        public string colorCartera;

        public Cartera()
        {
            this.marcaCartera = "TREND";
            this.materialCartera = "Piel";
            this.colorCartera = "Cafe";
        }
        public Cartera(string marcaCartera, string materialCartera, string colorCartera)
        {
            this.marcaCartera = marcaCartera;
            this.colorCartera = colorCartera;
            this.materialCartera = materialCartera;
        }
        public string getMarcaCartera()
        {
            return marcaCartera;
        }
        public string getMaterialCartera()
        {
            return materialCartera;
        }
        public string getColorCartera()
        {
            return colorCartera;
        }
    }
}
