using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopCornBooking_D_AmicoStanziano
{
    public class ClsSpettacolo //Stanziano
    {
        #region Attributi
        int _ID;
        DateTime _dataOra;
        double _prezzo;
        bool _ePieno;
        List<ClsPrenotare> _prenotazioni = new List<ClsPrenotare>();
        #endregion

        #region Proprietà
        public int ID { get => _ID; set => _ID = value; }
        public DateTime DataOra { get => _dataOra; set => _dataOra = value; }
        public double Prezzo { get => _prezzo; set => _prezzo = value; }
        public bool EPieno { get => _ePieno; set => _ePieno = value; }
        public List<ClsPrenotare> Prenotazioni { get => _prenotazioni; set => _prenotazioni = value; }
        #endregion

        #region Costruttori
        public ClsSpettacolo()
        {
        }

        public ClsSpettacolo(int ID, DateTime dataOra, double prezzo, bool ePieno)
        {
            _ID = ID;
            _dataOra = dataOra;
            _prezzo = prezzo;
            _ePieno = ePieno;
        }
        #endregion
    }
}
