namespace Klinika.Forme
{
    partial class FormaOdeljenja
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
            brojSobe = new ColumnHeader();
            nadlezniLekarJMBG = new ColumnHeader();
            ime = new ColumnHeader();
            prezime = new ColumnHeader();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { id, naziv, brojSobe, nadlezniLekarJMBG, ime, prezime });
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(606, 240);
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
            naziv.Text = "Naziv Odeljenja";
            naziv.Width = 120;
            // 
            // brojSobe
            // 
            brojSobe.Text = "Broj Sobe";
            brojSobe.Width = 100;
            // 
            // nadlezniLekarJMBG
            // 
            nadlezniLekarJMBG.Text = "Nadlezni Lekar";
            nadlezniLekarJMBG.Width = 120;
            // 
            // ime
            // 
            ime.Text = "Ime";
            ime.Width = 100;
            // 
            // prezime
            // 
            prezime.Text = "Prezime";
            prezime.Width = 100;
            // 
            // FormaOdeljenja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(630, 265);
            Controls.Add(listView1);
            Name = "FormaOdeljenja";
            Text = "FormaOdeljenja";
            Load += FormaOdeljenja_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader id;
        private ColumnHeader naziv;
        private ColumnHeader brojSobe;
        private ColumnHeader nadlezniLekarJMBG;
        private ColumnHeader ime;
        private ColumnHeader prezime;
    }
}