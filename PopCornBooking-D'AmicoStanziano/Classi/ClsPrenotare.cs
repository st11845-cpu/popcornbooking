using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopCornBooking_D_AmicoStanziano //D'Amico
{
    public class ClsPrenotare
    {
        #region Attributi
        int _IDPrenotazione;
        DateTime _dataPrenotazione;
        double _prezzo;
        int _numeroPosti;
        int _CFUtente;
        int _IDSpettacolo;
        #endregion

        #region Proprietà
        public int IDPrenotazione { get => _IDPrenotazione; set => _IDPrenotazione = value; }
        public DateTime DataPrenotazione { get => _dataPrenotazione; set => _dataPrenotazione = value; }
        public double Prezzo { get => _prezzo; set => _prezzo = value; }
        public int NumeroPosti { get => _numeroPosti; set => _numeroPosti = value; }
        public int CFUtente { get => _CFUtente; set => _CFUtente = value; }
        public int IDSpettacolo { get => _IDSpettacolo; set => _IDSpettacolo = value; }
        #endregion

        #region Costruttori
        public ClsPrenotare()
        {
        }

        public ClsPrenotare(int id, DateTime dataPrenotazione, double prezzo, int numeroPosti, int cfUtente, int idSpettacolo)
        {
            _IDPrenotazione = id;
            _dataPrenotazione = dataPrenotazione;
            _prezzo = prezzo;
            _numeroPosti = numeroPosti;
            _CFUtente = cfUtente;
            _IDSpettacolo = idSpettacolo;
        }
        #endregion
    }
}
