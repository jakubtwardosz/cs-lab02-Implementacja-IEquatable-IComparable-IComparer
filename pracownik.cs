using System;

namespace cs_lab02_Implementacja_IEquatable_IComparable_IComparer
{
    public class Pracownik
    {
        private string _naz;
        public string Nazwisko 
        {
            get => _naz;
            
            set => _naz = value.Trim();
        }
        private DateTime _dat = DateTime.Today;
        public DateTime DataZatrudnienia 
        {
            get => _dat;
            set => _dat = (value > DateTime.Today)? throw new ArgumentException("Zła data!") : value;
        }      
        
        private decimal _wyn;
        public decimal Wynagrodzenie
        {
            get => _wyn;
            set => _wyn = (value < 0)? 0: value;
        }

        public override string ToString() => $"({Nazwisko}, {DataZatrudnienia:d MMM yyyy}, {Wynagrodzenie} PLN)";

        public Pracownik()
        {
            Nazwisko = "Anonim";
            DataZatrudnienia = DateTime.Today;
            Wynagrodzenie = 0;
        }

    }
}
