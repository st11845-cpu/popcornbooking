using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopCornBooking_D_AmicoStanziano
{
    public class ClsFilm //D'Amico
    {
        #region Attributi
        int _IDFilm;
        string _titolo;
        string _genere;
        int _durata;
        string _trama;
        string _pathLocandina;
        double _votoMedio;
        List<ClsRecensire> _recensioni = new List<ClsRecensire>();
        List<ClsSpettacolo> _spettacoli = new List<ClsSpettacolo>();
        #endregion

        #region Proprietà
        public int ID { get => _IDFilm; set => _IDFilm = value; }
        public string Titolo { get => _titolo; set => _titolo = value; }
        public string Genere { get => _genere; set => _genere = value; }
        public int Durata { get => _durata; set => _durata = value; }
        public string Trama { get => _trama; set => _trama = value; }
        public string PathLocandina { get => _pathLocandina; set => _pathLocandina = value; }
        public double VotoMedio { get => _votoMedio; set => _votoMedio = value; }
        public List<ClsRecensire> Recensioni { get => _recensioni; set => _recensioni = value; }
        public List<ClsSpettacolo> Spettacoli { get => _spettacoli; set => _spettacoli = value; }
        #endregion

        #region Costruttori
        public ClsFilm()
        {
        }

        public ClsFilm(int ID, string titolo, string genere, int durata, string trama, string pathLocandina, double votoMedio)
        {
            _IDFilm = ID;
            _titolo = titolo;
            _genere = genere;
            _durata = durata;
            _trama = trama;
            _pathLocandina = pathLocandina;
            _votoMedio = votoMedio;
        }
        #endregion
    }
}
