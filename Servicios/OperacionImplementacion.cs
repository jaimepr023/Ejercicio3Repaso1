using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Repaso1.Servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {
        public string afirmacion()
        {
            Console.WriteLine("¿Quieres volver a realizar otra operacion? (s/n)");
            string afirmacion = Console.ReadLine();
            return afirmacion;
        }

        public void calcularSacos()
        {
            Console.WriteLine("¿Cuanto pesa 1 saco? (Que sean kilogramos enteros)");
            int  saco = Int32.Parse(Console.ReadLine());

            if(saco >4000)
            {
                Console.WriteLine("Es imposible hacer la operacion de cuantos saco pueden ir en un furgoneta, ya que el peso del saco es mayor al del peso maximo de la furgoneta");
            }
            else
            {
                int numSacos = 4000 / saco;
                if (numSacos > 1)
                {
                    Console.WriteLine("La cantidad de saco que pueden cargar la furgoneta es de " + numSacos + " sacos");
                }
                else if(numSacos==1)
                {
                    Console.WriteLine("La cantidad de saco que pueden cargar la furgoneta es de " + numSacos + " saco");
                }
                else { }
                
            }
        }
    }
}
