using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*Savarankiško darbo užduotis4. 
Yra žinomi n (5 < n < 100) Lietuvos kelių duomenys (pavadinimas, ilgis, leistinas greitis). Surašykite šiuos 
duomenis į failą. Parašykite programą, kuri įvestų duomenis iš failo į objektų masyvą ir spausdintų lentele į 
kitą failą. */
namespace Užduotis4
{
    class Kelias
    {
        private string pavadinimas; 
        private double ilgis;       
        private int greitis;        


        public Kelias(string pavadinimas, double ilgis, int greitis)
        {
            this.pavadinimas = pavadinimas;
            this.ilgis = ilgis;
            this.greitis = greitis;
        }
        public string ImtiPavadinimą() { return pavadinimas; }

        public double ImtiIlgį() { return ilgis; }


        public int ImtiGreitį() { return greitis; }
    }

    class Program
    {
        const int Cn = 100;    
        const string CFd = "Keliai.txt";   
        const string CFrez = "Rezultatai.txt";  

        static void Main(string[] args)
        {
            Kelias[] keliai = new Kelias[Cn];
            int n = File.ReadAllLines(CFd).Length;


            Skaityti(CFd, keliai, out n);


            Spausdinti(CFrez, keliai, n);

            Console.WriteLine("Programa baigė darbą!");
        }


        static void Skaityti(string failas, Kelias[] keliai, out int n)
        {
            using (StreamReader reader = new StreamReader(failas))
            {
                string line;

                n = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = reader.ReadLine().Split(';');
                    string pavadinimas = parts[0];
                    double ilgis = double.Parse(parts[1]);
                    int greitis = int.Parse(parts[2]);
                    keliai[n++] = new Kelias(pavadinimas, ilgis, greitis);
                    
                }
            }
        }

        static void Spausdinti(string failas2, Kelias[] keliai, int n)
        {
            
                const string virsus =
                 "| Pavadinimas                           | Ilgis (km) | Greitis (km/h) |\r\n"
                +"|---------------------------------------|------------|----------------|\r";
                using (var failas = new StreamWriter(failas2, false))
                {
                    failas.WriteLine(virsus);
                    Kelias tarp;

                    for (int i = 0; i < n; i++)
                    {
                        tarp = keliai[i];
                        failas.WriteLine("| {0,-30}        | {1,10:F2} | {2,14} |",
                            keliai[i].ImtiPavadinimą(),
                            keliai[i].ImtiIlgį(),
                            keliai[i].ImtiGreitį());
                    }
                    failas.WriteLine("|---------------------------------------------------------------------|");
                }
            
        }
    }
}