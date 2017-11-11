using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RadioExamen.Clases;


namespace RadioExamen
{
    class Program
    {
        static void Main(string[] args)
        {

            Radio elRadio = new Radio();
            Ascii elAscii = new Ascii();
            elAscii.AsciiRadioApagado();
            elRadio.EncenderRadio();
            elRadio.Funcinando();
            elRadio.SintonizandoElRadio();
            elRadio.Funcinando();
            

        }
    }
}
