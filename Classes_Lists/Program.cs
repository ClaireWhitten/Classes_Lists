using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Een");
            dic.Add(2, "Twee");
            dic.Add(3, "Drie");
            dic.Add(4, "Vier");
            dic.Add(7, "Zeven");
            dic.Add(8, "Zeven");

            Console.WriteLine(dic[2]);

            Dictionary<string, string> woordenboek = new Dictionary<string, string>();
            woordenboek.Add("Muis", "Mouse");
            woordenboek.Add("Toetsenbord", "Keyboard");
            woordenboek.Add("Bord", "Plate");
            woordenboek.Add("Televisie", "Television");

            Console.WriteLine(woordenboek["Muis"]);
            Console.ReadLine();

            foreach (var item in woordenboek)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            List<int> mijnList = new List<int>();
            mijnList.Add(5);
            mijnList.Add(11);
            mijnList.Add(9);
            mijnList.Add(7);
            mijnList.Add(13);
            mijnList.Add(15);
            mijnList.Add(17);

            if (mijnList.Count >= 6)
            {
                mijnList.RemoveAt(6);
            }

            mijnList.Insert(3, 10);
            mijnList.AddRange(new int[] { 19, 21, 23 });

            Console.WriteLine(mijnList.Contains(15));
            Console.WriteLine(mijnList.Max());
            Console.WriteLine(mijnList.Min());


            mijnList.Sort();
            mijnList.Reverse();

            mijnList.Add(15);

            Console.WriteLine(mijnList[1]);

            Console.WriteLine($"De index van 15 is: {mijnList.IndexOf(15)}");
            Console.WriteLine($"De index van 15 is: {mijnList.IndexOf(15, 5, 3)}");

            Console.WriteLine(mijnList.Sum());


            //List<List<int>> list = new List<List<int>>();


            //geen index
            //trager
            //altijd de volledige, in volgorde (behalve break :-) )
            //item is readonly

            foreach (int item in mijnList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            List<Student> mijnStudenten = new List<Student>();
            mijnStudenten.Add(new Student() { Naam = "Ken" });
            mijnStudenten.Add(new Student() { Naam = "Tom" });
            mijnStudenten.Add(new Student() { Naam = "Gert" });

            foreach (Student item in mijnStudenten)
            {
                item.Naam = "Bart";
            }

            for (int i = 0; i < mijnList.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {mijnList[i]}");
            }




            Console.ReadLine();

            Student[] klas = new Student[20];

            klas[3] = new Student() { Naam = "Gert" };

            Console.WriteLine(klas[3]?.Naam);   //? only prints name if thing before not = null - exception not thrown
            Console.ReadLine();

            for (int i = 0; i < klas.Length; i++)
            {
                klas[i] = new Student();
            }

            

        }
    }
}
