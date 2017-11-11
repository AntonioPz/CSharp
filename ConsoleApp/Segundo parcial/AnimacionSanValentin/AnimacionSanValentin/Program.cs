using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AnimacionSanValentin.Clases;
using System.Media;


namespace AnimacionSanValentin
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensaje miMensaje = new Mensaje();
            miMensaje.AnimacionPantalla();
            // Create new SoundPlayer in the using statement.
            using (SoundPlayer player = new SoundPlayer(@"C:\Users\Antonio\Desktop\AboutAGirl.wav"))
            {
                // Use PlaySync to load and then play the sound.
                // ... The program will pause until the sound is complete.
                player.PlaySync();
            }
            
        }
        
    }
        
    
}
