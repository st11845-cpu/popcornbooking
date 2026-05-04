using PopCornBooking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopCornBooking_D_AmicoStanziano
{
    public partial class FrmGestioneAdmin : Form
    {
        public FrmGestioneAdmin()
        {
            InitializeComponent();
        }
        private void btnGestioneFilm_Click(object sender, EventArgs e)
        {
            // Apre la form film in modalità "modifica/aggiunta"
            FrmFilm frm = new FrmFilm();
            frm.ShowDialog();
        }

        private void btnGestioneCinema_Click(object sender, EventArgs e)
        {
            // Gestione dei Cinema e delle Sale (ClsCinema, ClsSala)
            FrmCinemas frm = new FrmCinemas();
            frm.ShowDialog();
        }

        private void btnListaUtenti_Click(object sender, EventArgs e)
        {
            // Visione delle anagrafiche (ClsUtente)
            FrmUtenti frm = new FrmUtenti();
            frm.ShowDialog();
        }
    }
}
