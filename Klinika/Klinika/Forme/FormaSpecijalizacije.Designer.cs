namespace Klinika.Forme
{
    partial class FormaSpecijalizacije
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
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { id, naziv });
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(461, 221);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // id
            // 
            id.Text = "ID Sertifikata";
            id.Width = 120;
            // 
            // naziv
            // 
            naziv.Text = "Naziv";
            naziv.Width = 200;
            // 
            // FormaSertifikati
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(489, 450);
            Controls.Add(listView1);
            Name = "FormaSertifikati";
            Text = "FormaSertifikati";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader id;
        private ColumnHeader naziv;
    }
}