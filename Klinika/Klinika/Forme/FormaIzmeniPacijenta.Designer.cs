namespace Klinika.Forme
{
    partial class FormaIzmeniPacijenta
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
            label1 = new Label();
            tbAdresa = new TextBox();
            tbKontakt = new TextBox();
            label2 = new Label();
            tbEmail = new TextBox();
            label3 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Adresa";
            // 
            // tbAdresa
            // 
            tbAdresa.Location = new Point(12, 48);
            tbAdresa.Name = "tbAdresa";
            tbAdresa.Size = new Size(186, 27);
            tbAdresa.TabIndex = 1;
            // 
            // tbKontakt
            // 
            tbKontakt.Location = new Point(12, 111);
            tbKontakt.Name = "tbKontakt";
            tbKontakt.Size = new Size(186, 27);
            tbKontakt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 2;
            label2.Text = "Kontakt";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(12, 175);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(186, 27);
            tbEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 152);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(252, 25);
            listView1.Name = "listView1";
            listView1.Size = new Size(388, 177);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Lekar";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Specijalizacija";
            columnHeader3.Width = 150;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 224);
            button1.Name = "button1";
            button1.Size = new Size(186, 58);
            button1.TabIndex = 7;
            button1.Text = "Izmeni";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormaIzmeniPacijenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(681, 295);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(tbEmail);
            Controls.Add(label3);
            Controls.Add(tbKontakt);
            Controls.Add(label2);
            Controls.Add(tbAdresa);
            Controls.Add(label1);
            Name = "FormaIzmeniPacijenta";
            Text = "FormaIzmeniPacijenta";
            Load += FormaIzmeniPacijenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbAdresa;
        private TextBox tbKontakt;
        private Label label2;
        private TextBox tbEmail;
        private Label label3;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button button1;
    }
}