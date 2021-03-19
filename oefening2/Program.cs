using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening2
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Speelkaart> speelkaarten = new List<Speelkaart>();
           

            //Loop 1
            //add number property
            int teller = 1;

            for (int i = 0; i < 52; i++)
            {
                speelkaarten.Add(new Speelkaart());
                if (i == 13 || i==26 || i== 39)
                {
                    teller = 1;
                    speelkaarten[i].Getal = teller;
                }
                else
                {
                    speelkaarten[i].Getal = teller;
          
                }
                teller = teller + 1;
            }

            //Loop 2
            //add colour/suite
            for (int i = 0; i < speelkaarten.Count; i++)
            {
                if (i >= 0 && i <= 12)
                {
                    speelkaarten[i].Kleur = Kleur.Haarten;
                }
                else if (i >= 13 && i <= 25)
                {
                    speelkaarten[i].Kleur = Kleur.Klaveren;
                }
                else if (i >= 26 && i <= 38)
                {
                    speelkaarten[i].Kleur = Kleur.Ruiten;
                }
                else
                {
                    speelkaarten[i].Kleur = Kleur.Schoppen;
                }
            }


                //check numbers  and colours assigned correctly 
                foreach (var kaart in speelkaarten)
            {
                Console.WriteLine($"{kaart.Getal} {kaart.Kleur}");
            }





            //Method  - picks random card 
            Speelkaart randomCard = PickRandomCard(speelkaarten);
            Console.WriteLine($"{randomCard.Getal} {randomCard.Kleur}"); 
            
            Console.ReadLine();

            
        }

        static Speelkaart PickRandomCard(List<Speelkaart> speelkaarten )
        {
            Random rgn = new Random();
            int randomIndex = rgn.Next(0, speelkaarten.Count);
            Speelkaart randomCard =  speelkaarten[randomIndex];
            speelkaarten.RemoveAt(randomIndex);
            return randomCard;
        }
    }
}
