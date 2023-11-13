using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPoo
{
    public abstract class ElementeSpeciale
    {
        int coordonataX, coordonataY;//suprafata grafica
        Image Sprite;
        int punctaj;
        public int X
        {
            get { return coordonataX; } //permite accesul la variabilele private
            set { coordonataX = value; }//incapsulare
        }
        public int Y
        {
            get { return coordonataY; }//incapsulare
            set { coordonataY = value; }
        }
        public Image Image
        {
            get { return Sprite; }//incapsulare
            set { Sprite = value; }
        }
        public int Punctaj
        {
            get { return punctaj; }//incapsulare
            set { punctaj = value; }
        }


        public abstract void desenare(Graphics b);//deseneaza elem spec
    }
    public class Pom : ElementeSpeciale //mostenire
    {
        public Pom(int x, int y)//constructor
        {
            X = x - 15;//ajustarea pozitiei pomului in centrul imaginii
            Y = y - 15;
            Image = Properties.Resources.Pom;
        }
        public override void desenare(Graphics b) //polimorfism
        {
            b.DrawImage(Image, X, Y, 30, 30);//dimensiune 30 pe 30 si deseneaza pomul
        }
    }
    public class cufarSigur : ElementeSpeciale //mostenire
    {
        public cufarSigur(int x, int y) //constructor
        {
            X = x - 15;//la fel ca mai sus
            Y = y - 15;
            Image = Properties.Resources.CufarSigur;
            Punctaj = 50;
        }
        public override void desenare(Graphics b) //polimorfism
        {
            b.DrawImage(Image, X, Y, 30, 30);//deseneaza cufarul
        }
    }
    public class CufarRandom : ElementeSpeciale //mostenire
    {
        Random r=new Random();//genereaza numere aleatorii
        public CufarRandom(int x, int y)//constructor
        {
            X= x - 15;//la fel ca sus
            Y= y - 15;
            Punctaj = r.Next(-50, 51);//punctaj=nr aleatoriu intre -50 si 50
            Image = Properties.Resources.cufarRandom;
        }
        public override void desenare(Graphics b) //polimorf
        {
            b.DrawImage(Image, X, Y, 30, 30);//deseneaza cufarul
        }
    }
    public class Scor:ElementeSpeciale
    {
        Random r=new Random();//nr aleatoriu
        public Scor(int x, int y)//constructor//incapsulare
        {
            X= x - 10;
            Y= y - 10;
            int n=r.Next(0, 2);//n=valoare aleatoare între 0 și 1 utilizând obiectul Random
            if (n==0)
                Punctaj=-1*5*r.Next(1, 4);
            else
                Punctaj=5*r.Next(1, 4);
        }
        public override void desenare(Graphics b)//deseneaza punctajul pe imeagine //polimorf
        {
            Font font = new Font("Bold", 12);
            SolidBrush culoare = new SolidBrush(Color.Black);
            b.DrawString(Punctaj.ToString(), font, culoare, new RectangleF(X, Y, 30, 30));
            //primește textul punctajului convertit la șir de caractere, obiectul font, obiectul brush și un obiect RectangleF
            //rectanfleF=specifică poziția și dimensiunea dreptunghiului în care se va desena textul
        }

    }
}

