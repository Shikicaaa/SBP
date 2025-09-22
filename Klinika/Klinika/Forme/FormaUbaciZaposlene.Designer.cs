namespace Klinika.Forme
{
    partial class FormaUbaciZaposlene
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
            tbJMBG = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbIme = new TextBox();
            label3 = new Label();
            tbPrezime = new TextBox();
            label4 = new Label();
            label5 = new Label();
            tbEmail = new TextBox();
            label6 = new Label();
            tbKontaktTelefona = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tbAdresa = new TextBox();
            dtpRodjenje = new DateTimePicker();
            dtpDatumZaposlenja = new DateTimePicker();
            btnDodaj = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // tbJMBG
            // 
            tbJMBG.Location = new Point(143, 12);
            tbJMBG.Name = "tbJMBG";
            tbJMBG.Size = new Size(250, 27);
            tbJMBG.TabIndex = 0;
            tbJMBG.KeyPress += tbTip_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "JMBG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 3;
            label2.Text = "Ime";
            // 
            // tbIme
            // 
            tbIme.Location = new Point(143, 45);
            tbIme.Name = "tbIme";
            tbIme.Size = new Size(250, 27);
            tbIme.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 85);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 5;
            label3.Text = "Prezime";
            // 
            // tbPrezime
            // 
            tbPrezime.Location = new Point(143, 78);
            tbPrezime.Name = "tbPrezime";
            tbPrezime.Size = new Size(250, 27);
            tbPrezime.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 118);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 7;
            label4.Text = "Datum Rodjenja";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 151);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 9;
            label5.Text = "Email";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(143, 148);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(250, 27);
            tbEmail.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 184);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 11;
            label6.Text = "Kontakt Telefon";
            // 
            // tbKontaktTelefona
            // 
            tbKontaktTelefona.Location = new Point(143, 181);
            tbKontaktTelefona.Name = "tbKontaktTelefona";
            tbKontaktTelefona.Size = new Size(250, 27);
            tbKontaktTelefona.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 217);
            label7.Name = "label7";
            label7.Size = new Size(131, 20);
            label7.TabIndex = 13;
            label7.Text = "Datum Zaposlenja";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 250);
            label8.Name = "label8";
            label8.Size = new Size(30, 20);
            label8.TabIndex = 15;
            label8.Text = "Tip";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 283);
            label9.Name = "label9";
            label9.Size = new Size(55, 20);
            label9.TabIndex = 17;
            label9.Text = "Adresa";
            // 
            // tbAdresa
            // 
            tbAdresa.Location = new Point(143, 283);
            tbAdresa.Name = "tbAdresa";
            tbAdresa.Size = new Size(250, 27);
            tbAdresa.TabIndex = 16;
            // 
            // dtpRodjenje
            // 
            dtpRodjenje.Location = new Point(143, 111);
            dtpRodjenje.Name = "dtpRodjenje";
            dtpRodjenje.Size = new Size(250, 27);
            dtpRodjenje.TabIndex = 18;
            // 
            // dtpDatumZaposlenja
            // 
            dtpDatumZaposlenja.Location = new Point(143, 217);
            dtpDatumZaposlenja.Name = "dtpDatumZaposlenja";
            dtpDatumZaposlenja.Size = new Size(250, 27);
            dtpDatumZaposlenja.TabIndex = 19;
            // 
            // btnDodaj
            // 
            btnDodaj.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDodaj.Location = new Point(143, 316);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(250, 44);
            btnDodaj.TabIndex = 20;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Lekar", "Laborant", "Medicinska Sestra", "Administracija" });
            comboBox1.Location = new Point(143, 250);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 28);
            comboBox1.TabIndex = 21;
            // 
            // FormaUbaciZaposlene
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(418, 374);
            Controls.Add(comboBox1);
            Controls.Add(btnDodaj);
            Controls.Add(dtpDatumZaposlenja);
            Controls.Add(dtpRodjenje);
            Controls.Add(label9);
            Controls.Add(tbAdresa);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(tbKontaktTelefona);
            Controls.Add(label5);
            Controls.Add(tbEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbPrezime);
            Controls.Add(label2);
            Controls.Add(tbIme);
            Controls.Add(label1);
            Controls.Add(tbJMBG);
            Name = "FormaUbaciZaposlene";
            Text = "FormaUbaciZaposlene";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbJMBG;
        private Label label1;
        private Label label2;
        private TextBox tbIme;
        private Label label3;
        private TextBox tbPrezime;
        private Label label4;
        private Label label5;
        private TextBox tbEmail;
        private Label label6;
        private TextBox tbKontaktTelefona;
        private Label label7;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox8;
        private Label label9;
        private TextBox tbAdresa;
        private DateTimePicker dtpRodjenje;
        private DateTimePicker dtpDatumZaposlenja;
        private Button btnDodaj;
        private ComboBox comboBox1;
    }
}