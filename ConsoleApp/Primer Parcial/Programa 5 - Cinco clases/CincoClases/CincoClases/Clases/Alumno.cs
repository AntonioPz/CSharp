using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CincoClases.Clases
{
    class Alumno
    {
        //atributos
        public string nombreAlumno;
        public long parcialUno;
        public int parcialDos;
        public int parcialTres;
        public double calificacionFinal;

        //métodos

        public void setNombreAlumno(string nombre)
        {
            nombreAlumno = nombre;
        }
        public string getNombreAlumno()
        {
            return nombreAlumno;
        }
        public void setParcialUno(long uno)
        {
            parcialUno = uno;
        }
        public long getParcialUno()
        {
            return parcialUno;
        }
        public void setParcialDos(int dos)
        {
            parcialDos= dos;
        }
        public int getParcialDos()
        {
            return parcialDos;
        }
        public void setParcialTres(int tres)
        {
            parcialTres = tres;
        }
        public int getParcialTres()
        {
            return parcialTres;
        }
        public void setCalificacionFinal(double calificacion)
        {
            calificacionFinal = calificacion;
        }
        public double getCalificacionFinal()
        {
            return calificacionFinal;
        }








        
    }
}
