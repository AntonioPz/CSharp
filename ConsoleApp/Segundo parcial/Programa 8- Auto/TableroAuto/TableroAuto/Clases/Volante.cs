using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace TableroAuto.Clases
{
    class Volante
    {
        public void MensajeDeDireccionDerecha()
        {
            Console.SetCursorPosition(80,30);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("GIRO A LA DERECHA");
            Console.SetCursorPosition(80,30);
            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("GIRO A LA DERECHA");
            Console.BackgroundColor = ConsoleColor.Black;



        }
        public void MensajeDeDireccionIzquierda()
        {
            Console.SetCursorPosition(25, 30);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("GIRO A LA IZQUIERDA");
            Console.SetCursorPosition(25, 30);
            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("GIRO A LA IZQUIERDA");
            Console.BackgroundColor = ConsoleColor.Black;

        }
    }
}
