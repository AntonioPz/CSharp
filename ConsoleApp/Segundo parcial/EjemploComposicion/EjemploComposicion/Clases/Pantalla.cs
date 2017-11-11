using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploComposicion.Clases
{
    class Pantalla
    {
        //atributos
        public string mensaje;
        //métodos
        public void setMensaje (string msj)
        {
            this.mensaje = msj;
        }

        public string getMensaje()
        {
            return mensaje;
        }
        public void MostrarMensajeEnPantalla()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("           @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@            ");
            Console.WriteLine("          @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@          ");
            Console.WriteLine("         @@::::::::::::::@@@@@@@@@@@@@@@@@::::::::::::@@@         ");
            Console.WriteLine("        @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@        ");
            Console.WriteLine("        @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@        ");
            Console.Write("        @@@@");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("@@@@        ");
            Console.Write("        @@@@");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("@@@@        ");
            Console.Write("        @@@@");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("@@@@        ");
            Console.WriteLine("        @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@        ");
            Console.WriteLine("        @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@        ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("        @");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(":::::::::::::::::::::::::::::::::::::::::::::::");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("@@        ");
            Console.Write("        @");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("::::");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("@@@@@@@@@@@");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("::::::::::::::::::");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("@@@@@@@@@@@");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(":::");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("@@        ");
            Console.Write("        @");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(":::::::::::::::::::::::::::::::::::::::::::::::");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("@@        ");
            Console.WriteLine("        @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@        ");
            Console.Write("        @");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(":::::::1::::::");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("@");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(":::::::2::::::::::");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("@@");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(":::::::3::::");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("@@        ");
            Console.WriteLine("        @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@        ");
            Console.Write("        @");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(":::::::4::::::");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("@");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(":::::::5::::::::::");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("@@");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(":::::::6::::");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("@@        ");
            Console.WriteLine("        @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@        ");
            Console.Write("        @");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(":::::::7::::::");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("@");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(":::::::8::::::::::");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("@@");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(":::::::9::::");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("@@        ");
            Console.WriteLine("        @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@        ");
            Console.Write("        @");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(":::::::*::::::");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("@");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(":::::::0::::::::::");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("@@");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(":::::::#::::");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("@@        ");
            Console.Write("        @@@");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("::::::::::::");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("@");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("::::::::::::::::::");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("@@");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("::::::::::::");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("@@         ");
            Console.Write("         @@@");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(":::::::::::");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("@");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("::::::::::::::::::");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("@@");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("::::::::::");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("@@          ");
            Console.WriteLine("          @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@           ");
            Console.WriteLine("            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@           ");
            Console.BackgroundColor = ConsoleColor.Black;
            //para mandar una cadena a la pantalla de manera segura
            Console.SetCursorPosition(14, 7);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(getMensaje().ToString());
        }


        //contructor por defecto
        public Pantalla()
        {
            Console.WriteLine("Inicializando la pantalla");
        }
    }
}
