using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_segundo_parcial
{
    class ListaEnlazada
    {
        public Nodo cabeza;
        public Nodo aux;
        public Nodo final;

        public ListaEnlazada()
        {
            cabeza = null;
        }

        public void InsertarALaCabeza(Object dato)
        {
            //Se crea el nodo
            Nodo NuevoNodo = new Nodo(dato);
            //Se establece la sigueinte referencia
            NuevoNodo.SiguienteNodo = cabeza;
            cabeza = NuevoNodo;
        }

        public void InsertarAlFinal(Object dato)
        {
            //Se verifica que haya elementos en la lista
            if (cabeza == null)
            {
                //Si no los hoy crea el primer elemento
                InsertarALaCabeza(dato);
            }
            else
            {
                //Variable final como variable temporal
                final = cabeza;
                //Cabeza = nuevo nodo
                cabeza = new Nodo(dato);
                //Se reestablecen los apuntadores con la variable final
                cabeza.SiguienteNodo = final;


            }
        }

        public void Mostrar()
        {
            aux = cabeza;

            //Ciclo para imprimir hasta que el sig apuntador sea null
            while (aux != null)
            {
                Console.Write(aux.Dato.ToString() + "=>");
                //Se cambia auxiliar por el apuntador del siguiente
                aux = aux.SiguienteNodo;
            }
            //Imprimir null en caso de que el apuntador sea null
            if (aux == null)
            {
                Console.Write("null");
            }
            Console.WriteLine();
        }

        public int ContarElementos()
        {
            aux = cabeza;
            int contador = 0;

            while (aux != null)
            {
                aux = aux.SiguienteNodo;
                contador -= -1;
            }

            Console.WriteLine("Hay {0} elementos en la lista", contador);

            return contador;

        }

        public void ContImparPar()
        {
            try
            {

                if (ListaVacia())
                {
                    Console.WriteLine("La lista esta vacia");
                }
                else
                {
                    aux = cabeza;
                    int contadorpar = 0;
                    int contadorimpar = 0;

                    while (aux != null)
                    {
                        if (Convert.ToInt32(aux.Dato) % 2 == 0)
                            contadorpar++;
                        else
                            contadorimpar++;

                        aux = aux.SiguienteNodo;
                    }
                    Console.WriteLine("La lista tiene {0} nodos IMPARES", contadorimpar);
                    Console.WriteLine("La lista tiene {0} nodos PARES", contadorpar);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }




        public bool ListaVacia()
        {
            if (cabeza == null)
                return true;
            else
                return false;
        }


    }
}

