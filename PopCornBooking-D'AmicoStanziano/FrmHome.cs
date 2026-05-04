using PopCornBooking_D_AmicoStanziano;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopCornBooking
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSignup _frmSignup = new FrmSignup();
            _frmSignup.ShowDialog();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            lbForgotPassword.Parent = pictureBox1;
            pictureBox1.Controls.Add(lbForgotPassword); // Assicura che la label sia un controllo figlio della picturebox
            lbForgotPassword.BackColor = System.Drawing.Color.Transparent;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Logica di esempio per distinguere i ruoli
            if (tbUsername.Text.ToLower() == "admin" && tbPassword.Text == "admin123")
            {
                // Navigazione per l'Amministratore
                FrmGestioneAdmin frmAdmin = new FrmGestioneAdmin();
                this.Hide(); // Nasconde la home
                frmAdmin.ShowDialog();
                this.Show(); // Ritorna alla home alla chiusura
            }
            else
            {
                // Navigazione per l'Utente Standard
                FrmFilm frmCatalogo = new FrmFilm();
                this.Hide();
                frmCatalogo.ShowDialog();
                this.Show();
            }
        }
    }
}
