using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploSettersYGetters1.Clases
{
    class Pintura
    {
        //atributos

        public string tituloPintura;
        public string autorPintura;
        public string museoPintura;
        public string tamañoPintura;
        public int precioPintura;


        //métodos
        public void setTituloPintura(string titulo)
        {
            tituloPintura = titulo;
        }        
        public string getTituloPintura()
        {
            return tituloPintura;
        }

        public void setAutorPintura(string autor)
        {
            autorPintura = autor;
        }
        public string getAutorPintura()
        {
            return autorPintura;
        }

        
        public void setMuseoPintura(string museo)
        {
            museoPintura = museo;
        }
        public string getMuseoPintura()
        {
            return museoPintura;
        }

        public void setTamañoPintura(string tamaño)
        {
            tamañoPintura = tamaño;
        }
        public string getTamañoPintura()
        {
            return tamañoPintura;
        }
        public void setPrecioPintura(int precio)
        {
            precioPintura = precio;
        }
        public int getPrecioPintura()
        {
            return precioPintura;
        }
    
        

    }
}
