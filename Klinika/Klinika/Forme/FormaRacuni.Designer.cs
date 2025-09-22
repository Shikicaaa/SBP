namespace Klinika.Forme
{
    partial class FormaRacuni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
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
        private void InitializeComponent()
        {
            listView1 = new ListView();
            idRacuna = new ColumnHeader();
            cena = new ColumnHeader();
            nacin = new ColumnHeader();
            datum = new ColumnHeader();
            label1 = new Label();
            panel1 = new Panel();
            tbOsiguranje = new TextBox();
            label5 = new Label();
            tbPacijent = new TextBox();
            label4 = new Label();
            tbNacin = new TextBox();
            label3 = new Label();
            tbCena = new TextBox();
            listBox1 = new ListBox();
            label2 = new Label();
            panel2 = new Panel();
            checkBox1 = new CheckBox();
            tbPacOsiguranje = new TextBox();
            label10 = new Label();
            tbPacijentMail = new TextBox();
            label9 = new Label();
            tbIzabrani = new TextBox();
            label8 = new Label();
            tbPacBrKart = new TextBox();
            label7 = new Label();
            tbPacijentFull = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { idRacuna, cena, nacin, datum });
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(446, 170);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // idRacuna
            // 
            idRacuna.DisplayIndex = 3;
            idRacuna.Text = "ID";
            // 
            // cena
            // 
            cena.DisplayIndex = 0;
            cena.Text = "Cena";
            cena.Width = 100;
            // 
            // nacin
            // 
            nacin.DisplayIndex = 1;
            nacin.Text = "Nacin Placanja";
            nacin.Width = 100;
            // 
            // datum
            // 
            datum.DisplayIndex = 2;
            datum.Text = "Datum Placanja";
            datum.Width = 120;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 1;
            label1.Text = "Cena";
            // 
            // panel1
            // 
            panel1.Controls.Add(tbOsiguranje);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbPacijent);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbNacin);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbCena);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 188);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 250);
            panel1.TabIndex = 2;
            // 
            // tbOsiguranje
            // 
            tbOsiguranje.Enabled = false;
            tbOsiguranje.Location = new Point(303, 76);
            tbOsiguranje.Name = "tbOsiguranje";
            tbOsiguranje.Size = new Size(125, 27);
            tbOsiguranje.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(303, 53);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 9;
            label5.Text = "Osiguranje Platilo";
            // 
            // tbPacijent
            // 
            tbPacijent.Enabled = false;
            tbPacijent.Location = new Point(303, 23);
            tbPacijent.Name = "tbPacijent";
            tbPacijent.Size = new Size(125, 27);
            tbPacijent.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(300, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 7;
            label4.Text = "Pacijent Platio";
            // 
            // tbNacin
            // 
            tbNacin.Enabled = false;
            tbNacin.Location = new Point(3, 88);
            tbNacin.Name = "tbNacin";
            tbNacin.Size = new Size(125, 27);
            tbNacin.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 65);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 5;
            label3.Text = "Nacin Placanja";
            // 
            // tbCena
            // 
            tbCena.Enabled = false;
            tbCena.Location = new Point(3, 23);
            tbCena.Name = "tbCena";
            tbCena.Size = new Size(125, 27);
            tbCena.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.Enabled = false;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(147, 23);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 204);
            listBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 2;
            label2.Text = "Stavke";
            // 
            // panel2
            // 
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(tbPacOsiguranje);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(tbPacijentMail);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(tbIzabrani);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(tbPacBrKart);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(tbPacijentFull);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(464, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 279);
            panel2.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Enabled = false;
            checkBox1.Location = new Point(131, 235);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(90, 24);
            checkBox1.TabIndex = 21;
            checkBox1.Text = "Poseduje";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // tbPacOsiguranje
            // 
            tbPacOsiguranje.Enabled = false;
            tbPacOsiguranje.Location = new Point(3, 232);
            tbPacOsiguranje.Name = "tbPacOsiguranje";
            tbPacOsiguranje.Size = new Size(125, 27);
            tbPacOsiguranje.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(0, 212);
            label10.Name = "label10";
            label10.Size = new Size(80, 20);
            label10.TabIndex = 19;
            label10.Text = "Osiguranje";
            // 
            // tbPacijentMail
            // 
            tbPacijentMail.Enabled = false;
            tbPacijentMail.Location = new Point(3, 182);
            tbPacijentMail.Name = "tbPacijentMail";
            tbPacijentMail.Size = new Size(144, 27);
            tbPacijentMail.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 159);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 17;
            label9.Text = "Kontakt";
            // 
            // tbIzabrani
            // 
            tbIzabrani.Enabled = false;
            tbIzabrani.Location = new Point(3, 129);
            tbIzabrani.Name = "tbIzabrani";
            tbIzabrani.Size = new Size(144, 27);
            tbIzabrani.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 106);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 15;
            label8.Text = "Izabrani Lekar";
            // 
            // tbPacBrKart
            // 
            tbPacBrKart.Enabled = false;
            tbPacBrKart.Location = new Point(3, 76);
            tbPacBrKart.Name = "tbPacBrKart";
            tbPacBrKart.Size = new Size(144, 27);
            tbPacBrKart.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 53);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 13;
            label7.Text = "Broj Kartona";
            // 
            // tbPacijentFull
            // 
            tbPacijentFull.Enabled = false;
            tbPacijentFull.Location = new Point(3, 23);
            tbPacijentFull.Name = "tbPacijentFull";
            tbPacijentFull.Size = new Size(144, 27);
            tbPacijentFull.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 11;
            label6.Text = "Pacijent";
            // 
            // FormaRacuni
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(720, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(listView1);
            Name = "FormaRacuni";
            Text = "FormaRacuni";
            Load += FormaRacuni_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader cena;
        private ColumnHeader nacin;
        private ColumnHeader datum;
        private Label label1;
        private Panel panel1;
        private TextBox tbNacin;
        private Label label3;
        private TextBox tbCena;
        private ListBox listBox1;
        private Label label2;
        private TextBox tbPacijent;
        private Label label4;
        private TextBox tbOsiguranje;
        private Label label5;
        private ColumnHeader idRacuna;
        private Panel panel2;
        private CheckBox checkBox1;
        private TextBox tbPacOsiguranje;
        private Label label10;
        private TextBox tbPacijentMail;
        private Label label9;
        private TextBox tbIzabrani;
        private Label label8;
        private TextBox tbPacBrKart;
        private Label label7;
        private TextBox tbPacijentFull;
        private Label label6;
    }
}