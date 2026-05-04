using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopCornBooking_D_AmicoStanziano
{
    public class ClsRecensire //Stanziano
    {
        #region Attributi
        int _IDRecensione;
        byte _voto;
        string _commento;
        DateTime _data;
        int _IDFilm;
        int _CFUtente;
        #endregion

        #region Proprietà
        public int IDRecensione { get => _IDRecensione; set => _IDRecensione = value; }
        public byte Voto { get => _voto; set => _voto = value; }
        public string Commento { get => _commento; set => _commento = value; }
        public DateTime Data { get => _data; set => _data = value; }
        public int IDFilm { get => _IDFilm; set => _IDFilm = value; }
        public int CFUtente { get => _CFUtente; set => _CFUtente = value; }
        #endregion

        #region Costruttori
        public ClsRecensire()
        {
        }

        public ClsRecensire(int idRecensione, byte voto, string commento, DateTime data, int idFilm, int cfUtente)
        {
            _IDRecensione = idRecensione;
            _voto = voto;
            _commento = commento;
            _data = data;
            _IDFilm = idFilm;
            _CFUtente = cfUtente;
        }
        #endregion
    }
}
