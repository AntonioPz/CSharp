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

        }
        
        public void setNumeroTelefono(string numero)
        {
                
            numeroTelefono = elTeclado.TeclarNumero();
            laPantalla.setMensaje(numeroTelefono);
            laPantalla.MostrarMensajeEnPantalla();
            Console.ReadLine();
            elAuricular.Marcando();
            
                        
        }
        public string getNumeroTelefono()
        {


            return numeroTelefono;
        }

        


    }
}
