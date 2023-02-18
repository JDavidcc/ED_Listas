using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasSimplementeLigadas
{
    internal class Lista
    {
        Nodo nodoInicial;
        Nodo nodoActual;
        public Lista()
        {
            nodoInicial= new Nodo();
        }
        public bool ValidaVacio()
        {
            if (nodoInicial.Siguiente == null)
            {
                return true;
            }
            return false;
            //return nodoInicial.Siguiente == null;

        }
        public void VaciarLista()
        {
            nodoInicial.Siguiente = null;
        }
        public string Recorrer()
        {
            string datos = string.Empty;
            nodoActual = nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
                datos += nodoActual.Valor + "\n";
            }
            return datos;
        }
        public void Agregar(string valor)
        {
            nodoActual = nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
            }
            Nodo nodoNuevo = new Nodo(valor);
            nodoActual.Siguiente= nodoNuevo;
        }
        public Nodo Buscar(string valor)
        {
            if (ValidaVacio())
            {
                return null;
            }
            nodoActual = nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
                if (nodoActual.Valor==valor)
                {
                    return nodoActual;
                }
                return null;
            }

        }
    }
}
