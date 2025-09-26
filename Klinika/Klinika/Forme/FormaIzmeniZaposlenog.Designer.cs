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
            lvNadredjeneSobe = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            lvPacijenti = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            button1 = new Button();
            mogucaOdeljenja = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            button2 = new Button();
            label1 = new Label();
            tbSpecijalizacija = new TextBox();
            SuspendLayout();
            // 
            // lvNadredjeneSobe
            // 
            lvNadredjeneSobe.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lvNadredjeneSobe.Enabled = false;
            lvNadredjeneSobe.Location = new Point(12, 30);
            lvNadredjeneSobe.Name = "lvNadredjeneSobe";
            lvNadredjeneSobe.Size = new Size(212, 157);
            lvNadredjeneSobe.TabIndex = 0;
            lvNadredjeneSobe.UseCompatibleStateImageBehavior = false;
            lvNadredjeneSobe.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Odeljenje ID";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Broj Sobe";
            columnHeader2.Width = 100;
            // 
            // lvPacijenti
            // 
            lvPacijenti.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4, columnHeader5 });
            lvPacijenti.Enabled = false;
            lvPacijenti.Location = new Point(258, 30);
            lvPacijenti.Name = "lvPacijenti";
            lvPacijenti.Size = new Size(328, 157);
            lvPacijenti.TabIndex = 1;
            lvPacijenti.UseCompatibleStateImageBehavior = false;
            lvPacijenti.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "BR Kartona";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ime";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Prezime";
            columnHeader5.Width = 120;
            // 
            // button1
            // 
            button1.Location = new Point(12, 210);
            button1.Name = "button1";
            button1.Size = new Size(124, 52);
            button1.TabIndex = 2;
            button1.Text = "Nadredi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // mogucaOdeljenja
            // 
            mogucaOdeljenja.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7 });
            mogucaOdeljenja.Location = new Point(12, 281);
            mogucaOdeljenja.Name = "mogucaOdeljenja";
            mogucaOdeljenja.Size = new Size(212, 157);
            mogucaOdeljenja.TabIndex = 3;
            mogucaOdeljenja.UseCompatibleStateImageBehavior = false;
            mogucaOdeljenja.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Odeljenje ID";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Broj Sobe";
            columnHeader7.Width = 100;
            // 
            // button2
            // 
            button2.Location = new Point(258, 210);
            button2.Name = "button2";
            button2.Size = new Size(124, 52);
            button2.TabIndex = 4;
            button2.Text = "Promeni Specijalizaciju";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 281);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 5;
            label1.Text = "Specijalizacija";
            // 
            // tbSpecijalizacija
            // 
            tbSpecijalizacija.Location = new Point(258, 304);
            tbSpecijalizacija.Name = "tbSpecijalizacija";
            tbSpecijalizacija.Size = new Size(237, 27);
            tbSpecijalizacija.TabIndex = 6;
            // 
            // FormaIzmeniZaposlenog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(tbSpecijalizacija);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(mogucaOdeljenja);
            Controls.Add(button1);
            Controls.Add(lvPacijenti);
            Controls.Add(lvNadredjeneSobe);
            Name = "FormaIzmeniZaposlenog";
            Text = "FormaIzmeniZaposlenog";
            Load += FormaIzmeniZaposlenog_Load;
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
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private ListView lvNadredjeneSobe;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView lvPacijenti;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button button1;
        private ListView mogucaOdeljenja;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button button2;
        private TextBox tbSpecijalizacija;
        private ListView listaOblasti;
    }
}