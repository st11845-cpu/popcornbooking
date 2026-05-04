using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopCornBooking_D_AmicoStanziano
{
    class ClsSala //Stanziano
    {
        #region Attributi
        int _ID;
        string _nome;
        int _numeroFile;
        int _postiPerFila;
        List<ClsPosto> _posti = new List<ClsPosto>();
        #endregion

        #region Proprietà
        public int ID { get => _ID; set => _ID = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public int NumeroFile { get => _numeroFile; set => _numeroFile = value; }
        public int PostiPerFila { get => _postiPerFila; set => _postiPerFila = value; }
        public List<ClsPosto> Posti { get => _posti; set => _posti = value; }
        #endregion

        #region Costruttori
        public ClsSala()
        {
        }

        public ClsSala(int ID, string nome, int numeroFile, int postiPerFila)
        {
            _ID = ID;
            _nome = nome;
            _numeroFile = numeroFile;
            _postiPerFila = postiPerFila;
        }
        #endregion
    }
}
