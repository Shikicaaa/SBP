namespace Klinika.Forme
{
    partial class FormaUsluge
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
            button1 = new Button();
            label1 = new Label();
            tbNaziv = new TextBox();
            tbCena = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 142);
            button1.Name = "button1";
            button1.Size = new Size(271, 54);
            button1.TabIndex = 0;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "Naziv";
            // 
            // tbNaziv
            // 
            tbNaziv.Location = new Point(14, 41);
            tbNaziv.Name = "tbNaziv";
            tbNaziv.Size = new Size(269, 27);
            tbNaziv.TabIndex = 2;
            // 
            // tbCena
            // 
            tbCena.Location = new Point(14, 97);
            tbCena.Name = "tbCena";
            tbCena.Size = new Size(269, 27);
            tbCena.TabIndex = 4;
            tbCena.KeyDown += tbCena_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 3;
            label2.Text = "Cena";
            // 
            // FormaUsluge
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(295, 208);
            Controls.Add(tbCena);
            Controls.Add(label2);
            Controls.Add(tbNaziv);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "FormaUsluge";
            Text = "FormaUsluge";
            Load += FormaUsluge_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox tbNaziv;
        private TextBox tbCena;
        private Label label2;
    }
}