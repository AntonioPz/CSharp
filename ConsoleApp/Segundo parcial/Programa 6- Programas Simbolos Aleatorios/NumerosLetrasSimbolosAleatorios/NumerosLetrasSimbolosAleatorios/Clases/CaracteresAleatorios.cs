using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NumerosLetrasSimbolosAleatorios.Clases
{
    class CaracteresAleatorios
    {
        public void codigo()
        { 
            for(int i = 0;i<5;i++)
            {
                Random generador = new Random();
                char mostrarChar = (char)(generador.Next(26) + 97);
                Console.Write(mostrarChar);
                Thread.Sleep(5);
            }
            for (int i = 0; i < 5; i++)
            {
                Random generador = new Random();
                char mostrarChar = (char)(generador.Next(26) + 65);
                Console.Write(mostrarChar);
                Thread.Sleep(5);
            }
            for (int i = 0; i < 5; i++)
            {
                Random generador = new Random();
                char mostrarChar = (char)(generador.Next(10) + 48);
                Console.Write(mostrarChar);
                Thread.Sleep(5);
            }
            for (int i = 0; i < 5; i++)
            {
                Random generador = new Random();
                char mostrarChar = (char)(generador.Next(13) +33);
                Console.Write(mostrarChar);
                Thread.Sleep(5);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        


        

        //Random a = new Random().Next(65,66);
        //int a = 66; 

        //char ascii2 = (char)a;
        //Console.WriteLine(ascii2);
        
    }
}
