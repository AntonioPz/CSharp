using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaConstructor.Clases
{
    class Pantalon
    {
        // Atributos

        public string marcaPantalon;
        public string modeloPantalon;
        public string precioPantalon; 

        public Pantalon()
        {
            this.marcaPantalon = "Levis";
            this.modeloPantalon = "Slim 220";
            this.precioPantalon = "$250";
        }
        public Pantalon(string marcaPantalon, string modeloPantalon,string precioPantalon)
        {
            this.marcaPantalon = marcaPantalon;
            this.precioPantalon = precioPantalon;
            this.modeloPantalon = modeloPantalon;            
        }
        public string getMarcaPantalon()
        {
            return marcaPantalon;
        }
        public string getModeloPantalon()
        {
            return modeloPantalon;
        }
        public string getPrecioPantalon()
        {
            return precioPantalon;
        }
    }
}
