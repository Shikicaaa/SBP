namespace Klinika.Forme
{
    partial class FormaSertifikati
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
            id = new ColumnHeader();
            naziv = new ColumnHeader();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            tbNazivSertifikata = new TextBox();
            tbNazivOblasti = new TextBox();
            label2 = new Label();
            button5 = new Button();
            button6 = new Button();
            listView3 = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            listView4 = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { id, naziv });
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(367, 254);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // id
            // 
            id.Text = "ID";
            // 
            // naziv
            // 
            naziv.Text = "Naziv Sertifikata";
            naziv.Width = 150;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView2.Location = new Point(430, 12);
            listView2.Name = "listView2";
            listView2.Size = new Size(363, 254);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Naziv Oblasti";
            columnHeader2.Width = 150;
            // 
            // button1
            // 
            button1.Location = new Point(12, 284);
            button1.Name = "button1";
            button1.Size = new Size(165, 29);
            button1.TabIndex = 2;
            button1.Text = "Obrisi Sertifikat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(430, 284);
            button2.Name = "button2";
            button2.Size = new Size(165, 29);
            button2.TabIndex = 3;
            button2.Text = "Obrisi Oblast";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(214, 284);
            button3.Name = "button3";
            button3.Size = new Size(165, 29);
            button3.TabIndex = 4;
            button3.Text = "Dodaj Sertifikat";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(628, 284);
            button4.Name = "button4";
            button4.Size = new Size(165, 29);
            button4.TabIndex = 5;
            button4.Text = "Dodaj Oblast";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 370);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 6;
            label1.Text = "Naziv Sertifikata";
            // 
            // tbNazivSertifikata
            // 
            tbNazivSertifikata.Location = new Point(12, 393);
            tbNazivSertifikata.Name = "tbNazivSertifikata";
            tbNazivSertifikata.Size = new Size(165, 27);
            tbNazivSertifikata.TabIndex = 7;
            // 
            // tbNazivOblasti
            // 
            tbNazivOblasti.Location = new Point(430, 391);
            tbNazivOblasti.Name = "tbNazivOblasti";
            tbNazivOblasti.Size = new Size(165, 27);
            tbNazivOblasti.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(430, 368);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 8;
            label2.Text = "Naziv Oblasti";
            // 
            // button5
            // 
            button5.Location = new Point(628, 391);
            button5.Name = "button5";
            button5.Size = new Size(165, 29);
            button5.TabIndex = 10;
            button5.Text = "Unesi Oblast";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(214, 392);
            button6.Name = "button6";
            button6.Size = new Size(165, 29);
            button6.TabIndex = 11;
            button6.Text = "Unesi Sertifikat";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4 });
            listView3.Enabled = false;
            listView3.Location = new Point(12, 491);
            listView3.Name = "listView3";
            listView3.Size = new Size(367, 254);
            listView3.TabIndex = 12;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "ID";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Naziv Sertifikata";
            columnHeader4.Width = 150;
            // 
            // listView4
            // 
            listView4.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6 });
            listView4.Enabled = false;
            listView4.Location = new Point(430, 491);
            listView4.Name = "listView4";
            listView4.Size = new Size(363, 254);
            listView4.TabIndex = 13;
            listView4.UseCompatibleStateImageBehavior = false;
            listView4.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "ID";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Naziv Oblasti";
            columnHeader6.Width = 150;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(430, 468);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 14;
            label3.Text = "Oblasti zaposlenog";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 468);
            label4.Name = "label4";
            label4.Size = new Size(153, 20);
            label4.TabIndex = 15;
            label4.Text = "Sertifikati zaposlenog";
            // 
            // FormaSertifikati
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(805, 757);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listView4);
            Controls.Add(listView3);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(tbNazivOblasti);
            Controls.Add(label2);
            Controls.Add(tbNazivSertifikata);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Name = "FormaSertifikati";
            Text = "FormaSpecijalizacija";
            Load += FormaSpecijalizacija_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader id;
        private ColumnHeader naziv;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private TextBox tbNazivSertifikata;
        private TextBox tbNazivOblasti;
        private Label label2;
        private Button button5;
        private Button button6;
        private ListView listView3;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView listView4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label3;
        private Label label4;
    }
}