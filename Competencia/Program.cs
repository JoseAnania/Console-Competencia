using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroCompetidor, puntajeCompetidor, cantidadCompetidores=0, puntajeMenor=0, mayor=0, numeroMayor=0;
            string nombreCompetidor, nombreMayor="";
            float acumuladorPuntaje = 0, promedioPuntaje=0;

            Console.WriteLine("Ingrese el número del competidor: ");
            numeroCompetidor = Convert.ToInt32(Console.ReadLine());

            while (numeroCompetidor!=0)
            {
                cantidadCompetidores++;
                Console.WriteLine("Ingrese el nombre del competidor: ");
                nombreCompetidor = Console.ReadLine();
                Console.WriteLine("Ingrese el puntaje del competidor: ");
                puntajeCompetidor = Convert.ToInt32(Console.ReadLine());
                acumuladorPuntaje += puntajeCompetidor;
                promedioPuntaje = (acumuladorPuntaje / cantidadCompetidores);

                if (puntajeCompetidor<10)
                {
                    puntajeMenor++;
                }

                if(cantidadCompetidores==1 || puntajeCompetidor>mayor)
                {
                    mayor = puntajeCompetidor;
                    nombreMayor = nombreCompetidor;
                    numeroMayor = numeroCompetidor;
                }

                Console.WriteLine("Ingrese el número del competidor: ");
                numeroCompetidor = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Cantidad de Competidores: " + cantidadCompetidores);

            Console.WriteLine("Promedio de Puntaje: " + promedioPuntaje);

            Console.WriteLine("Cantidad de Competidores con puntaje menor a 10: " + puntajeMenor);

            Console.WriteLine("Número y nombre del competidor con mayor puntaje es: " + numeroMayor + " " + nombreMayor);

            Console.Read();
        }
    }
}
