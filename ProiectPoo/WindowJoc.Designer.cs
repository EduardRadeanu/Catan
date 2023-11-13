namespace ProiectPoo
{
    partial class WindowJoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null; //componentele vizuale=interfata

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)//eliberarea resurselor utilizate de fereastră //polimorf
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()//inițializate și configurate componentele vizuale ale ferestrei
        {
            components = new System.ComponentModel.Container();
            p = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Save = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)p).BeginInit();
            SuspendLayout();
            // 
            // p
            // 
            p.Location = new Point(4, 106);
            p.Name = "p";
            p.Size = new Size(1078, 552);
            p.TabIndex = 0;
            p.TabStop = false;
            p.Click += p_Click;
            p.Paint += p_Paint;
            // 
            // label1
            // 
            label1.Location = new Point(4, 31);
            label1.Name = "label1";
            label1.Size = new Size(242, 72);
            label1.TabIndex = 1;
            label1.Text = "Scor:";
            // 
            // label2
            // 
            label2.Location = new Point(230, 31);
            label2.Name = "label2";
            label2.Size = new Size(242, 72);
            label2.TabIndex = 2;
            label2.Text = "Timp Scurs:";
            // 
            // label3
            // 
            label3.Location = new Point(458, 31);
            label3.Name = "label3";
            label3.Size = new Size(242, 72);
            label3.TabIndex = 3;
            label3.Text = "TimpRamas:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Location = new Point(706, 31);
            label4.Name = "label4";
            label4.Size = new Size(242, 72);
            label4.TabIndex = 4;
            label4.Text = "Pasi:";
            // 
            // Save
            // 
            Save.Location = new Point(954, 12);
            Save.Name = "Save";
            Save.Size = new Size(61, 59);
            Save.TabIndex = 5;
            Save.Text = "Salvare";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1021, 12);
            button2.Name = "button2";
            button2.Size = new Size(61, 59);
            button2.TabIndex = 6;
            button2.Text = "Printare";
            button2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // WindowJoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 663);
            Controls.Add(button2);
            Controls.Add(Save);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(p);
            Name = "WindowJoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WindowJoc";
            Load += WindowJoc_Load;
            ((System.ComponentModel.ISupportInitialize)p).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox p; //variabile
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Save;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}