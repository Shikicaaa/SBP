namespace Klinika.Forme
{
    partial class FormaDodajPacijenta
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
            tbIme = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbPrezime = new TextBox();
            label3 = new Label();
            tbAdresa = new TextBox();
            label4 = new Label();
            tbEmail = new TextBox();
            label5 = new Label();
            tbBrojrfzo = new TextBox();
            label6 = new Label();
            tbBrojKartona = new TextBox();
            label7 = new Label();
            label8 = new Label();
            rbMusko = new RadioButton();
            rbZensko = new RadioButton();
            label9 = new Label();
            datumRodjPicker = new DateTimePicker();
            groupBox1 = new GroupBox();
            rbImaRfzo = new RadioButton();
            lvLekari = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            button1 = new Button();
            label10 = new Label();
            tbKontaktTel = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tbIme
            // 
            tbIme.Location = new Point(8, 31);
            tbIme.Name = "tbIme";
            tbIme.Size = new Size(125, 27);
            tbIme.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 1;
            label1.Text = "Ime";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 66);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 3;
            label2.Text = "Prezime";
            // 
            // tbPrezime
            // 
            tbPrezime.Location = new Point(8, 89);
            tbPrezime.Name = "tbPrezime";
            tbPrezime.Size = new Size(125, 27);
            tbPrezime.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 173);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 5;
            label3.Text = "Adresa";
            // 
            // tbAdresa
            // 
            tbAdresa.Location = new Point(8, 196);
            tbAdresa.Name = "tbAdresa";
            tbAdresa.Size = new Size(125, 27);
            tbAdresa.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(178, 9);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "E mail";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(178, 31);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(125, 27);
            tbEmail.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(178, 66);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 9;
            label5.Text = "Broj Rfzo";
            // 
            // tbBrojrfzo
            // 
            tbBrojrfzo.Location = new Point(178, 89);
            tbBrojrfzo.Name = "tbBrojrfzo";
            tbBrojrfzo.Size = new Size(125, 27);
            tbBrojrfzo.TabIndex = 8;
            tbBrojrfzo.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(178, 173);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 11;
            label6.Text = "Broj Kartona";
            // 
            // tbBrojKartona
            // 
            tbBrojKartona.Location = new Point(178, 196);
            tbBrojKartona.Name = "tbBrojKartona";
            tbBrojKartona.Size = new Size(125, 27);
            tbBrojKartona.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(332, 8);
            label7.Name = "label7";
            label7.Size = new Size(117, 20);
            label7.TabIndex = 13;
            label7.Text = "Ponudjeni Lekari";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 3);
            label8.Name = "label8";
            label8.Size = new Size(29, 20);
            label8.TabIndex = 14;
            label8.Text = "Pol";
            // 
            // rbMusko
            // 
            rbMusko.AutoSize = true;
            rbMusko.Location = new Point(6, 23);
            rbMusko.Name = "rbMusko";
            rbMusko.Size = new Size(43, 24);
            rbMusko.TabIndex = 15;
            rbMusko.TabStop = true;
            rbMusko.Text = "M";
            rbMusko.UseVisualStyleBackColor = true;
            // 
            // rbZensko
            // 
            rbZensko.AutoSize = true;
            rbZensko.Location = new Point(55, 23);
            rbZensko.Name = "rbZensko";
            rbZensko.Size = new Size(39, 24);
            rbZensko.TabIndex = 16;
            rbZensko.TabStop = true;
            rbZensko.Text = "Z";
            rbZensko.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 226);
            label9.Name = "label9";
            label9.Size = new Size(117, 20);
            label9.TabIndex = 17;
            label9.Text = "Datum Rodjenja";
            // 
            // datumRodjPicker
            // 
            datumRodjPicker.Format = DateTimePickerFormat.Short;
            datumRodjPicker.Location = new Point(8, 249);
            datumRodjPicker.Name = "datumRodjPicker";
            datumRodjPicker.Size = new Size(125, 27);
            datumRodjPicker.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbZensko);
            groupBox1.Controls.Add(rbMusko);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(8, 119);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(102, 51);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // rbImaRfzo
            // 
            rbImaRfzo.AutoSize = true;
            rbImaRfzo.Location = new Point(178, 142);
            rbImaRfzo.Name = "rbImaRfzo";
            rbImaRfzo.Size = new Size(95, 24);
            rbImaRfzo.TabIndex = 20;
            rbImaRfzo.TabStop = true;
            rbImaRfzo.Text = "Ima RFZO";
            rbImaRfzo.UseVisualStyleBackColor = true;
            // 
            // lvLekari
            // 
            lvLekari.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvLekari.Location = new Point(332, 31);
            lvLekari.Name = "lvLekari";
            lvLekari.Size = new Size(468, 370);
            lvLekari.TabIndex = 21;
            lvLekari.UseCompatibleStateImageBehavior = false;
            lvLekari.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ime";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Prezime";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "JMBG";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Specijalizacija";
            columnHeader4.Width = 100;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(63, 344);
            button1.Name = "button1";
            button1.Size = new Size(150, 57);
            button1.TabIndex = 22;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(178, 228);
            label10.Name = "label10";
            label10.Size = new Size(83, 20);
            label10.TabIndex = 24;
            label10.Text = "Kontakt Tel";
            // 
            // tbKontaktTel
            // 
            tbKontaktTel.Location = new Point(178, 251);
            tbKontaktTel.Name = "tbKontaktTel";
            tbKontaktTel.Size = new Size(125, 27);
            tbKontaktTel.TabIndex = 23;
            // 
            // FormaDodajPacijenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(825, 450);
            Controls.Add(label10);
            Controls.Add(tbKontaktTel);
            Controls.Add(button1);
            Controls.Add(lvLekari);
            Controls.Add(rbImaRfzo);
            Controls.Add(groupBox1);
            Controls.Add(datumRodjPicker);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(tbBrojKartona);
            Controls.Add(label5);
            Controls.Add(tbBrojrfzo);
            Controls.Add(label4);
            Controls.Add(tbEmail);
            Controls.Add(label3);
            Controls.Add(tbAdresa);
            Controls.Add(label2);
            Controls.Add(tbPrezime);
            Controls.Add(label1);
            Controls.Add(tbIme);
            Name = "FormaDodajPacijenta";
            Text = "FormaDodajPacijenta";
            Load += FormaDodajPacijenta_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbIme;
        private Label label1;
        private Label label2;
        private TextBox tbPrezime;
        private Label label3;
        private TextBox tbAdresa;
        private Label label4;
        private TextBox tbEmail;
        private Label label5;
        private TextBox tbBrojrfzo;
        private Label label6;
        private TextBox tbBrojKartona;
        private Label label7;
        private Label label8;
        private RadioButton rbMusko;
        private RadioButton rbZensko;
        private Label label9;
        private DateTimePicker datumRodjPicker;
        private GroupBox groupBox1;
        private RadioButton rbImaRfzo;
        private ListView lvLekari;
        private Button button1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label10;
        private TextBox tbKontaktTel;
    }
}