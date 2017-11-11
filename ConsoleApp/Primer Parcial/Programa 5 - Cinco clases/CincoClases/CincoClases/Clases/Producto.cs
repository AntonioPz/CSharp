using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CincoClases.Clases
{
    class Producto
    {
        //atributos
        public string nombreProducto;
        public long codigoProducto;
        public string contenidoProducto;
        public string marcaProducto;
        public float precioProducto;

        //métodos
        public void setNombreProducto(string nombre)
        {
            nombreProducto = nombre;
        }
        public string getNombreProducto()
        {
            return nombreProducto;
        }

        public void setCodigoProducto(long codigo)
        {
            codigoProducto = codigo;
        }
        public long getCodigoProducto()
        {
            return codigoProducto;
        }
        public void setContenidoProducto(string contenido)
        {
            contenidoProducto = contenido;
        }
        public string getContenidoProducto()
        {
            return contenidoProducto;
        }
        public void setMarcaProducto(string marca)
        {
            marcaProducto = marca;
        }
        public string getMarcaProducto()
        {
            return marcaProducto;
        }
        public void setPrecioProducto(float precio)
        {
            precioProducto = precio;
        }
        public float getPrecioProducto()
        {
            return precioProducto;
        }
    }
}
