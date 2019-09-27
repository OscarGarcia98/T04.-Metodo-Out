using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Principal p = new Principal();      //Instancia del objeto e invocación del método que convierte centavos a pesos

            p.RealizarConversion();

        }
    }
}
