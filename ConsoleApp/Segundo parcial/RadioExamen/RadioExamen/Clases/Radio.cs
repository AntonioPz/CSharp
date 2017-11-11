using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioExamen.Clases
{
    class Radio
    {
        Bocinas lasBocinas = new Bocinas();
        Sintonizador elSintonizador = new Sintonizador();
        Ascii elAscii = new Ascii();
        public void EncenderRadio()
        {
            Console.ReadKey();
            elAscii.AsciiRadio();
        }
        public void Funcinando()
        {
            do
            {
                ConsoleKeyInfo kb = Console.ReadKey();

                switch (kb.Key)
                {
                    case ConsoleKey.RightArrow:
                        lasBocinas.ReproducirCancion();
                        break;
                    case ConsoleKey.LeftArrow:
                        lasBocinas.ReproducirCancion();
                        break;
                    case ConsoleKey.A:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(42,17);
                        Console.Write(" AM FM ");
                        Console.SetCursorPosition(46,17);
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Write(" FM ");
                        Console.BackgroundColor = ConsoleColor.Black;

                        elSintonizador.SintonizacionDeEstacion();
                        break;
                    case ConsoleKey.F:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(42, 17);
                        Console.Write(" AM  FM ");
                        Console.SetCursorPosition(42, 17);
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Write(" AM ");
                        Console.BackgroundColor = ConsoleColor.Black;

                        break;
                }
            
            } while (true);
        }
        public void SintonizandoElRadio()
        {
            elSintonizador.SintonizacionDeEstacion();
        }
    }
}
