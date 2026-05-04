namespace PopCornBooking_D_AmicoStanziano
{
    partial class FrmPosti
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
            this.lvPosti = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvPosti
            // 
            this.lvPosti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvPosti.HideSelection = false;
            this.lvPosti.Location = new System.Drawing.Point(12, 12);
            this.lvPosti.Name = "lvPosti";
            this.lvPosti.Size = new System.Drawing.Size(241, 337);
            this.lvPosti.TabIndex = 0;
            this.lvPosti.UseCompatibleStateImageBehavior = false;
            this.lvPosti.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fila";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Numero posto";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Stato posto";
            this.columnHeader3.Width = 85;
            // 
            // FrmPosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 374);
            this.Controls.Add(this.lvPosti);
            this.Name = "FrmPosti";
            this.Text = "FrmPosti";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvPosti;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}