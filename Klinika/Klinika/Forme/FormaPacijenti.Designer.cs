namespace Klinika.Forme
{
    partial class FormaPacijenti
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
            brojKartona = new ColumnHeader();
            imePacijenta = new ColumnHeader();
            prezimePacijenta = new ColumnHeader();
            datumRodj = new ColumnHeader();
            pol = new ColumnHeader();
            adresa = new ColumnHeader();
            kontaktTel = new ColumnHeader();
            email = new ColumnHeader();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            tbBrPregleda = new TextBox();
            tbIzabrani = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { brojKartona, imePacijenta, prezimePacijenta, datumRodj, pol, adresa, kontaktTel, email });
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 207);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // brojKartona
            // 
            brojKartona.Text = "Broj Kartona";
            brojKartona.Width = 120;
            // 
            // imePacijenta
            // 
            imePacijenta.Text = "Ime";
            imePacijenta.Width = 100;
            // 
            // prezimePacijenta
            // 
            prezimePacijenta.Text = "Prezime";
            prezimePacijenta.Width = 100;
            // 
            // datumRodj
            // 
            datumRodj.DisplayIndex = 4;
            datumRodj.Text = "Datum Rodjenja";
            datumRodj.Width = 120;
            // 
            // pol
            // 
            pol.DisplayIndex = 3;
            pol.Text = "Pol";
            pol.Width = 40;
            // 
            // adresa
            // 
            adresa.Text = "Adresa";
            // 
            // kontaktTel
            // 
            kontaktTel.Text = "Kontakt Telefon";
            kontaktTel.Width = 120;
            // 
            // email
            // 
            email.Text = "E-mail";
            email.Width = 120;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbBrPregleda);
            panel1.Controls.Add(tbIzabrani);
            panel1.Location = new Point(12, 236);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 202);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 19);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 3;
            label2.Text = "Izabrani Lekar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 116);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 2;
            label1.Text = "Broj Pregleda";
            // 
            // tbBrPregleda
            // 
            tbBrPregleda.Enabled = false;
            tbBrPregleda.Location = new Point(16, 139);
            tbBrPregleda.Name = "tbBrPregleda";
            tbBrPregleda.Size = new Size(173, 27);
            tbBrPregleda.TabIndex = 1;
            // 
            // tbIzabrani
            // 
            tbIzabrani.Enabled = false;
            tbIzabrani.Location = new Point(16, 42);
            tbIzabrani.Name = "tbIzabrani";
            tbIzabrani.Size = new Size(222, 27);
            tbIzabrani.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(432, 236);
            button1.Name = "button1";
            button1.Size = new Size(164, 69);
            button1.TabIndex = 2;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(624, 236);
            button2.Name = "button2";
            button2.Size = new Size(164, 69);
            button2.TabIndex = 3;
            button2.Text = "Obrisi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormaPacijenti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(listView1);
            Name = "FormaPacijenti";
            Text = "FormaPacijenti";
            Load += FormaPacijenti_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Panel panel1;
        public ColumnHeader brojKartona;
        public ColumnHeader imePacijenta;
        public ColumnHeader prezimePacijenta;
        public ColumnHeader datumRodj;
        public ColumnHeader pol;
        public ColumnHeader adresa;
        public ColumnHeader kontaktTel;
        public ColumnHeader email;
        private Label label2;
        private Label label1;
        private TextBox tbBrPregleda;
        private TextBox tbIzabrani;
        private Button button1;
        private Button button2;
    }
}