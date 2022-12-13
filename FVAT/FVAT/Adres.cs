using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVAT
{
    public class Adres
    {
        public string Ulica { get; set; }
        /*        private string nr;
                public string NumerDomu
                {
                    get { return nr; }
                    set
                    {
                        if (Double.Parse(value) < 1.0f)
                        {
                            throw new ArgumentException("Numer domu nie moze byc mniejszy od zera");
                        }
                        value.ToString();
                        nr = value;
                        nr.ToString();
                    }
                }*/
        public string NumerDomu { get; set; }
        public string Zip { get; set; }
        public string Miasto { get; set; }
        public string Wojewodztwo { get; set; }

        public Adres(string U, string NrD, string Z, string M, string W)
        {
            this.Ulica = U;
            /*if (Int16.Parse(NrD) < 0)
            {
                throw new ArgumentException("Numer domu nie moze byc mniejszy od zera");
            }*/
            this.NumerDomu = NrD;
            this.Zip = Z;
            this.Miasto = M;
            this.Wojewodztwo = W;
        }

        public Adres()
        {

        }
        public override string ToString()
        {
            return "Adres: " + this.Ulica + " " + this.NumerDomu + " " + this.Zip + " " + this.Miasto + " " + this.Wojewodztwo + "\n";
        }
    }
}
