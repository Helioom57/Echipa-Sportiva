using System;

namespace EchipaSportiva
{
    public class Jucator
    {
        public string Nume { get; set; }
        public int Varsta { get; set; }
        public string Pozitie { get; set; }
        public double Salariu { get; set; }

        public Jucator(string nume, int varsta, string pozitie, double salariu)
        {
            Nume = nume;
            Varsta = varsta;
            Pozitie = pozitie;
            Salariu = salariu;
        }

        public override string ToString()
        {
            return $"Nume: {Nume}, Vârstă: {Varsta}, Pozitie: {Pozitie}, Salariu: {Salariu} RON";
        }
    }
}
