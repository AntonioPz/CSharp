using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RadioExamen.Clases;

namespace RadioExamen.Clases
{
    class Sintonizador
    {

        public void SintonizacionDeEstacion()
        {
            int n = 9;
            
            for (int i = 0; i < 84; i ++)
            {
                ConsoleKeyInfo kb = Console.ReadKey();
                if (kb.Key == ConsoleKey.UpArrow)
                {
                    n++;
                }
                if (kb.Key == ConsoleKey.DownArrow)
                {                    
                    n--;
                }
                if (n > 9 & n < 51 )
                {
                    
                    int m;
                    m = n % 2;
                    switch (m)
                    {
                        case 0:
                            Console.SetCursorPosition(n - 1, 13);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" █ ");
                            Console.SetCursorPosition(n - 1, 14);
                            Console.WriteLine(" █ ");
                            Console.ForegroundColor = ConsoleColor.Black;
                            break;
                        case 1:
                            Console.SetCursorPosition(n - 1, 13);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(" ");
                            Console.SetCursorPosition(n, 13);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("█");
                            Console.SetCursorPosition(n + 1, 13);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(" ");

                            Console.SetCursorPosition(n - 1, 14);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("█");
                            Console.SetCursorPosition(n, 14);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("█");
                            Console.SetCursorPosition(n + 1, 14);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("█");
                            break;
                    }
                }
                else
                {
                    Console.SetCursorPosition(9,13);
                    
                }

                if (n == 9)
                {
                    Console.SetCursorPosition(9, 13);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("█");
                    Console.SetCursorPosition(10, 13);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" ");
                    Console.SetCursorPosition(10, 14);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("█");
                    Console.SetCursorPosition(9, 14);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("█");
                    Console.ForegroundColor = ConsoleColor.Black;
                }

                if (n==51)
                {
                    Console.SetCursorPosition(50, 13);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" ");
                    Console.SetCursorPosition(51, 13);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("█");
                    Console.SetCursorPosition(50, 14);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("█");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(51, 14);
                    Console.WriteLine("█");
                    Console.ForegroundColor = ConsoleColor.Black;
                }

            }
        }
            
    }
}
