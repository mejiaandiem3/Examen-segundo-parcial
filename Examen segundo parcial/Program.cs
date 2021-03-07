using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_segundo_parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lEnlazada = new ListaEnlazada();

            Console.WriteLine("Andrea Evelyn Mejia Rubio");
            lEnlazada.InsertarALaCabeza(20);
            lEnlazada.InsertarALaCabeza(15);
            lEnlazada.InsertarALaCabeza(13);
            lEnlazada.InsertarALaCabeza(10);

            lEnlazada.Mostrar();
            lEnlazada.ContImparPar();

            Console.WriteLine(lEnlazada.ListaVacia());

            Console.ReadKey();








        }
    }
}
