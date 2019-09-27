using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionConsola
{
    class Principal //En esta clase creo un método para interactuar con el usuario permitiendo que introduzca la cantidad a convertir y mostrando los resultados
    {
        Valores v = new Valores();
        RepoConversion r = new RepoConversion();

         public void RealizarConversion()            
        {
          
            double x, y;        //Utilice estas variables para usarlas como parametros ya que las variables de la clase Valores no me permitía mandarla como parametros
            Console.WriteLine("Ingrese los centavos a convertir");  //El usuario introduce la cantidad de centavos a convertir...
            v.TotalCentavos = Convert.ToDouble(Console.ReadLine());//...y se guarda en la variable de la clase instanciada

            r.Convertir(v.TotalCentavos, out x, out y);     //Invoco el método y paso como parametros a x,y ya que no permite pasar como out a una instancia de la clase
            v.Pesos = x;
            v.Centavos = y;
            Console.WriteLine(v.Centavos.ToString() + " C");        //Muestro los resultados al usuario y termino el programa

            Console.WriteLine(v.Pesos.ToString() + " P");
                     

            Console.ReadLine();

        }
        

        


    }
}
