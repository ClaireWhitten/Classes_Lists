using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studenten = new List<Student>();

           
            for (int i = 0; i < 5; i++)
            {
                studenten.Add(new Student());
            }

            while (true)
            {
                Console.WriteLine("Kies een optie: \n 1.Gegevens Invoeren \n 2.Gegevens Tonen \n 3.Zoek Studenten");
                string keuze = Console.ReadLine();

                switch (keuze)
                {
                    case "1": Invullen(studenten); break;
                    case "2": StudentenTonen(studenten); break;
                    case "3": ZoekStudenten(studenten); break;
                    case "4": Verwijderen(studenten); break;
                }
            }
            
        }


        static void Invullen(List<Student> studenten)
        {
            Console.WriteLine($"Welke student moet ingevuld worden? Kies 1-{studenten.Count}");
            int studentIndex = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine("Wil je enige gegevens die al bestaan overschrijven?(Y/N)");
            string answer  = Console.ReadLine().ToUpper();
            if (answer == "Y")
            {
                Console.Write("Naam: ");
                studenten[studentIndex].Naam = Console.ReadLine();
                Console.Write("Leeftijd: ");
                studenten[studentIndex].Leeftijd = Convert.ToInt32(Console.ReadLine());
                Console.Write("Klas: ");
                studenten[studentIndex].Klas = (Klassen)Enum.Parse(typeof(Klassen), Console.ReadLine());
                Console.Write("PuntenCommunicatie: ");
                studenten[studentIndex].PuntenCommunicatie = Convert.ToInt32(Console.ReadLine());
                Console.Write("PuntenProgrammingPrinciples ");
                studenten[studentIndex].PuntenProgrammingPrinciples = Convert.ToInt32(Console.ReadLine());
                Console.Write("PuntenWebTech: ");
                studenten[studentIndex].PuntenWebTech = Convert.ToInt32(Console.ReadLine());
            }
            //print to check if set 
            Console.WriteLine(studenten[studentIndex].Naam);
            Console.WriteLine(studenten[studentIndex].Leeftijd);
            Console.WriteLine(studenten[studentIndex].Klas);
            Console.WriteLine(studenten[studentIndex].PuntenWebTech);
            Console.WriteLine(studenten[studentIndex].PuntenCommunicatie);
        }

        static void StudentenTonen(List<Student> studenten)
        {
            foreach (var student in studenten)
            {
                if (!isStudentEmpty(student))
                {
                    Console.WriteLine(student.GeefOverzicht());
                }
            }
        }
            
        static void ZoekStudenten(List<Student> studenten)
        {
            Console.WriteLine("Kies een optie: \n 1.Zoek punten \n 2.Zoek naam");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("1.Vind studenten met gemiddelde punten > 50");
                Console.WriteLine("2.Vind studenten met gemiddelde punten < 50");
                string answer = Console.ReadLine();
                if (answer == "1")
                {
                    Console.WriteLine("Deze studenten hebben punten > 50");
                    foreach (var student in studenten)
                    {
                        if (student.BerekenTotalCijfer() > 50)
                        {
                            Console.WriteLine(student.GeefOverzicht());
                        }
                    }
                }
                else if (answer == "2")
                {
                    Console.WriteLine("Deze studenten hebben punten < 50");
                    foreach (var student in studenten)
                    {
                        if (student.BerekenTotalCijfer() < 50)
                        {
                            if (!isStudentEmpty(student))
                            {
                                Console.WriteLine(student.GeefOverzicht());
                            }     
                        }
                    }
                }
            }
            else if (input == "2")
            {
                Console.Write("Naam:");
                string naam = Console.ReadLine();
                foreach (var student in studenten)
                {
                    if (student.Naam == naam)
                    {
                        Console.WriteLine(student.GeefOverzicht());
                    }
                }
            }
           
        }

        static void Verwijderen(List<Student> studenten)
        {
            Console.WriteLine("Geef de naam van de student dat je will verwijderen");
            string naam = Console.ReadLine();
            for (int i = 0; i < studenten.Count; i++)
            {
                if (studenten[i].Naam == naam)
                {
                    studenten.RemoveAt(i);
                }
            }
     
        }

        static bool isStudentEmpty(Student student)
        {
            if (student.Naam == "" && student.Leeftijd == 0 && student.PuntenCommunicatie == 0 && student.PuntenCommunicatie == 0 && student.PuntenWebTech ==0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        //lege studenten niet getoond  - how to check if a student is empty ??? check if all details are == 0??
    }
}
