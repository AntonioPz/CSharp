using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaConstructor.Clases
{
    class Celular
    {
        // atributos
        public string marcaCelular;
        public string modeloCelular;
        public double precioCelular;

        // métodos

        public Celular()
        {
            this.marcaCelular = "Sony Xperia";
            this.modeloCelular = "Z5";
            this.precioCelular = 13000;
        }
        public Celular(string marcaCelular, string modeloCelular, double precioCelular)
        {
            this.marcaCelular = marcaCelular;
            this.modeloCelular = modeloCelular;
            this.precioCelular = precioCelular;
        }

        public string getMarcaCelular()
        {
            return marcaCelular;
        }
        public string getModeloCeluar()
        {
            return modeloCelular;
        }
        public double getPrecioCelular()
        {
            return precioCelular;
        }


    }
}
