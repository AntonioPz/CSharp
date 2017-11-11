using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompañiaSeguros.Clases
{
    class Vendedor
    {
        public string nombreVendedor;
        public double ventaUno;
        public double ventaDos;
        public double ventaTres;
        public double sueldoBase;
        public double comisionVendedor;
        public double sueldoTotal;

        public void setNombreVendedor(string nombre)
        {
            nombreVendedor = nombre;
        }
        public string getNombreVendedor()
        {
            return nombreVendedor;
        }
        public void setVentaUno(double uno)
        {
            ventaUno = uno;
        }
        public double getVentaUno()
        {
            return ventaUno;
        }
        public void setVentaDos(double dos)
        {
            ventaDos = dos;
        }
        public double getVentados()
        {
            return ventaDos;
        }
        public void setVentaTres(double tres)
        {
            ventaTres = tres;
        }
        public double getVentaTres()
        {
            return ventaTres;
        }
        public void setSueldoBase(double SueldoB)
        {
            sueldoBase = SueldoB;
        }
        public double getSueldoBase()
        {
            return sueldoBase;
        }
        public void setComisionVendedor(double comision)
        {
            comisionVendedor = comision;
        }
        public double getComisionVendedor()
        {
            return comisionVendedor;
        }
        public void setSueldoTotal(double total)
        {
            sueldoTotal = total;
        }
        public double getSueldoTotal()
        {
            return sueldoTotal;
        }















    }
}
