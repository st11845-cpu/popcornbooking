using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopCornBooking_D_AmicoStanziano
{
    class ClsCinema //D'Amico
    {
        #region Attributi
        string _ID;
        string _nome;
        string _indirizzo;
        List<ClsSala> _sale = new List<ClsSala>();
        List<ClsFilm> _film = new List<ClsFilm>();
        #endregion

        #region Proprietà
        public string ID { get => _ID; set => _ID = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Indirizzo { get => _indirizzo; set => _indirizzo = value; }
        public List<ClsSala> Sale { get => _sale; set => _sale = value; }
        public List<ClsFilm> Film { get => _film; set => _film = value; }
        #endregion

        #region Costruttori
        public ClsCinema()
        {
        }

        public ClsCinema(string ID, string nome, string indirizzo)
        {
            _ID = ID;
            _nome = nome;
            _indirizzo = indirizzo;
        }
        #endregion
    }
}
