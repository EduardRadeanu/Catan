using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPoo
{
    public partial class WindowJoc : Form
    {
        public WindowJoc()
        {
            InitializeComponent();
        }
        Image img;
        Graphics g;
        Plansa Plansa;
        int dim, pasi, timp;
        string dificultate;
        TimeSpan t;

        private void WindowJoc_Load(object sender, EventArgs e)
        {
            citesteSetari();
            img = new Bitmap(p.Width, p.Height);
            g = Graphics.FromImage(img);
            Plansa = new Plansa(dim, pasi, timp, p.Width, p.Height, dificultate, g);
            Plansa.StartJoc();
            label4.Text = pasi.ToString();
            startTimer();

        }
        void citesteSetari()
        {
            string path = "E:\\projects visual studio\\Catan\\ProiectPoo\\Config.txt";
            StreamReader sr = new StreamReader(path);
            string line = sr.ReadToEnd();
            string[] setari = line.Split(',');
            dim = int.Parse(setari[0]);
            dificultate = setari[1];
            pasi = int.Parse(setari[2]);
            timp = int.Parse(setari[3]);
        }
        private void startTimer()
        {
            t = System.DateTime.Now - System.DateTime.MinValue;
            timer1.Start();
        }

        private void p_Click(object sender, EventArgs e)
        {

        }

        private void p_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(img, 0, 0);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string path = "E:\\projects visual studio\\Catan\\ProiectPoo\\Plansa.png";
            img.Save(path);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now - t;
            string s_min = Convert.ToString(dt.Minute);
            string s_sec = Convert.ToString(dt.Second);
            string s_mil = Convert.ToString(dt.Millisecond);

            string g_min = Convert.ToString(timp - dt.Minute);
            string g_sec = Convert.ToString(59 - dt.Second);
            string g_mil = Convert.ToString(1000 - dt.Millisecond);

            if (s_min.Length == 1) s_min = '0' + s_min;
            if (s_sec.Length == 1) s_sec = '0' + s_sec;
            if (s_mil.Length == 1) s_mil = '0' + s_mil;
            if (g_min.Length == 1) g_min = '0' + g_min;
            if (g_sec.Length == 1) g_sec = '0' + g_sec;
            if (g_mil.Length == 1) g_mil = '0' + g_mil;



            s_mil = s_mil.Substring(0, 2);
            g_mil = g_mil.Substring(0, 2);
            label2.Text = s_min + ':' + s_sec + ':' + s_mil;
            label3.Text = g_min + ':' + g_sec + ':' + g_mil;
            if (g_min == "00" && g_sec == "00")
            {
                timer1.Stop();
                MessageBox.Show("Timpul s-a scurs!", "Game Over!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
