namespace Klinika.Forme
{
    partial class FormaSveUsluge
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
            nazivUsluge = new ColumnHeader();
            cenaUsluge = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { id, nazivUsluge, cenaUsluge });
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(627, 274);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // id
            // 
            id.Text = "ID Usluge";
            id.Width = 200;
            // 
            // nazivUsluge
            // 
            nazivUsluge.Text = "Naziv Usluge";
            nazivUsluge.Width = 120;
            // 
            // cenaUsluge
            // 
            cenaUsluge.Text = "Cena Usluge";
            cenaUsluge.Width = 120;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(480, 292);
            button1.Name = "button1";
            button1.Size = new Size(159, 96);
            button1.TabIndex = 1;
            button1.Text = "OBRISI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 292);
            button2.Name = "button2";
            button2.Size = new Size(159, 96);
            button2.TabIndex = 2;
            button2.Text = "DODAJ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(248, 292);
            button3.Name = "button3";
            button3.Size = new Size(159, 96);
            button3.TabIndex = 3;
            button3.Text = "IZMENI";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FormaSveUsluge
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(655, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "FormaSveUsluge";
            Text = "FormaSveUsluge";
            Load += FormaSveUsluge_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ColumnHeader id;
        private ColumnHeader nazivUsluge;
        private ColumnHeader cenaUsluge;
    }
}