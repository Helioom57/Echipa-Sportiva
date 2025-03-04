using System;

namespace EchipaSportiva
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crearea echipei
            Echipa echipa = new Echipa("Foresta");

            // Adăugarea jucătorilor
            echipa.AdaugaJucator(new Jucator("Ion Popescu", 25, "Atacant", 3500));
            echipa.AdaugaJucator(new Jucator("Maria Ionescu", 28, "Mijlocas", 4200));
            echipa.AdaugaJucator(new Jucator("Vasile Georgescu", 23, "Apărător", 3000));

            // Afișarea echipei
            echipa.AfiseazaEchipa();

            // Calculul salariului total al echipei
            double salariuTotal = echipa.SalariulTotalEchipei();
            Console.WriteLine($"Salariul total al echipei: {salariuTotal} RON");

            Console.ReadKey();
        }
    }
}
