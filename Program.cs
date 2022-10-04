using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadenas_Repetidas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string cadena = "rrtttv";

           // var result = cadena.GroupBy(x=>x).Where(g=>g.Count()==1 ).Select(y=>y.Key).First();

            for (int i = 0; i < cadena.Length; i++)
            {
                char valor = cadena[i];

                if (cadena.IndexOf(valor) == cadena.LastIndexOf(valor))
                {

                    
                        Console.WriteLine(valor);
                    break;

                 


                }
             



            }

       
            Console.ReadKey();
        }
    }
}
