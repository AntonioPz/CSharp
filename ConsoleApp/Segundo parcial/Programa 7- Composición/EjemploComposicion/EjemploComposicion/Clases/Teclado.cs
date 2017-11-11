using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace EjemploComposicion.Clases
{
    class Teclado
    {
        //atributos
        //métodos
        //constructor por defecto
        public Teclado ()
        {
            //Console.WriteLine("Inicizalizando el teclado");
        }


        public string TeclarNumero()
        {
            string numeroCompleto = string.Empty;
            int i = 0;
            Console.SetCursorPosition(5,5);
            Console.WriteLine("Introduce el número");
            //Para leer la tecla que se esta presionando
            ConsoleKeyInfo cki;

            int c = 6;
            Console.SetCursorPosition(5, 7);
            
            do
            {

                cki = Console.ReadKey();
                char digito = cki.KeyChar;
                
                Console.SetCursorPosition(c ++, 7);
                numeroCompleto += digito.ToString();
                i++;
                switch (digito)
                {
                    
                    case '1':
                        Console.Beep(1209, 100);
                        Console.SetCursorPosition(3,15);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("   1  ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Thread.Sleep(100);
                        Console.SetCursorPosition(3,15);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write("   1  ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(c-1, 7);

                        break;
                        
                    case '2':
                        Console.Beep(1336, 100);
                        Console.SetCursorPosition(12, 15);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("  2   ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Thread.Sleep(100);
                        Console.SetCursorPosition(12, 15);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write("  2   ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(c-1, 7);

                        break;
                    case '3':
                        Console.Beep(1477, 100);
                        Console.SetCursorPosition(20, 15);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("   3  ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Thread.Sleep(100);
                        Console.SetCursorPosition(20, 15);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write("   3  ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(c - 1, 7);
                        break;
                    case '4':
                        Console.Beep(1209, 100);
                        Console.SetCursorPosition(3,17);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("   4  ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Thread.Sleep(100);
                        Console.SetCursorPosition(3,17);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write("   4  ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(c - 1, 7);
                        break;
                    case '5':
                        Console.Beep(1336, 100);
                        Console.SetCursorPosition(12,17);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("  5   ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Thread.Sleep(100);
                        Console.SetCursorPosition(12,17);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write("  5   ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(c - 1, 7);
                        break;
                    case '6':
                        Console.SetCursorPosition(20, 17);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("   6  ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Thread.Sleep(100);
                        Console.SetCursorPosition(20, 17);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write("   6  ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(c - 1, 7);
                        Console.Beep(1477, 100);
                        break;

                    case '7':
                        Console.SetCursorPosition(3,19);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("   7  ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Thread.Sleep(100);
                        Console.SetCursorPosition(3,19);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write("   7  ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(c - 1, 7);
                        Console.Beep(1209, 100);
                        break;

                    case '8':
                        Console.Beep(1336, 100);
                        Console.SetCursorPosition(12, 19);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("  8   ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Thread.Sleep(100);
                        Console.SetCursorPosition(12, 19);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write("  8   ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(c - 1, 7);
                        break;

                    case '9':
                        Console.Beep(1477, 100);
                        Console.SetCursorPosition(20, 19);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("   9  ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Thread.Sleep(100);
                        Console.SetCursorPosition(20, 19);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write("   9  ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(c - 1, 7);
                        break;

                    case '0':
                        Console.Beep(1336, 100);
                        Console.SetCursorPosition(12, 21);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("  0   ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Thread.Sleep(100);
                        Console.SetCursorPosition(12, 21);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write("  0   ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(c - 1, 7);
                        break;
                }

            } while (i<10);
            return numeroCompleto;
        }
    }
}
