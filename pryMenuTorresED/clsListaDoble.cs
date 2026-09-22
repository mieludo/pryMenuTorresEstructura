using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMenuTorresED
{
    internal class clsListaDoble
    {
        private clsNodo primero;
        private clsNodo ultimo;

        public clsNodo Primero
        {
            get => primero;
            set => primero = value;
        }

        public clsNodo Ultimo
        {
            get => ultimo;
            set => ultimo = value;
        }

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo <= Primero.Codigo)
                {
                    Nuevo.anterior = null;
                    Nuevo.siguiente = Primero;
                    Primero.anterior = Nuevo;
                    Primero = Nuevo;
                }
                else
                {
                    if (Nuevo.Codigo > Ultimo.Codigo)
                    {
                        Ultimo.siguiente = Nuevo;
                        Nuevo.anterior = Ultimo;
                        Nuevo.siguiente = null;
                        Ultimo = Nuevo;
                    }
                    else
                    {
                        clsNodo aux = Primero;
                        clsNodo ant = null;

                        while (aux != null && aux.Codigo < Nuevo.Codigo)
                        {
                            ant = aux;
                            aux = aux.siguiente;
                        }

                        ant.siguiente = Nuevo;
                        Nuevo.siguiente = aux;
                        aux.anterior = Nuevo;
                        Nuevo.anterior = ant;
                    }
                }
            }
        }

        public Boolean Eliminar(Int32 Codigo)
        {
            clsNodo aux = Primero;

            while (aux != null && aux.Codigo < Codigo)
            {
                aux = aux.siguiente;
            }

            if (aux == null || aux.Codigo != Codigo)
            {
                return false;
            }

            if (aux.anterior == null)
            {
                Primero = aux.siguiente;
            }
            else
            {
                aux.anterior.siguiente = aux.siguiente;
            }

            if (aux.siguiente == null)
            {
                Ultimo = aux.anterior;
            }
            else
            {
                aux.siguiente.anterior = aux.anterior;
            }

            aux.siguiente = null;
            aux.anterior = null;
            return true;
        }

        public void Recorrer(DataGridView grilla)
        {
            clsNodo aux = Primero;
            grilla.Rows.Clear();

            while (aux != null)
            {
                grilla.Rows.Add(
                    aux.Codigo,
                    aux.Nombre,
                    aux.Tramite
                );

                aux = aux.siguiente;
            }
        }

        public void RecorrerDes(ListBox lista)
        {
            clsNodo aux = Ultimo;
            lista.Items.Clear();

            while (aux != null)
            {
                lista.Items.Add(
                    aux.Codigo + " - " +
                    aux.Nombre + " - " +
                    aux.Tramite
                );

                aux = aux.anterior;
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
