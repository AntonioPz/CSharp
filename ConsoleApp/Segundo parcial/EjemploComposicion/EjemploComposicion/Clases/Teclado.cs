using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploComposicion.Clases
{
    class Teclado
    {
        //atributos
        //métodos
        //constructor por defecto
        public Teclado ()
        {
            Console.WriteLine("Inicizalizando el teclado");
        }


        public string TeclarNumero()
        {
            string numeroCompleto = string.Empty;
            int i = 0;
            Console.WriteLine("Introduce el número");
            //Para leer la tecla que se esta presionando
            ConsoleKeyInfo cki;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                //Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.SetCursorPosition(14+i,12);
                cki = Console.ReadKey();
                char digito = cki.KeyChar;
                numeroCompleto += digito.ToString();
                i++;

                switch (digito)
                {
                    
                    case '1':
                        Console.SetCursorPosition(16, 19);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("1");
                        Console.Beep(1209, 100);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(16, 19);
                        Console.WriteLine("1");
                        break;
                    case '2':
                        Console.Beep(1336, 100);
                        break;
                    case '3':
                        Console.Beep(1477, 100);
                        break;
                    case '4':
                        Console.Beep(1209, 100);
                        break;
                    case '5':
                        Console.Beep(1336, 100);
                        break;
                    case '6':
                        Console.Beep(1477, 100);
                        break;
                    case '7':
                        Console.Beep(1209, 100);
                        break;
                    case '8':
                        Console.Beep(1336, 100);
                        break;
                    case '9':
                        Console.Beep(1477, 100);
                        break;
                    case '0':
                        Console.Beep(1336, 100);
                        break;
                }

            } while (i<10);
            return numeroCompleto;
        }
    }
}
