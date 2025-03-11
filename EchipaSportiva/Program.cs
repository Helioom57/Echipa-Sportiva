using System;
using System.Collections.Generic;

namespace EchipaSportiva
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Echipa> echipe = new List<Echipa>();

            bool running = true;
            while (running)
            {
                Console.WriteLine("Alege o optiune:");
                Console.WriteLine("1. Adauga echipa");
                Console.WriteLine("2. Adauga jucator la o echipa");
                Console.WriteLine("3. Afiseaza echipe si jucatori");
                Console.WriteLine("4. Afiseaza salariul total al unei echipe");
                Console.WriteLine("5. Iesire");
                Console.Write("Optiunea ta: ");

                string optiune = Console.ReadLine();
                switch (optiune)
                {
                    case "1":
                        Console.Write("Nume echipa: ");
                        string numeEchipa = Console.ReadLine();
                        echipe.Add(new Echipa(numeEchipa));
                        Console.WriteLine("Echipa adaugata cu succes!");
                        break;
                    case "2":
                        Console.Write("Nume echipa: ");
                        string echipaCautata = Console.ReadLine();
                        Echipa echipa = echipe.Find(e => e.NumeEchipa == echipaCautata);
                        if (echipa != null)
                        {
                            Console.Write("Nume jucator: ");
                            string nume = Console.ReadLine();
                            Console.Write("Data nasterii (dd.MM.yyyy): ");
                            DateTime dataNasterii = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
                            Console.Write("Pozitie: ");
                            string pozitie = Console.ReadLine();
                            Console.Write("Salariu: ");
                            double salariu = double.Parse(Console.ReadLine());
                            echipa.AdaugaJucator(new Jucator(nume, dataNasterii, pozitie, salariu));
                            Console.WriteLine("Jucator adaugat cu succes!");
                        }
                        else
                        {
                            Console.WriteLine("Echipa nu a fost gasita!");
                        }
                        break;
                    case "3":
                        foreach (var team in echipe)
                        {
                            List<string> info = team.ObtineInformatiiEchipa();
                            foreach (var linie in info)
                            {
                                Console.WriteLine(linie);
                            }
                        }
                        break;
                    case "4":
                        Console.Write("Nume echipa: ");
                        string echipaSalariu = Console.ReadLine();
                        Echipa echipaSalariuCautata = echipe.Find(e => e.NumeEchipa == echipaSalariu);
                        if (echipaSalariuCautata != null)
                        {
                            Console.WriteLine($"Salariul total al echipei {echipaSalariu}: {echipaSalariuCautata.SalariulTotalEchipei()} RON");
                        }
                        else
                        {
                            Console.WriteLine("Echipa nu a fost gasita!");
                        }
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Optiune invalida!");
                        break;
                }
            }
        }
    }
}
