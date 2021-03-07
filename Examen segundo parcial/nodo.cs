using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_segundo_parcial
{
    class Nodo
    {
        //Se añade la clase Nodo

        //Atributo que almacena el valor del nodo
        public Object Dato;

        /*Clase autorefenciada, la localidad de memoria esta el sigueinte nodo*/

        public Nodo SiguienteNodo;

        public Nodo(Object dato)
        {
            Dato = dato;
        }

        public Nodo()
        {

        }





    }
}
