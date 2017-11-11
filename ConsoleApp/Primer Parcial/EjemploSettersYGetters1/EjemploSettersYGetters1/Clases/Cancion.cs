using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploSettersYGetters1.Clases
{
    class Cancion
    {
        //atributos
        public string tituloCancion;
        public string autorCancion;
        public int anioCancion;
        public float duracionCancion;
        //metodos
        public void setTituloCancion(string titulo)
        {
            tituloCancion = titulo;        
        }
        public string getTituloCancion()
        {
            return tituloCancion;
        }
        
        public void setAutorCancion(string autor)
        {
            autorCancion = autor;
        }
        public string getAutorCancion()
        {
            return autorCancion;
        }
        public void setAnioCancion(int anio)
        {
            anioCancion = anio;
        }
        public int getAnioCancion()
        {
            return anioCancion;
        }
        public void setDuracionCancion(float duracion)
        {
            duracionCancion = duracion;
        }
        public float getDuracionCancion()
        {
            return duracionCancion;
        }
    }
}
