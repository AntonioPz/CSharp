using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using System.Speech.Synthesis;
using System.Threading;

namespace EjemploComposicion.Clases
{
    class Telefono
    {

        //atributos
        private Pantalla laPantalla = new Pantalla();
        private Teclado elTeclado = new Teclado();
        private Auricular elAuricular = new Auricular();
        private Microfono elMicrofono = new Microfono();
        //Inicializar una cadena en vacío o NULL
        public string numeroTelefono = string.Empty;




        //métodos
        private WindowsMediaPlayer sound = new WindowsMediaPlayer();
        //Constructor
        public Telefono()
        {
            //Console.WriteLine("Construyendo el telefono");

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

        }


        public void setNumeroTelefono(string numero)
        {
            
            numeroTelefono = elTeclado.TeclarNumero();
            laPantalla.setMensaje(numeroTelefono);
            laPantalla.MostrarMensajeEnPantalla();
            Console.ReadLine();
            elAuricular.Marcando();

            Random rand = new Random(Guid.NewGuid().GetHashCode());
            int casos = rand.Next(1, 4);

            Console.WriteLine(casos);

            switch (casos)
            {

                case 1:
                    elAuricular.contesta();
                    elMicrofono.contesta();
                    break;

                case 2:
                    elAuricular.ocupado();
                    break;

                case 3:
                    elAuricular.buzon();
                    break;
                
            }
        }
        public string getNumeroTelefono()
        {
            return numeroTelefono;
        }


    }
}
