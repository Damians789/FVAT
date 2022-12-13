using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVAT
{
    public class Produkt
    {
        private string _nazwa;
        public string Nazwa {
            /*get; set;*/
            get
            {
                return _nazwa;
            }
            set
            {
                if (!check2(value))
                {
                    throw new Exception("To nie jest poprawna nazwa");
                }
                _nazwa = value;
            }
        }
        private double _cena;
        public double Cena {
            get
            {
                return _cena;
            }
            set
            {
                if (value < 0 )
                {
                    throw new Exception("Cena nie moze byc ponizej zera");
                }
                _cena = value;
            }
        }
        private double _tax;
        public double Tax {
            get
            {
                return _tax;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Cena nie moze byc ponizej zera");
                }
                _tax = value;
            }
        }

        public Produkt(string N, double C, double T)
        {
            if (C < 0 || T < 0 || !check2(N))
            {
                throw new InvalidOperationException();
            }
            this.Nazwa = N;
            this.Cena = C;
            this.Tax = T;
        }
        private bool check1(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                    return false;
            }

            return true;
        }
        private bool check2(object value)
        {
            string str = value as string;
            return str != null && check1(str);
        }
    }
}
