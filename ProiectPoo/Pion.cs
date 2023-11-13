using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPoo
{
    internal class Pion
    {
        int x, y, z;//variabilele
        public PointF centru;
        Image poza;
        public Pion()
        {
            x = 0; //variabilele initializate cu 0=pozitia initiala
            y=0; 
            z=0;
            centru = new PointF(0, 0);
            poza = Properties.Resources.pion;
        }
        public void deseneaza(Graphics g)//afiseaza pionul intr o pozitie specifica
        {
            g.DrawImage(poza, centru.X, centru.Y, 30, 30);//latimea=h=30
        }
    }
}
