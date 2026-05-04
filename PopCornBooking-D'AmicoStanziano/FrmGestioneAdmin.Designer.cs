namespace PopCornBooking_D_AmicoStanziano
{
    partial class FrmGestioneAdmin
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnListaUtenti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 153);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gestione cinema";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnGestioneCinema_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 153);
            this.button2.TabIndex = 1;
            this.button2.Text = "gestione film";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnGestioneFilm_Click);
            // 
            // btnListaUtenti
            // 
            this.btnListaUtenti.Location = new System.Drawing.Point(517, 129);
            this.btnListaUtenti.Name = "btnListaUtenti";
            this.btnListaUtenti.Size = new System.Drawing.Size(75, 153);
            this.btnListaUtenti.TabIndex = 2;
            this.btnListaUtenti.Text = "Gestione utenti";
            this.btnListaUtenti.UseVisualStyleBackColor = true;
            this.btnListaUtenti.Click += new System.EventHandler(this.btnListaUtenti_Click);
            // 
            // FrmGestioneAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListaUtenti);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FrmGestioneAdmin";
            this.Text = "v";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnListaUtenti;
    }
}