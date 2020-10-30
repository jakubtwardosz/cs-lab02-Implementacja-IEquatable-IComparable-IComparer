using System;

namespace cs_lab02_Implementacja_IEquatable_IComparable_IComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Pracownik();
            p1.Wynagrodzenie = 100;
            p1.Nazwisko = "         Twardosz        ";
            p1.DataZatrudnienia = new DateTime (2021, 10, 01);
            Console.WriteLine(p1);
        }
    }
}
