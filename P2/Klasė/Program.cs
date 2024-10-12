using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------------------------------------ 
// Vienos klasės naudojimas, plytos charakteristikos 
//------------------------------------------------------------ 
namespace Klasė
{   /** Klasė plytos duomenims saugoti 
    @class Plyta */
    class Plyta
    {
        private int ilgis,      // plytos ilgis, milimetrais 
                    plotis,     // plytos plotis, milimetrais 
                    aukštis;    // plytos aukštis, milimetrais 

        //---------------------------------------------------- 
        /** Plytos duomenys 
        @param ilgis - ilgio reikšmė 
        @param pločioReikšmė - pločio reikšmė 
        @param aukščioReikšmė - aukščio reikšmė  */
        //---------------------------------------------------- 
        public Plyta(int ilgis, int pločioReikšmė, int aukščioReikšmė)
        {
            this.ilgis = ilgis;
            plotis = pločioReikšmė;
            aukštis = aukščioReikšmė;
        }

        /** grąžina plytos ilgį */
        public int ImtiIlgį() { return ilgis; }

        /** grąžina plytos plotį */
        public int ImtiPlotį() { return plotis; }

        /** grąžina plytos aukštį */
        public int ImtiAukštį() { return aukštis; }
        //------------------------------------------------------------ 
        static void Main(string[] args)
        {
            Plyta p1;
            p1 = new Plyta(250, 120, 88);
            SpausdintiPlytą(p1);
            Plyta p2;
            p2 = new Plyta(240, 115, 71);

            Plyta p3;
            p3 = new Plyta(240, 115, 61);


            double sienosIlgis = 12.0,
                   sienosPlotis = 0.23,
                   sienosAukštis = 3.0;

            int k1;      // Pirmo tipo plytų kiekis 
            k1 = (int)(sienosIlgis * 1000 / p1.ImtiIlgį() *
                       sienosPlotis * 1000 / p1.ImtiPlotį() *
                       sienosAukštis * 1000 / p1.ImtiAukštį());
            Console.WriteLine("1-o tipo plytų reikia: {0,6:d} \n ", (4 * VienaSiena(p1, sienosPlotis, sienosIlgis, sienosAukštis)));

            SpausdintiPlytą(p2);
            int k2;      // Antro tipo plytų kiekis 
            k2 = (int)(sienosIlgis * 1000 / p2.ImtiIlgį() *
                       sienosPlotis * 1000 / p2.ImtiPlotį() *
                       sienosAukštis * 1000 / p2.ImtiAukštį());
            Console.WriteLine("2-o tipo plytų reikia: {0,6:d} \n ", (4 * VienaSiena(p2, sienosPlotis, sienosIlgis, sienosAukštis)));

            int k3;      // Antro tipo plytų kiekis 
            k3 = (int)(sienosIlgis * 1000 / p2.ImtiIlgį() *
                       sienosPlotis * 1000 / p2.ImtiPlotį() *
                       sienosAukštis * 1000 / p2.ImtiAukštį());
            SpausdintiPlytą(p3);
            Console.WriteLine("3-o tipo plytų reikia: {0,6:d} \n ", (4 * VienaSiena(p3, sienosPlotis, sienosIlgis, sienosAukštis)));

            Console.WriteLine("Programa baigė darbą!");

            Console.WriteLine("Cilindro formos bokstas ");
            double skersmuo = 10, aukstis = 15, storis = 0.2, pi = 3.14;

            Console.WriteLine("1. plytu cilindrui reikes: {0} ", cilindriukas(p1, skersmuo, aukstis, storis, pi));
            Console.WriteLine("2. plytu cilindrui reikes: {0} ", cilindriukas(p2, skersmuo, aukstis, storis, pi));
            Console.WriteLine("3. plytu cilindrui reikes: {0} ", cilindriukas(p3, skersmuo, aukstis, storis, pi));
        }
        static int VienaSiena(Plyta p, double sienosPlotis, double sienosIlgis,
                      double sienosAukštis)
        {
            return (int)(sienosIlgis * 1000 / p.ImtiIlgį() *
                         sienosPlotis * 1000 / p.ImtiPlotį() *
                         sienosAukštis * 1000 / p.ImtiAukštį());
        }
        static void SpausdintiPlytą(Plyta p)
        {
            Console.WriteLine("Plytos aukštis: {0,3:d} \nPlytos plotis: {1, 4:d} \n"
            + "Plytos ilgis: {2, 5:d}\n",
            p.ImtiAukštį(), p.ImtiPlotį(), p.ImtiIlgį());

        }
            static int cilindriukas(Plyta p, double skersmuo, double aukstis,
                  double storis, double pi)
            {
                return (int)(skersmuo * 1000 / p.ImtiIlgį() *
                             aukstis * 1000 / p.ImtiPlotį() *
                             storis * 1000 / p.ImtiAukštį() * pi);
                             
            }
        } 
    }

