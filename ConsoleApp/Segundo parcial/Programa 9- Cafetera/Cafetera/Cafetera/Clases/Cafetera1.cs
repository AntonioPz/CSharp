using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafetera.Clases
{
    class Cafetera1
    {
        // Atributos 
        private int capacidadMaxima;
        private int cantidadActual;

        // Conposicion
        private Agua elAgua = new Agua();
        private Cafe elCafe = new Cafe();
        private Azucar elAzucar = new Azucar();

        //Métodos

        //Constructor por defecto
        public Cafetera1()
        {
            this.capacidadMaxima = 1000;
            this.cantidadActual = 0;
        }
        //Constructor con parametros
        public Cafetera1(int capacidadMaxima)
        {
            this.capacidadMaxima = capacidadMaxima;
        }
        public Cafetera1(int capacidadMaxima, int cantidadActual)
        {
            this.capacidadMaxima = capacidadMaxima;
            if (cantidadActual > capacidadMaxima)
            {
                this.cantidadActual = capacidadMaxima;
            }
            else            
                this.cantidadActual = cantidadActual;            
        }
        public void setCapacidadMaxima(int capacidadMaxima)
        {
            this.capacidadMaxima = capacidadMaxima;
        }
        public int getCapacidadMaxima()
        {
            return capacidadMaxima;
        }
        public void setCantidadActual(int cantidadActual)
        {
            this.cantidadActual = cantidadActual;
        }
        public int getCantidadActual()
        {
            return cantidadActual;
        }

        public void LlenarCafetera()
        {
            setCantidadActual(elAgua.getCantidadAgua());
        }
        public void ServirTaza(int capacidadTaza, int cantidadCafe, int cantidadAzucar)
        {
            
            if(capacidadTaza > elAgua.getCantidadAgua())
            {
                Console.WriteLine("No se puede preparar el cafe. Falta agua");
            }
            else
            {
                if(cantidadCafe > elCafe.getCantidadCafe())
               {
                    setCantidadActual(getCantidadActual() - capacidadTaza);
                    elAgua.setCantidadAgua(elAgua.getCantidadAgua() - capacidadTaza);
                    elCafe.setCantidadCafe(0);
                    elAzucar.setCantidadAzucar(elAzucar.getCantidadAzucar() - cantidadAzucar);
                    Console.WriteLine("Preparando cafe. Se ha agotado el cafe");
                }
                else
                {
                    setCantidadActual(getCantidadActual() - capacidadTaza);
                    elAgua.setCantidadAgua(elAgua.getCantidadAgua() - capacidadTaza);
                    elCafe.setCantidadCafe(elCafe.getCantidadCafe() - cantidadCafe);
                    elAzucar.setCantidadAzucar(elAzucar.getCantidadAzucar() - cantidadAzucar);
                    Console.WriteLine("Preparando cafe. Que lo disfrutes!!");
                }
                
            }          


        }
        public void EstadoCafetera()
        {
            Console.WriteLine("Agua: " + elAgua.getCantidadAgua());
            Console.WriteLine("Cafe: " + elCafe.getCantidadCafe());
            Console.WriteLine("Azucar: "+ elAzucar.getCantidadAzucar());
        }
    }
}
