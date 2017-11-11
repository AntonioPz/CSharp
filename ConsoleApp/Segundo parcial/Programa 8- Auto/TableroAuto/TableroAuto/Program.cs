using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableroAuto.Clases;

namespace TableroAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            OtroCarro elOtro = new OtroCarro();
            elOtro.Carro();
            Auto elAuto = new Auto();
            elAuto.EncenderAuto();

        }
    }
}
