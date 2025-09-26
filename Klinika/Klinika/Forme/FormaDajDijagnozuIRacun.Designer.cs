namespace Klinika.Forme
{
    partial class FormaDajDijagnozuIRacun
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
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            button1 = new Button();
            label1 = new Label();
            rtbDijagnoza = new RichTextBox();
            rtbOpis = new RichTextBox();
            label2 = new Label();
            rtbTerapija = new RichTextBox();
            label3 = new Label();
            rtbPreporuka = new RichTextBox();
            label4 = new Label();
            listView2 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            listView3 = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            textBox1 = new TextBox();
            label5 = new Label();
            button2 = new Button();
            button3 = new Button();
            radioButton1 = new RadioButton();
            label6 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(312, 239);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Pacijent";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Odeljenje";
            columnHeader3.Width = 120;
            // 
            // button1
            // 
            button1.Location = new Point(842, 509);
            button1.Name = "button1";
            button1.Size = new Size(118, 52);
            button1.TabIndex = 1;
            button1.Text = "Izvrsi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(343, 12);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 2;
            label1.Text = "Dijagnoza";
            // 
            // rtbDijagnoza
            // 
            rtbDijagnoza.Location = new Point(343, 35);
            rtbDijagnoza.Multiline = false;
            rtbDijagnoza.Name = "rtbDijagnoza";
            rtbDijagnoza.Size = new Size(286, 120);
            rtbDijagnoza.TabIndex = 3;
            rtbDijagnoza.Text = "";
            // 
            // rtbOpis
            // 
            rtbOpis.Location = new Point(343, 187);
            rtbOpis.Multiline = false;
            rtbOpis.Name = "rtbOpis";
            rtbOpis.Size = new Size(286, 120);
            rtbOpis.TabIndex = 5;
            rtbOpis.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 164);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 4;
            label2.Text = "Opis Tegoba";
            // 
            // rtbTerapija
            // 
            rtbTerapija.Location = new Point(674, 35);
            rtbTerapija.Multiline = false;
            rtbTerapija.Name = "rtbTerapija";
            rtbTerapija.Size = new Size(286, 120);
            rtbTerapija.TabIndex = 7;
            rtbTerapija.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(674, 12);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 6;
            label3.Text = "Terapija";
            // 
            // rtbPreporuka
            // 
            rtbPreporuka.Location = new Point(674, 187);
            rtbPreporuka.Multiline = false;
            rtbPreporuka.Name = "rtbPreporuka";
            rtbPreporuka.Size = new Size(286, 120);
            rtbPreporuka.TabIndex = 9;
            rtbPreporuka.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(674, 164);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 8;
            label4.Text = "Preporuka";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            listView2.Location = new Point(12, 322);
            listView2.Name = "listView2";
            listView2.Size = new Size(312, 239);
            listView2.TabIndex = 10;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "ID";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Usluga";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Cena";
            columnHeader6.Width = 120;
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader9 });
            listView3.Location = new Point(482, 322);
            listView3.Name = "listView3";
            listView3.Size = new Size(312, 239);
            listView3.TabIndex = 11;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "ID";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Usluga";
            columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Cena";
            columnHeader9.Width = 120;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(800, 358);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 27);
            textBox1.TabIndex = 12;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(800, 335);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 13;
            label5.Text = "Cena Usluga";
            // 
            // button2
            // 
            button2.Location = new Point(343, 322);
            button2.Name = "button2";
            button2.Size = new Size(118, 52);
            button2.TabIndex = 14;
            button2.Text = "Dodaj Uslugu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(343, 509);
            button3.Name = "button3";
            button3.Size = new Size(118, 52);
            button3.TabIndex = 15;
            button3.Text = "Izbaci Uslugu";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(800, 403);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(149, 24);
            radioButton1.TabIndex = 16;
            radioButton1.TabStop = true;
            radioButton1.Text = "Placanje Karticom";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(800, 439);
            label6.Name = "label6";
            label6.Size = new Size(131, 20);
            label6.TabIndex = 18;
            label6.Text = "Osiguranje Pokriva";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(800, 462);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 27);
            textBox2.TabIndex = 17;
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // FormaDajDijagnozuIRacun
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1017, 573);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(radioButton1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(listView3);
            Controls.Add(listView2);
            Controls.Add(rtbPreporuka);
            Controls.Add(label4);
            Controls.Add(rtbTerapija);
            Controls.Add(label3);
            Controls.Add(rtbOpis);
            Controls.Add(label2);
            Controls.Add(rtbDijagnoza);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "FormaDajDijagnozuIRacun";
            Text = "FormaDajDijagnozuIRacun";
            Load += FormaDajDijagnozuIRacun_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button button1;
        private Label label1;
        private RichTextBox rtbDijagnoza;
        private RichTextBox rtbOpis;
        private Label label2;
        private RichTextBox rtbTerapija;
        private Label label3;
        private RichTextBox rtbPreporuka;
        private Label label4;
        private ListView listView2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ListView listView3;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private TextBox textBox1;
        private Label label5;
        private Button button2;
        private Button button3;
        private RadioButton radioButton1;
        private Label label6;
        private TextBox textBox2;
    }
}