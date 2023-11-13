namespace ProiectPoo
{
    public partial class Meniu : Form
    {
        public Meniu()//constructor
        {
            InitializeComponent();
        }
        string path = "E:\\projects visual studio\\Catan\\ProiectPoo\\Config.txt"; //calea de acces a fisierului

        private void Start_Click(object sender, EventArgs e)
        {
            this.Hide();//ascund prima interf meniu
            WindowJoc windowJoc = new WindowJoc();//se deschide fereastra de joc
            windowJoc.ShowDialog();
            this.Show();//dupa ce inchid apare iar meniu
        }

        private void Config_Click(object sender, EventArgs e)
        {
            this.Hide();
            Configurare configurare = new Configurare();
            configurare.ShowDialog();
            this.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Despre_Click(object sender, EventArgs e)
        {
            string nume = "Radeanu Liviu Eduard";
            string titlu = "Despre";
            MessageBox.Show(nume, titlu);
        }
        public void ScrieDimensiune(int dim) //schimba dimensiunea din txt
        {
            StreamReader sr = new StreamReader(path);//citeste fisierul txt 
            string valori = sr.ReadToEnd();
            string[] val = valori.Split(','); //împarte șirul de caractere într-un tablou de string-uri
            sr.Close();
            val[0] = dim.ToString();//prima valoare se trans in dim data(string obligatoriu)
            StreamWriter sw = new StreamWriter(path);//rescrie in txt ....
            string linieFinala = val[0] + ',' + val[1] + ',' + val[2] + ',' + val[3];
            sw.Write(linieFinala);//linia creata
            sw.Close();
        }
        public void ScrieDificultate(string dificultate)
        {
            StreamReader sr = new StreamReader(path);
            string valori = sr.ReadToEnd();
            string[] val = valori.Split(',');
            sr.Close();
            val[1] = dificultate; //valoarea dif de sus
            StreamWriter sw = new StreamWriter(path);
            string linieFinala = val[0] + ',' + val[1] + ',' + val[2] + ',' + val[3];
            sw.Write(linieFinala);
            sw.Close();
        }
        public void ScriePasi(int pasi)
        {
            StreamReader sr = new StreamReader(path);
            string valori = sr.ReadToEnd();
            string[] val = valori.Split(',');
            sr.Close();
            val[2] = pasi.ToString();
            StreamWriter sw = new StreamWriter(path);
            string linieFinala = val[0] + ',' + val[1] + ',' + val[2] + ',' + val[3];
            sw.Write(linieFinala);
            sw.Close();
        }
        public void ScrieTimp(int minute)
        {
            StreamReader sr = new StreamReader(path);
            string valori = sr.ReadToEnd();
            string[] val = valori.Split(',');
            sr.Close();
            val[3] = minute.ToString();
            StreamWriter sw = new StreamWriter(path);
            string linieFinala = val[0] + ',' + val[1] + ',' + val[2] + ',' + val[3];
            sw.Write(linieFinala);
            sw.Close();
        }


        


        private void x4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x5ToolStripMenuItem.Checked = false;
            x6ToolStripMenuItem.Checked = false;
            ScrieDimensiune(3);
        }

        private void x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x4ToolStripMenuItem.Checked = false;
            x6ToolStripMenuItem.Checked = false;
            ScrieDimensiune(4);
        }

        private void x6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x4ToolStripMenuItem.Checked = false;
            x5ToolStripMenuItem.Checked = false;
            ScrieDimensiune(5);
        }
        private void incepatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avansatToolStripMenuItem.Checked = false;
            mediuToolStripMenuItem.Checked = false;
            ScrieDificultate("incepator");
        }

        private void mediuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avansatToolStripMenuItem.Checked = false;
            incepatorToolStripMenuItem.Checked = false;
            ScrieDificultate("mediu");
        }

        private void avansatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mediuToolStripMenuItem.Checked = false;
            incepatorToolStripMenuItem.Checked = false;
            ScrieDificultate("avansat");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            ScriePasi(32);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem4.Checked = false;
            ScriePasi(42);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            ScriePasi(52);
        }

        private void minutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            minuteToolStripMenuItem.Checked = false;
            minuteToolStripMenuItem1.Checked = false;
            ScrieTimp(1);
        }

        private void minuteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            minuteToolStripMenuItem1.Checked = false;
            minutToolStripMenuItem.Checked = false;
            ScrieTimp(2);
        }

        private void minuteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            minutToolStripMenuItem.Checked = false;
            minuteToolStripMenuItem.Checked = false;
            ScrieTimp(3);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}