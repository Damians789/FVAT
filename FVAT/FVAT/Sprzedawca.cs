namespace FVAT
{
    public static class Sprzedawca
    {
        public static string NazwaFirmy { get; set; } = "Marynowany śledź";
        public static Adres Adr { get; set; } = new Adres();
        public static string NIP { get; set; } = "0600887425";
        public static string IBAN { get; set; } = "PL17110819766428936444984225";
        static Sprzedawca()
        {
            Adr.Ulica = "Banasik";
            Adr.NumerDomu = "7392/418";
            Adr.Zip = "14-522";
            Adr.Miasto = "Resko";
            Adr.Wojewodztwo = "Pomorskie";
        }
    }
}