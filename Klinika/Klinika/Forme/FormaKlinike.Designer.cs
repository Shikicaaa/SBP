namespace Klinika
{
    partial class FormaKlinike
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
            idKolona = new ColumnHeader();
            nazivKolona = new ColumnHeader();
            lokacija = new ColumnHeader();
            brZaposlenih = new ColumnHeader();
            panel1 = new Panel();
            tbBrZaposlenih = new TextBox();
            lbLokacije = new ListBox();
            tbNazivKlinike = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button5 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { idKolona, nazivKolona, lokacija, brZaposlenih });
            listView1.Location = new Point(12, 16);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(568, 103);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // idKolona
            // 
            idKolona.Text = "ID";
            idKolona.Width = 50;
            // 
            // nazivKolona
            // 
            nazivKolona.Text = "Naziv Klinike";
            nazivKolona.Width = 200;
            // 
            // lokacija
            // 
            lokacija.Text = "Lokacija";
            lokacija.Width = 100;
            // 
            // brZaposlenih
            // 
            brZaposlenih.Text = "Broj Zaposlenih";
            brZaposlenih.Width = 120;
            // 
            // panel1
            // 
            panel1.Controls.Add(tbBrZaposlenih);
            panel1.Controls.Add(lbLokacije);
            panel1.Controls.Add(tbNazivKlinike);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 146);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 358);
            panel1.TabIndex = 2;
            // 
            // tbBrZaposlenih
            // 
            tbBrZaposlenih.Enabled = false;
            tbBrZaposlenih.Location = new Point(3, 178);
            tbBrZaposlenih.Name = "tbBrZaposlenih";
            tbBrZaposlenih.Size = new Size(190, 27);
            tbBrZaposlenih.TabIndex = 10;
            // 
            // lbLokacije
            // 
            lbLokacije.FormattingEnabled = true;
            lbLokacije.HorizontalScrollbar = true;
            lbLokacije.Location = new Point(0, 114);
            lbLokacije.Name = "lbLokacije";
            lbLokacije.Size = new Size(193, 24);
            lbLokacije.TabIndex = 9;
            // 
            // tbNazivKlinike
            // 
            tbNazivKlinike.Location = new Point(3, 52);
            tbNazivKlinike.Name = "tbNazivKlinike";
            tbNazivKlinike.Size = new Size(190, 27);
            tbNazivKlinike.TabIndex = 8;
            // 
            // button4
            // 
            button4.Location = new Point(243, 292);
            button4.Name = "button4";
            button4.Size = new Size(100, 50);
            button4.TabIndex = 6;
            button4.Text = "Izmeni Kliniku";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(3, 292);
            button3.Name = "button3";
            button3.Size = new Size(100, 50);
            button3.TabIndex = 5;
            button3.Text = "Obrisi kliniku";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(243, 125);
            button2.Name = "button2";
            button2.Size = new Size(100, 50);
            button2.TabIndex = 4;
            button2.Text = "Prikazi Zaposlene";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(243, 29);
            button1.Name = "button1";
            button1.Size = new Size(100, 50);
            button1.TabIndex = 3;
            button1.Text = "Prikazi odeljenja";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 155);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 2;
            label4.Text = "Broj Zaposlenih";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 91);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 1;
            label3.Text = "Lokacije";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 29);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 0;
            label2.Text = "Naziv";
            // 
            // button5
            // 
            button5.Location = new Point(388, 146);
            button5.Name = "button5";
            button5.Size = new Size(192, 50);
            button5.TabIndex = 7;
            button5.Text = "Dodaj Kliniku";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 134);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 3;
            label1.Text = "Podaci o klinici";
            // 
            // FormaKlinike
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(647, 514);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(listView1);
            Controls.Add(button5);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormaKlinike";
            Text = "FormaKlinike";
            Load += FormaKlinike_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView listView1;
        private ColumnHeader idKolona;
        private ColumnHeader nazivKolona;
        private ColumnHeader lokacija;
        private ColumnHeader brZaposlenih;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbBrZaposlenih;
        private ListBox lbLokacije;
        private TextBox tbNazivKlinike;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label4;
    }
}