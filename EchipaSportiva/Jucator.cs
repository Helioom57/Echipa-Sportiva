using System;

namespace EchipaSportiva
{
    public class Jucator
    {
        public string Nume { get; set; }
        public DateTime DataNasterii { get; set; }
        public string Pozitie { get; set; }
        public double Salariu { get; set; }

        public Jucator(string nume, DateTime dataNasterii, string pozitie, double salariu)
        {
            Nume = nume;
            DataNasterii = dataNasterii;
            Pozitie = pozitie;
            Salariu = salariu;
        }

        public override string ToString()
        {
            return $"Nume: {Nume}, Data nasterii: {DataNasterii:dd.MM.yyyy}, Pozitie: {Pozitie}, Salariu: {Salariu} RON";
        }
    }
}
