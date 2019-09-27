using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionConsola
{
    class RepoConversion        //En esta clase creo el método para realizar la conversion de centavos a pesos y obtengo el valor de los pesos y de los centavos
    {

        public void Convertir(double totalcentavos, out double pesos, out double centavos )     //Utilizando out como paso de parametros.
        {
            pesos = totalcentavos / 100;
            centavos = totalcentavos;

        }



    }
}
