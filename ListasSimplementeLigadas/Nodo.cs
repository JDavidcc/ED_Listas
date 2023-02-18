using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasSimplementeLigadas
{
    internal class Nodo
    {
        public string Valor { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(string valor = "", Nodo siguente = null)
        {
            Valor = valor;
            Siguiente = siguente;
        }

    }
}
