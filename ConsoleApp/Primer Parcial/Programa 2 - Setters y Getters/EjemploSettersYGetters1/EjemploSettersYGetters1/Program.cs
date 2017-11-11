using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjemploSettersYGetters1.Clases;

namespace EjemploSettersYGetters1
{
    class Program
    {
        static void Main(string[] args)
        {
            //INSTANCIAR LA CLASE
            Cancion miCancion = new Cancion();
            miCancion.setTituloCancion("November Rain");
            miCancion.setDuracionCancion(9.16f);
            miCancion.setAutorCancion("Axel Rouses");
            miCancion.setAnioCancion(1991);

            Console.WriteLine(miCancion.getTituloCancion());
            Console.WriteLine(miCancion.getDuracionCancion());
            Console.WriteLine(miCancion.getAutorCancion());
            Console.WriteLine(miCancion.getAnioCancion());

            Console.ReadLine();

            Pintura miPintura = new Pintura();
            miPintura.setTituloPintura("Retrato de picasso");
            miPintura.setAutorPintura("Dalí");
            miPintura.setMuseoPintura("Fundación Gala Salvador Dalí");
            miPintura.setTamañoPintura("Ancho 64.1 y Largo 54.7");
            miPintura.setPrecioPintura(100000);


            Console.WriteLine(miPintura.getTituloPintura());
            Console.WriteLine(miPintura.getAutorPintura());
            Console.WriteLine(miPintura.getMuseoPintura());
            Console.WriteLine(miPintura.getTamañoPintura());
            Console.WriteLine(miPintura.getPrecioPintura());


            //hacer una pausa
            Console.Read();

        }
    }
}
