namespace PopCornBooking_D_AmicoStanziano
{
    partial class FrmPosto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStatoPosto = new System.Windows.Forms.ComboBox();
            this.nudNposto = new System.Windows.Forms.NumericUpDown();
            this.nudFila = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNposto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFila)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scegli la fila";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Scegli il numero del posto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stato posto";
            // 
            // cbStatoPosto
            // 
            this.cbStatoPosto.FormattingEnabled = true;
            this.cbStatoPosto.Location = new System.Drawing.Point(159, 133);
            this.cbStatoPosto.Name = "cbStatoPosto";
            this.cbStatoPosto.Size = new System.Drawing.Size(121, 21);
            this.cbStatoPosto.TabIndex = 3;
            // 
            // nudNposto
            // 
            this.nudNposto.Location = new System.Drawing.Point(159, 81);
            this.nudNposto.Name = "nudNposto";
            this.nudNposto.Size = new System.Drawing.Size(120, 20);
            this.nudNposto.TabIndex = 4;
            // 
            // nudFila
            // 
            this.nudFila.Location = new System.Drawing.Point(159, 32);
            this.nudFila.Name = "nudFila";
            this.nudFila.Size = new System.Drawing.Size(120, 20);
            this.nudFila.TabIndex = 5;
            // 
            // FrmPosto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 205);
            this.Controls.Add(this.nudFila);
            this.Controls.Add(this.nudNposto);
            this.Controls.Add(this.cbStatoPosto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPosto";
            this.Text = "FrmPosto";
            ((System.ComponentModel.ISupportInitialize)(this.nudNposto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStatoPosto;
        private System.Windows.Forms.NumericUpDown nudNposto;
        private System.Windows.Forms.NumericUpDown nudFila;
    }
}