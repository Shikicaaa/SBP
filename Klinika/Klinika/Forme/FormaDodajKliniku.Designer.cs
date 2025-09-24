namespace Klinika.Forme
{
    partial class FormaDodajKliniku
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
            tbNaziv = new TextBox();
            label1 = new Label();
            lbOdeljenja = new ListBox();
            label2 = new Label();
            lbMogucaOdeljenja = new ListBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label5 = new Label();
            lbMoguciZaposleni = new ListBox();
            label6 = new Label();
            lbZaposleni = new ListBox();
            label4 = new Label();
            tbLokacija = new TextBox();
            label7 = new Label();
            tbRadnoVreme = new TextBox();
            SuspendLayout();
            // 
            // tbNaziv
            // 
            tbNaziv.Location = new Point(12, 48);
            tbNaziv.Name = "tbNaziv";
            tbNaziv.Size = new Size(232, 27);
            tbNaziv.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 1;
            label1.Text = "Naziv Klinike";
            // 
            // lbOdeljenja
            // 
            lbOdeljenja.FormattingEnabled = true;
            lbOdeljenja.Location = new Point(12, 168);
            lbOdeljenja.Name = "lbOdeljenja";
            lbOdeljenja.Size = new Size(150, 164);
            lbOdeljenja.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 145);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Odeljenja";
            // 
            // lbMogucaOdeljenja
            // 
            lbMogucaOdeljenja.FormattingEnabled = true;
            lbMogucaOdeljenja.Location = new Point(183, 168);
            lbMogucaOdeljenja.Name = "lbMogucaOdeljenja";
            lbMogucaOdeljenja.Size = new Size(150, 164);
            lbMogucaOdeljenja.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 145);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 5;
            label3.Text = "Moguca Odeljenja";
            // 
            // button1
            // 
            button1.Location = new Point(183, 338);
            button1.Name = "button1";
            button1.Size = new Size(150, 29);
            button1.TabIndex = 6;
            button1.Text = "Ubaci Odeljenje";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 338);
            button2.Name = "button2";
            button2.Size = new Size(150, 29);
            button2.TabIndex = 7;
            button2.Text = "Izbaci Odeljenje";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(273, 383);
            button3.Name = "button3";
            button3.Size = new Size(150, 55);
            button3.TabIndex = 10;
            button3.Text = "Unesi";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(359, 338);
            button4.Name = "button4";
            button4.Size = new Size(150, 29);
            button4.TabIndex = 16;
            button4.Text = "Izbaci Zaposlenog";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(530, 338);
            button5.Name = "button5";
            button5.Size = new Size(150, 29);
            button5.TabIndex = 15;
            button5.Text = "Ubaci Zaposlenog";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(530, 145);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 14;
            label5.Text = "Moguci Zaposleni";
            // 
            // lbMoguciZaposleni
            // 
            lbMoguciZaposleni.FormattingEnabled = true;
            lbMoguciZaposleni.Location = new Point(530, 168);
            lbMoguciZaposleni.Name = "lbMoguciZaposleni";
            lbMoguciZaposleni.Size = new Size(150, 164);
            lbMoguciZaposleni.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(359, 145);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 12;
            label6.Text = "Zaposleni";
            // 
            // lbZaposleni
            // 
            lbZaposleni.FormattingEnabled = true;
            lbZaposleni.Location = new Point(359, 168);
            lbZaposleni.Name = "lbZaposleni";
            lbZaposleni.Size = new Size(150, 164);
            lbZaposleni.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(359, 25);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 18;
            label4.Text = "Lokacija Klinike";
            // 
            // tbLokacija
            // 
            tbLokacija.Location = new Point(359, 48);
            tbLokacija.Name = "tbLokacija";
            tbLokacija.Size = new Size(232, 27);
            tbLokacija.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(359, 82);
            label7.Name = "label7";
            label7.Size = new Size(146, 20);
            label7.TabIndex = 20;
            label7.Text = "Radno Vreme Klinike";
            // 
            // tbRadnoVreme
            // 
            tbRadnoVreme.Location = new Point(359, 105);
            tbRadnoVreme.Name = "tbRadnoVreme";
            tbRadnoVreme.Size = new Size(232, 27);
            tbRadnoVreme.TabIndex = 19;
            // 
            // FormaDodajKliniku
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(724, 450);
            Controls.Add(label7);
            Controls.Add(tbRadnoVreme);
            Controls.Add(label4);
            Controls.Add(tbLokacija);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(label5);
            Controls.Add(lbMoguciZaposleni);
            Controls.Add(label6);
            Controls.Add(lbZaposleni);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(lbMogucaOdeljenja);
            Controls.Add(label2);
            Controls.Add(lbOdeljenja);
            Controls.Add(label1);
            Controls.Add(tbNaziv);
            Name = "FormaDodajKliniku";
            Text = "FormaDodajKliniku";
            Load += FormaDodajKliniku_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNaziv;
        private Label label1;
        private ListBox lbOdeljenja;
        private Label label2;
        private ListBox lbMogucaOdeljenja;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label5;
        private ListBox lbMoguciZaposleni;
        private Label label6;
        private ListBox lbZaposleni;
        private Label label4;
        private TextBox tbLokacija;
        private Label label7;
        private TextBox tbRadnoVreme;
    }
}