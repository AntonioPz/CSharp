using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CincoClases.Clases
{
    class Auto
    {
        //atributos
        public string marcaAuto;
        public string modeloAuto;
        public string tipoAuto;
        public long numeroSerie;
        public string placasAuto;
        //método
        public void setMarcaAuto(string marca)
        {
            marcaAuto = marca;
        }
        public string getMarcaAuto()
        {
            return marcaAuto;
        }
        public void setModeloAuto(string modelo)
        {
            modeloAuto = modelo;
        }
        public string getModeloAuto()
        {
            return modeloAuto;
        }
        public void setTipoAuto(string tipo)
        {
            tipoAuto = tipo;
        }
        public string getTipoAuto()
        {
            return tipoAuto;
        }
        public void setNumeroSerie(long numero)
        {
            numeroSerie = numero;
        }
        public long getNumeroSerie()
        {
            return numeroSerie;
        }
        public void setPlacasAuto(string placas)
        {
            placasAuto = placas;
        }
        public string getPlacasAuto()
        {
            return placasAuto;
        }


    }
}
