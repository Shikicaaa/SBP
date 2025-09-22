namespace Klinika.Forme
{
    partial class FormaIzmeniZaposlenog
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
            tbIme = new TextBox();
            tbPrezime = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panelLekar = new Panel();
            listaOdeljenja = new ListView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            panelLaborant = new Panel();
            listaSertifikata = new ListView();
            listaOblasti = new ListView();
            panelLekar.SuspendLayout();
            panelLaborant.SuspendLayout();
            SuspendLayout();
            // 
            // tbJMBG
            // 
            tbJMBG.Enabled = false;
            tbJMBG.Location = new Point(81, 27);
            tbJMBG.Name = "tbJMBG";
            tbJMBG.Size = new Size(239, 27);
            tbJMBG.TabIndex = 0;
            // 
            // tbIme
            // 
            tbIme.Enabled = false;
            tbIme.Location = new Point(81, 60);
            tbIme.Name = "tbIme";
            tbIme.Size = new Size(239, 27);
            tbIme.TabIndex = 1;
            // 
            // tbPrezime
            // 
            tbPrezime.Enabled = false;
            tbPrezime.Location = new Point(81, 93);
            tbPrezime.Name = "tbPrezime";
            tbPrezime.Size = new Size(239, 27);
            tbPrezime.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 3;
            label1.Text = "JMBG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 4;
            label2.Text = "Ime";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 5;
            label3.Text = "Prezime";
            // 
            // panelLekar
            // 
            panelLekar.Controls.Add(panelLaborant);
            panelLekar.Controls.Add(listaOdeljenja);
            panelLekar.Location = new Point(359, 12);
            panelLekar.Name = "panelLekar";
            panelLekar.Size = new Size(429, 412);
            panelLekar.TabIndex = 6;
            // 
            // listaOdeljenja
            // 
            listaOdeljenja.Location = new Point(20, 18);
            listaOdeljenja.Name = "listaOdeljenja";
            listaOdeljenja.Size = new Size(394, 156);
            listaOdeljenja.TabIndex = 0;
            listaOdeljenja.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(81, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(239, 27);
            textBox2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 129);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 9;
            label4.Text = "Adresa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 162);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 10;
            label5.Text = "Kontakt";
            // 
            // panelLaborant
            // 
            panelLaborant.Controls.Add(listaOblasti);
            panelLaborant.Controls.Add(listaSertifikata);
            panelLaborant.Location = new Point(0, 3);
            panelLaborant.Name = "panelLaborant";
            panelLaborant.Size = new Size(429, 412);
            panelLaborant.TabIndex = 7;
            // 
            // listaSertifikata
            // 
            listaSertifikata.Location = new Point(20, 18);
            listaSertifikata.Name = "listaSertifikata";
            listaSertifikata.Size = new Size(394, 156);
            listaSertifikata.TabIndex = 0;
            listaSertifikata.UseCompatibleStateImageBehavior = false;
            // 
            // listaOblasti
            // 
            listaOblasti.Location = new Point(20, 196);
            listaOblasti.Name = "listaOblasti";
            listaOblasti.Size = new Size(394, 156);
            listaOblasti.TabIndex = 1;
            listaOblasti.UseCompatibleStateImageBehavior = false;
            // 
            // FormaIzmeniZaposlenog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panelLekar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPrezime);
            Controls.Add(tbIme);
            Controls.Add(tbJMBG);
            Name = "FormaIzmeniZaposlenog";
            Text = "FormaIzmeniZaposlenog";
            Load += FormaIzmeniZaposlenog_Load;
            panelLekar.ResumeLayout(false);
            panelLaborant.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbJMBG;
        private TextBox tbIme;
        private TextBox tbPrezime;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panelLekar;
        private ListView listaOdeljenja;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Panel panelLaborant;
        private ListView listaSertifikata;
        private ListView listaOblasti;
    }
}