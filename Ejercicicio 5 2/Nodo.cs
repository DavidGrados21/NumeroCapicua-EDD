using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicicio_5_2
{
    internal class Nodo
    {
        private int vinfo;
        private Nodo vsgte;
        private Nodo vante;

        public int info
        {
            get { return vinfo; }
            set { vinfo = value; }
        }

        public Nodo sgte
        {
            get { return vsgte; }
            set { vsgte = value; }
        }

        public Nodo ante
        {
            get { return vante; }
            set { vante = value; }
        }

        public Nodo (int vinfo)
        {
            info = vinfo;
            sgte = vsgte;
            ante = vante;
        }
        public Nodo(int vinfo, Nodo vsgte, Nodo vante)
        {
            info = vinfo;
            sgte = vsgte;
            ante = vante;
        }
    }
}
