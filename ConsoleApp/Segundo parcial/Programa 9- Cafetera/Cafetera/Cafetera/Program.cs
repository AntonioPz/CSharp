using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cafetera.Clases;

namespace Cafeteras
{
    class Program
    {
        static void Main(string[] args)
        {
            Cafetera1 laCafetera = new Cafetera1();
            laCafetera.LlenarCafetera();
            do
            {
                laCafetera.ServirTaza(100,25,35);            
                laCafetera.EstadoCafetera();
                if (laCafetera.getCantidadActual()==0)
                {
                    Console.WriteLine("No se puede preparar, falta de agua");
                }
            } while (laCafetera.getCantidadActual() > 0);
            
            
        }
    }
}
