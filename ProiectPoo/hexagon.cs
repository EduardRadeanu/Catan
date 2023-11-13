using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//hexagon in sist de coord tridimensional

namespace ProiectPoo
{
    internal class hexagon //clasa accesata doar in fisierul sursa
    {
        private int x, y, z; //variabilele clasei hexagon
        public PointF centru;
        public bool valind=true;
        public Color culoare = Color.Crimson;
        int size;
        public ElementeSpeciale element;
        public int X //coordonatele x,y,z
        {
            get { return x; } //incapsulare
            set { x = value; }
        }
        public int Y
        {
            get { return y; }//incapsulare
            set { y = value; }
        }
        public int Z
        {
            get { return z; }//incapsulare
            set { z = value; }
        }
        public hexagon(int x,int y, int z, int size) //constructorii
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.size = size;
        }
        public hexagon(PointF centru,int size)
        {
            this.centru = centru;
            this.size = size;
        }
        static public bool operator==(hexagon a,hexagon b)//supraincarcarea op == si != pt compararea a doua hexagoane
        {
            if(a.X==b.X&&a.Y==b.Y&&a.Z==b.Z) return true;
            return false;
        }
        static public bool operator!=(hexagon a, hexagon b)
        {
            return !(a == b);
        }
        public void deseneaza(Graphics g)//deseneneaza hexagonul folosiind coord cercului
        {
            PointF[] Varfuri=new PointF[6];
            for (int i = 0; i < 6; i++)
            {
                float radiani = (float)Math.PI / 180 * (60 * i + 30);// triunghiuri echilat
                Varfuri[i] = new PointF(this.centru.X + size * (float)Math.Cos(radiani), this.centru.Y + size * (float)Math.Sin(radiani));
            }
            g.FillPolygon(new SolidBrush(this.culoare), Varfuri);//umple hex
            g.DrawPolygon(new Pen(Color.Black,1), Varfuri);//deseneaza conturul hex
        }
        public void cubToCartezian(int Width,int Height)//sist de coord cubice, primeste inalt si lung hex
        {
            centru.X=(int)(Width/2+size*((float)Math.Sqrt(3)*this.x+Math.Sqrt(3)/2*this.y));
            centru.Y = (int)(Height / 2 + ((3 * size) / 2) * this.y);
        }



    }
}
