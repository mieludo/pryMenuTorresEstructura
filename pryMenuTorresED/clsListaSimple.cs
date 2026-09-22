using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMenuTorresED
{
    internal class clsListaSimple
    {
        private clsNodo primero;

        public clsNodo Primero { get => primero; set => primero = value; }

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo <= Primero.Codigo)
                {
                    Nuevo.siguiente = Primero;
                    Primero = Nuevo;
                }
                else
                {
                    clsNodo aux = Primero;
                    clsNodo ant = Primero;

                    while (aux != null && Nuevo.Codigo > aux.Codigo)
                    {
                        ant = aux;
                        aux = aux.siguiente;
                    }

                    ant.siguiente = Nuevo;
                    Nuevo.siguiente = aux;
                }
            }
        }

        public Boolean Eliminar(Int32 codigo)
        {
            clsNodo ant = null;
            clsNodo aux = Primero;

            while (aux != null && aux.Codigo < codigo)
            {
                ant = aux;
                aux = aux.siguiente;
            }

            if (aux == null || aux.Codigo != codigo)
            {
                return false;
            }

            if (ant == null)
            {
                Primero = aux.siguiente;
            }
            else
            {
                ant.siguiente = aux.siguiente;
            }

            aux.siguiente = null;
            return true;
        }
        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.siguiente;
            }
                    
                    
        }
        public void Recorrer(ListBox lista)
        {
            clsNodo aux = Primero;
            lista.Items.Clear();
            while(aux != null)
            {
                lista.Items.Add(aux.Codigo + " - " +  aux.Nombre + " - " + aux.Tramite);
                aux = aux.siguiente;
            }
        }

        public void Recorrer(ComboBox combo)
        {
            clsNodo aux = Primero;
            combo.Items.Clear();
            while (aux != null)
            {
                combo.Items.Add(aux.Codigo);
                aux = aux.siguiente;
            }
        }
    }
}


    





       
        


    
