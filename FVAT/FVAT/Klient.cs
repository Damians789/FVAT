using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVAT
{
    public class Klient
    {
        private string _nazwafirmy;
        public string NazwaFirmy {
            get { return _nazwafirmy; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Nazwa firmy jest wymagana");
                }
                _nazwafirmy = value;
            }
        }
        public Adres Adr { get; set; } = new Adres();
        private string _nip;
        public string NIP {
            get { return _nip; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Numer nip jest wymagany");
                }
                _nip = value;
            }
        }
        private string _iban;
        public string IBAN {
            get { return _iban; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Numer iban jest wymagany");
                }
                _iban = value;
            }
        }
        public Klient(string Nf, Adres ad, string Nip, string i)
        {
            if(Nf.Length == 0 || Nip.Length == 0 || i.Length == 0)
            {
                throw new Exception("Musisz podac wszystkie dane");
            }
            this.NazwaFirmy = Nf;
            this.Adr = ad;
            this.NIP = Nip;
            this.IBAN = i;
        }
        public Klient()
        {

        }
        public override string ToString()
        {
            return "Klient: " + this.NazwaFirmy + "\n" + this.Adr.ToString() + "NIP: " + this.NIP;
        }
    }
}
