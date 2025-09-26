namespace Klinika
{
    partial class FormaZaposleni
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
            idKolona = new ColumnHeader();
            imeRadnika = new ColumnHeader();
            prezimeRadnika = new ColumnHeader();
            tipZaposlenog = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { idKolona, imeRadnika, prezimeRadnika, tipZaposlenog });
            listView1.Location = new Point(12, 13);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(458, 341);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // idKolona
            // 
            idKolona.Text = "JMBG";
            idKolona.Width = 150;
            // 
            // imeRadnika
            // 
            imeRadnika.Text = "ImeRadnika";
            imeRadnika.Width = 100;
            // 
            // prezimeRadnika
            // 
            prezimeRadnika.Text = "PrezimeRadnika";
            prezimeRadnika.Width = 100;
            // 
            // tipZaposlenog
            // 
            tipZaposlenog.Text = "TipZaposlenog";
            tipZaposlenog.Width = 100;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 361);
            button1.Name = "button1";
            button1.Size = new Size(150, 80);
            button1.TabIndex = 3;
            button1.Text = "DODAJ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(320, 361);
            button2.Name = "button2";
            button2.Size = new Size(150, 80);
            button2.TabIndex = 4;
            button2.Text = "OBRISI";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(167, 361);
            button3.Name = "button3";
            button3.Size = new Size(150, 80);
            button3.TabIndex = 5;
            button3.Text = "IZMENI";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(167, 447);
            button4.Name = "button4";
            button4.Size = new Size(150, 80);
            button4.TabIndex = 6;
            button4.Text = "IZVRSI";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // FormaZaposleni
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(490, 529);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "FormaZaposleni";
            Text = "FormaZaposleni";
            Load += FormaZaposleni_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader idKolona;
        private ColumnHeader imeRadnika;
        private ColumnHeader prezimeRadnika;
        private ColumnHeader tipZaposlenog;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}