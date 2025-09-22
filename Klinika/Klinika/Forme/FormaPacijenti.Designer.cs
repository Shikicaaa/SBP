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
            panel1.Location = new Point(12, 236);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 202);
            panel1.TabIndex = 1;
            // 
            // FormaPacijenti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(listView1);
            Name = "FormaPacijenti";
            Text = "FormaPacijenti";
            Load += FormaPacijenti_Load;
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
    }
}