namespace PopCornBooking
{
    partial class FrmHome
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbSignUp = new System.Windows.Forms.LinkLabel();
            this.lbForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSignUp
            // 
            this.lbSignUp.AutoSize = true;
            this.lbSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignUp.Location = new System.Drawing.Point(1325, 772);
            this.lbSignUp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSignUp.Name = "lbSignUp";
            this.lbSignUp.Size = new System.Drawing.Size(171, 13);
            this.lbSignUp.TabIndex = 12;
            this.lbSignUp.TabStop = true;
            this.lbSignUp.Text = "Already have an account? Sign up";
            // 
            // lbForgotPassword
            // 
            this.lbForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForgotPassword.LinkArea = new System.Windows.Forms.LinkArea(0, 90);
            this.lbForgotPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbForgotPassword.LinkColor = System.Drawing.Color.Gray;
            this.lbForgotPassword.Location = new System.Drawing.Point(1613, 631);
            this.lbForgotPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbForgotPassword.Name = "lbForgotPassword";
            this.lbForgotPassword.Size = new System.Drawing.Size(198, 19);
            this.lbForgotPassword.TabIndex = 11;
            this.lbForgotPassword.TabStop = true;
            this.lbForgotPassword.Text = "                                                                                 " +
    "                                 ";
            this.lbForgotPassword.UseCompatibleTextRendering = true;
            this.lbForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbForgotPassword_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(1312, 689);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(6);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(469, 54);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbUsername.Location = new System.Drawing.Point(1282, 469);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(6);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(529, 32);
            this.tbUsername.TabIndex = 9;
            this.tbUsername.Text = "username";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbPassword.Location = new System.Drawing.Point(1282, 563);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(6);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(529, 32);
            this.tbPassword.TabIndex = 8;
            this.tbPassword.Text = "password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-14, 2);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 1080);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.lbSignUp);
            this.Controls.Add(this.lbForgotPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "FrmHome";
            this.Text = "Log in";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lbSignUp;
        private System.Windows.Forms.LinkLabel lbForgotPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

