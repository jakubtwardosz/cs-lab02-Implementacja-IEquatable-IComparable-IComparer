using System;

namespace cs_lab02_Implementacja_IEquatable_IComparable_IComparer
{
    public class Pracownik : IEquatable<Pracownik>
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

        public Pracownik()
        {
            Nazwisko = "Anonim";
            DataZatrudnienia = DateTime.Today;
            Wynagrodzenie = 0;
        }
        public int CzasZatrudnienia => (DateTime.Now - DataZatrudnienia).Days / 30;
        
        public override string ToString() => $"({Nazwisko}, {DataZatrudnienia:d MMM yyyy} ({CzasZatrudnienia} msc), {Wynagrodzenie} PLN)";
        
        public bool Equals(Pracownik other)
        {
            if (other is null) return false;

            if (Object.ReferenceEquals(this, other))
                return true;

            return (Nazwisko == other.Nazwisko && DataZatrudnienia == other.DataZatrudnienia && Wynagrodzenie == other.Wynagrodzenie);
        }

        public override bool Equals(object obj)
        {
            if (obj is Pracownik)
            {
                return Equals((Pracownik)obj);    
            }else{
                return false;
            }            
        }

        public override int GetHashCode() => (Nazwisko, DataZatrudnienia, Wynagrodzenie).GetHashCode();

        public static bool Equals(Pracownik p1, Pracownik p2)
        {
            if ((p1 is null) && (p2 is null)) return true;

            if ((p1 is null)) return false;

            return p1.Equals(p2);
        }

        public static bool operator ==(Pracownik p1, Pracownik p2) => Equals(p1, p2);
        public static bool operator !=(Pracownik p1, Pracownik p2) => !(p1 == p2);

    }

}
