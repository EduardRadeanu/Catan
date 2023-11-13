using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPoo
{
    internal class Plansa
    {
        List<hexagon> hexagoane=new List<hexagon>();//lista de hex
        int dim, size=30, w, h,pasi,timp;//variabilele
        string dificultate;
        Graphics g;         //obiectele
        hexagon start, finish;
        public Pion caracter=new Pion();
        public Plansa(int dim,int pasi,int timp,int w,int h,string dificultate,Graphics g) //constructor
        {
            this.dim = dim;
            this.pasi = pasi;
            this.timp = timp;
            this.w = w;
            this.h = h;
            this.dificultate = dificultate;
            this.g = g;
        }
        public void StartJoc() //inițializează și desenează hexagoanele pe planșă prin apelul altor metode   
        {
            creazaHexagoane();
            deseneazaHexagoane();
        }
        void creazaHexagoane() // creaza hexagoanele și le adauga în lista hexagoane
        {
            start = new hexagon(-dim, 0, dim, 30);
            finish = new hexagon(dim, 0, -dim, 30);
            for(int x=-dim;x<=dim;x++) //buclă dublă,  repeta coord hex,le creaza  cu coord date și dim specificată
            {
                for(int y=Math.Max(-dim,-x-dim);y<=Math.Min(dim,-x+dim);y++)
                {
                    int z = -x - y;
                    hexagon nou = new hexagon(x, y, z, size);
                    nou.cubToCartezian(w, h);//transformare din coord cubice în coord carteziene
                    if (nou==start||nou==finish) //daca e hex de start sau inceput atunci verde,daca nu...
                    {
                        nou.culoare = Color.Green;
                    }
                    else
                    {
                        adaugaElementSpecial(nou);
                    }
                    hexagoane.Add(nou); //hexagonul este adăugat în lista hexagoane
                }
            }
            

        }
        void adaugaElementSpecial(hexagon a) //primește un obiect de tip hex și adaugă un el special ....
        {
            Random r = new Random();//la acel hexagon, în funcție de un număr generat aleatoriu
            int n = r.Next(0, 4);
            switch(n)
            {
                case 0:
                    a.element = new Pom((int)a.centru.X, (int)a.centru.Y);
                    break;
                case 1:
                    a.element = new CufarRandom((int)a.centru.X, (int)a.centru.Y);
                    break;
                case 2:
                    a.element = new cufarSigur((int)a.centru.X, (int)a.centru.Y);
                    break;
                case 3:
                    a.element = new Scor((int)a.centru.X, (int)a.centru.Y);
                    break;
            }
        }
        void deseneazaHexagoane() //deseneaza pe plansa
        {
            foreach(hexagon curent in hexagoane) //parcurge liste de hex
            {
                curent.deseneaza(g);
                if(curent.element!=null) //Dacă hex are un el special, este desenat
                {
                    curent.element.desenare(g);
                }
            }
            start.cubToCartezian(w, h); //hex de start este transf în coord carteziene
            caracter.centru.X = start.centru.X - 15;//hex desenat în fct de coord hex de start
            caracter.centru.Y = start.centru.Y - 15;
            caracter.deseneaza(g);
        }

    }
}
