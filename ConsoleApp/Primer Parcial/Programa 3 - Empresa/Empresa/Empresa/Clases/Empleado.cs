using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Clases
{
    class Empleado
    {
        public string nombre;
        public int numeroHoras;
        public double cuotaHora;
        public double sueldo;

        public void setNombre(string nom)
        {
            nombre = nom;
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setNumeroHoras(int horas)
        {
            numeroHoras = horas;
        }
        public int getNumeroHoras()
        {
            return numeroHoras;
        }
        public void setCuotaHora(double cuota)
        {
            cuotaHora = cuota;
        }
        public double getCuotaHora()
        {
            return cuotaHora;
        }
        public void setSueldo(double sld)
        {
            sueldo = sld;
        }
        public double getSueldo()
        {
            return sueldo;
        }
    }
}
