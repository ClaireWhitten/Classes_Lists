using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double[] prijzen = new Double[20];

            for (int i = 0; i < prijzen.Length; i++)
            {
                Console.WriteLine("Geef een nummer");
                prijzen[i] = Convert.ToDouble(Console.ReadLine());
            }

            foreach (var prijs in prijzen)
            {
                if (prijs >= 5.00)
                Console.WriteLine(prijs);
            }

            double total = 0;
            foreach (var prijs in prijzen)
            {
                total = total + prijs;
            }

            Console.WriteLine(total / 20);

            Console.ReadLine();
        }
    }
}
