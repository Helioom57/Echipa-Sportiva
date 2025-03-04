using System;
using System.Collections.Generic;

namespace EchipaSportiva
{
    public class Echipa
    {
        public string NumeEchipa { get; set; }
        public List<Jucator> Jucatori { get; set; }

        public Echipa(string numeEchipa)
        {
            NumeEchipa = numeEchipa;
            Jucatori = new List<Jucator>();
        }

        public void AdaugaJucator(Jucator jucator)
        {
            Jucatori.Add(jucator);
        }

        public void AfiseazaEchipa()
        {
            Console.WriteLine($"Echipa {NumeEchipa}:");
            foreach (var jucator in Jucatori)
            {
                Console.WriteLine(jucator);
            }
        }

        public double SalariulTotalEchipei()
        {
            double salariuTotal = 0;
            foreach (var jucator in Jucatori)
            {
                salariuTotal += jucator.Salariu;
            }
            return salariuTotal;
        }
    }
}
