using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopCornBooking_D_AmicoStanziano //D'Amico
{
    public enum eStatoPosto
    {
        Libero,
        Occupato,
        Prenotato
    }

    class ClsPosto
    {
        #region Attributi
        int _fila;
        int _numero;
        eStatoPosto _stato;
        #endregion

        #region Proprietà
        public int Fila { get => _fila; set => _fila = value; }
        public int Numero { get => _numero; set => _numero = value; }
        public eStatoPosto Stato { get => _stato; set => _stato = value; }
        #endregion

        #region Costruttori
        public ClsPosto()
        {
        }

        public ClsPosto(int fila, int numero, eStatoPosto stato)
        {
            _fila = fila;
            _numero = numero;
            _stato = stato;
        }
        #endregion
    }
}
