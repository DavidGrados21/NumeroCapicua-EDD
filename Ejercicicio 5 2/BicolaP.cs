using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicicio_5_2
{
    internal class BicolaP
    {
        private Nodo vprimero;
        private Nodo vultimo;

        public Nodo primero
        {
            get { return vprimero; }
            set { vprimero = value; }
        }

        public Nodo ultimo
        {
            get { return vultimo; }
            set { vultimo = value; }
        }

        public void encolarAdelante(int x)
        {
            Nodo nuevo = new Nodo(x);

            if (primero == null)
            {
                ultimo = nuevo;
            }
            else
            {
                primero.ante = nuevo;
                nuevo.sgte = primero;
            }
            primero = nuevo;
        }

        public int desencolarDelante()
        {
            int x;
            x = primero.info;
            primero = primero.sgte;
            if (primero == null)
                ultimo = null;
            return x;
        }

        public bool esVacia()
        {
            if (primero == null)
                return true;
            else
                return false;
        }

        public void mostrar(ListBox lst)
        {
            Nodo actual = primero;
            lst.Items.Clear();
            while (actual != null)
            {
                lst.Items.Add(actual.info);
                actual = actual.sgte;
            }
        }

        public bool capicua(int n, string numero, BicolaC cola, BicolaP pila)
        {
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(numero[i].ToString());
                pila.encolarAdelante(x);
                cola.encolarPorDetras(x);
            }

            bool exito = true;

            while (pila.primero != null)
            {
                if (pila.desencolarDelante() != cola.desencolarDelante())
                {
                    exito = false;
                }
            }
            return exito;
        }
    }
}
