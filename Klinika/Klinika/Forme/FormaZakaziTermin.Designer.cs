namespace Klinika.Forme
{
    partial class FormaZakaziTermin
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
            dateTimePicker1 = new DateTimePicker();
            lvLekari = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            lvOdeljenja = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 0;
            label1.Text = "Datum Zakazivanja";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 50);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // lvLekari
            // 
            lvLekari.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader1 });
            lvLekari.Location = new Point(321, 27);
            lvLekari.Name = "lvLekari";
            lvLekari.Size = new Size(218, 192);
            lvLekari.TabIndex = 3;
            lvLekari.UseCompatibleStateImageBehavior = false;
            lvLekari.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.DisplayIndex = 1;
            columnHeader2.Text = "ID";
            // 
            // columnHeader1
            // 
            columnHeader1.DisplayIndex = 0;
            columnHeader1.Text = "Lekar";
            columnHeader1.Width = 180;
            // 
            // lvOdeljenja
            // 
            lvOdeljenja.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4 });
            lvOdeljenja.Location = new Point(570, 27);
            lvOdeljenja.Name = "lvOdeljenja";
            lvOdeljenja.Size = new Size(218, 192);
            lvOdeljenja.TabIndex = 4;
            lvOdeljenja.UseCompatibleStateImageBehavior = false;
            lvOdeljenja.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.DisplayIndex = 1;
            columnHeader3.Text = "ID";
            // 
            // columnHeader4
            // 
            columnHeader4.DisplayIndex = 0;
            columnHeader4.Text = "Odeljenje";
            columnHeader4.Width = 180;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 160);
            button1.Name = "button1";
            button1.Size = new Size(250, 59);
            button1.TabIndex = 5;
            button1.Text = "Zakazi Termin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormaZakaziTermin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lvOdeljenja);
            Controls.Add(lvLekari);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Name = "FormaZakaziTermin";
            Text = "FormaZakaziTermin";
            Load += FormaZakaziTermin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private ListView lvLekari;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader1;
        private ListView lvOdeljenja;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button button1;
    }
}