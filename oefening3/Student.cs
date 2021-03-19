using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening3
{
    enum Klassen { EA1, EA2, EA3 };
    class Student
    {
        public string Naam { get; set; } = "";

        public int Leeftijd { get; set; } = 0;

            public Klassen Klas { get; set; } //the type is the name of the enum (data type)

        public int PuntenCommunicatie { get; set; } = 0;

        public int PuntenProgrammingPrinciples { get; set; } = 0;

        public int PuntenWebTech { get; set; } = 0;


            public double BerekenTotalCijfer()
            {
                double gemiddelde = Convert.ToDouble((PuntenCommunicatie + PuntenProgrammingPrinciples + PuntenWebTech)) / 3;
                return Math.Round(gemiddelde, 1); //or toString("0.00")
            }

            public string GeefOverzicht()
            {
                return $"Rapport: \n Naam {Naam} \n Leeftijd {Leeftijd} \n Klas: {Klas} \n Gemiddelde Punten: {BerekenTotalCijfer()}";

            }
        
    }
}
