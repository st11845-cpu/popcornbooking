using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopCornBooking_D_AmicoStanziano//Stanziano
{
    public enum eRuolo
    {
        Utente,
        Admin
    }

    class ClsUtente
    {
        #region Attributi
        int _CF;
        string _nome;
        string _cognome;
        string _email;
        string _telefono;
        string _username;
        string _password;
        eRuolo _ruolo;
        List<ClsPrenotare> _prenotazioni = new List<ClsPrenotare>();
        #endregion

        #region Proprietà
        public int CF { get => _CF; set => _CF = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Cognome { get => _cognome; set => _cognome = value; }
        public string Email { get => _email; set => _email = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public eRuolo Ruolo { get => _ruolo; set => _ruolo = value; }
        public List<ClsPrenotare> Prenotazioni { get => _prenotazioni; set => _prenotazioni = value; }
        #endregion

        #region Costruttori
        public ClsUtente()
        {
        }

        public ClsUtente(int cf, string nome, string cognome, string email, string telefono, string username, string password, eRuolo ruolo)
        {
            _CF = cf;
            _nome = nome;
            _cognome = cognome;
            _email = email;
            _telefono = telefono;
            _username = username;
            _password = password;
            _ruolo = ruolo;
        }
        #endregion
    }
}
