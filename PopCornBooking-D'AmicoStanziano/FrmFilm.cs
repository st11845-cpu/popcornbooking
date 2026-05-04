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
    public partial class FrmFilm : Form
    {
        public FrmFilm()
        {
            InitializeComponent();
        }

        private void btnVediSpettacoli_Click(object sender, EventArgs e)
        {
            // Passa alla visualizzazione degli orari per il film selezionato
            FrmSpettacoli frmSpettacoli = new FrmSpettacoli();
            frmSpettacoli.ShowDialog();
        }
    }
}
