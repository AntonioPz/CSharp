using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CincoClases.Clases
{
    class Libro
    {
        //atributos
        public string nombreLibro;
        public string autorLibro;
        public string editorialLibro;
        public double precioLibro;
        public string descuentoLibro;

        //métodos

        public void setNombreLibro(string nombre)
        {
            nombreLibro = nombre;
        }
        public string getNombreLibro()
        {
            return nombreLibro;
        }
        public void setAutorLibro(string libro)
        {
            autorLibro = libro;
        }
        public string getAutorLibro()
        {
            return autorLibro;
        }
        public void setEditorialLibro(string editorial)
        {
            editorialLibro = editorial;
        }
        public string getEditorialLibro()
        {
            return editorialLibro;
        }
        public void setPrecioLibro(double precio)
        {
            precioLibro = precio;
        }
        public double getPrecioLibro()
        {
            return precioLibro;
        }
        public void setDescuentoLibro(string descuento)
        {
            descuentoLibro = descuento;
        }
        public string getDescuentoLibro()
        {
            return descuentoLibro;
        }



























    }
}
