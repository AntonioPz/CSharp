using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumerosLetrasSimbolosAleatorios.Clases;

namespace NumerosLetrasSimbolosAleatorios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Generador de codigos";
            CaracteresAleatorios miCaracter = new CaracteresAleatorios();
            Console.WriteLine();
            Console.WriteLine("Secuencia de caracteres aleatorios");
            miCaracter.codigo();
        }
    }
}
