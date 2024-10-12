using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiškas1
{
    class Plyta

    {
        private int ilgis,      // plytos ilgis, milimetrais 
            aukštis;    // plytos aukštis, milimetrais 
        //---------------------------------------------------- 
        /** Plytos duomenys 
        @param ilgis - ilgio reikšmė 
        @param pločioReikšmė - pločio reikšmė 
        @param aukščioReikšmė - aukščio reikšmė  */
        //---------------------------------------------------- 
        public Plyta(int ilgis, int aukščioReikšmė)  // konstruktorius
        {
            this.ilgis = ilgis;
            aukštis = aukščioReikšmė;
        }

        /** grąžina plytos ilgį */
        public int ImtiIlgį() { return ilgis; } // grazina reiksme

        /** grąžina plytos aukštį */
        public int ImtiAukštį() { return aukštis; } //grazina reiksme
        //------------------------------------------------------------ 
        static void Main(string[] args)
        {
            int sienuskaicius = 4;

            Console.WriteLine("Įveskite pirmo tipo plytos ilgį ir aukštį (milimetrais), atskirtus tarpais:");
            string[] plyta11 = Console.ReadLine().Split(' '); // reikalingas atskirti irasus konsoleje. split paima tarpa ir skaito kas tarp tarpu parasyta, del to reikalinga string nes tarpas skaitosi kaip stringas.
            Plyta plyta1 = new Plyta(int.Parse(plyta11[0]), int.Parse(plyta11[1])); // int.parse skaito tik skaitines reiksmes kas yra ivesta auksciau esanciame string kintamajame, [0] ir [1] nustato pirmo ir antro iraso vietas.

            Console.WriteLine("Įveskite antro tipo plytos ilgį ir aukštį (milimetrais), atskirtus tarpais:");
            string[] plyta22 = Console.ReadLine().Split(' ');
            Plyta plyta2 = new Plyta(int.Parse(plyta22[0]), int.Parse(plyta22[1]));

            double[] sienosilgiai = new double[4]; // [4] = sienu skaicius
            double[] sienosaukščiai = new double[4];

            for (int i = 0; i < sienuskaicius; i++)
            {
                Console.WriteLine($"Įveskite {i + 1}-osios sienos ilgį (metrais):"); // $ reikalingas kad butu galima paimti pacio ciklo i reiksme ir kazka su ja padaryti jos tiesiogiai nepakeiciant.
                sienosilgiai[i] = double.Parse(Console.ReadLine());

                Console.WriteLine($"Įveskite {i + 1}-osios sienos aukštį (metrais):");
                sienosaukščiai[i] = double.Parse(Console.ReadLine()); // susije su zemiau esanciu for ciklu
            }

            int plytu1Kiekis = 0;
            int plytu2Kiekis = 0;

            for (int i = 0; i < sienosilgiai.Length; i++) //.Length tai suksis tiek kiek sienos ilgiu yra irasyta
            {
                plytu1Kiekis += VienaSiena(plyta1,  sienosilgiai[i], sienosaukščiai[i]);
                plytu2Kiekis += VienaSiena(plyta2,  sienosilgiai[i], sienosaukščiai[i]);
            }

            Console.WriteLine("Pirmo tipo plytų reikia: {0}", plytu1Kiekis);
            Console.WriteLine("Antro tipo plytų reikia: {0}", plytu2Kiekis);
        }
        static int VienaSiena(Plyta p,  double sienosIlgis, double sienosAukštis) // metodas
        {
            return (int)(sienosIlgis * 1000 / p.ImtiIlgį() *
                         sienosAukštis * 1000 / p.ImtiAukštį());
        }
    }
}
