using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dvi_klasės
{
    //------------------------------------------------------------ 
    /** Klasė kelio duomenims saugoti 
    @class Kelias */
    class Kelias
    {
        private string pav;            // kelio pavadinimas 
        private double ilgis;          // kelio ilgis 
        private int lgr;            // leistinas greitis km/val. 

        //---------------------------------------------------- 
        /** Kelio duomenys 
        @param ilgis - kelio ilgio reikšmė 
        @param pav   - kelio pavadinimas 
        @param lgr   - leistinas greitis km/val. reikšmė  */
        //---------------------------------------------------- 
        public Kelias(string pav, double ilgis, int lgr)
        {
            this.pav = pav;
            this.ilgis = ilgis;
            this.lgr = lgr;
        }

        /** įrašo leistiną greitį km/val. */
        public void DėtiLeistGreitį(int lg) { lgr = lg; }

        /** grąžina kelio pavadinimą */
        public string ImtiPav() { return pav; }

        /** grąžina kelio ilgį */
        public double ImtiIlgį() { return ilgis; }

        /** grąžina leistiną greitį km/val. */
        public int ImtiLeistGreitį() { return lgr; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Duomenų priskyrimas ir spausdinimas 
            Kelias k1, k2, k3;        // objektai 
            k1 = new Kelias("Kaunas - Vilnius", 105.0, 110);
            k2 = new Kelias("Kaunas - Alytus", 65.6, 90);
            k3 = new Kelias("Vilnius - Panevėžys", 136.0, 120);

            Console.WriteLine("Keliai (pavadinimas)\t      ilgis,\t   leistinas greitis:)");
            Console.WriteLine("{0},\t {1,10:f2}, {2,15:d}",
                              k1.ImtiPav(), k1.ImtiIlgį(), k1.ImtiLeistGreitį());
            Console.WriteLine("{0},\t {1,10:f2}, {2,15:d}", k2.ImtiPav(),
                              k2.ImtiIlgį(), k2.ImtiLeistGreitį());
            Console.WriteLine("{0},\t {1,10:f2}, {2,15:d} \n\n", k3.ImtiPav(),
                              k3.ImtiIlgį(), k3.ImtiLeistGreitį());
            double laikas = k2.ImtiIlgį() / k2.ImtiLeistGreitį() +
                k1.ImtiIlgį() / k1.ImtiLeistGreitį() +
                k3.ImtiIlgį() / k3.ImtiLeistGreitį();
            Console.WriteLine("Iš Alytaus į Panevėžį nuvažiuosime per {0,5:f2}  val. ", laikas);
            string maxPav = k1.ImtiPav();
            double maxIlgis = k1.ImtiIlgį();
            if (k2.ImtiIlgį() > maxIlgis)
            {
                maxPav = k2.ImtiPav(); maxIlgis = k2.ImtiIlgį();
            }
            if (k3.ImtiIlgį() > maxIlgis)
            {
                maxPav = k3.ImtiPav(); maxIlgis = k3.ImtiIlgį();
            }
            Console.WriteLine();
            Console.WriteLine("Ilgiausias kelias: {0}", maxPav);
            double mingreitis = k1.ImtiLeistGreitį();
            string minpav = k1.ImtiPav();
            if (k2.ImtiLeistGreitį() < mingreitis)
            {
                minpav = k2.ImtiPav(); mingreitis = k2.ImtiLeistGreitį();
            }
            if(k3.ImtiLeistGreitį() < mingreitis)
            {
                minpav = k3.ImtiPav(); mingreitis = k2.ImtiLeistGreitį();
            }
            Console.WriteLine();
            Console.WriteLine("Mažiausias leistinas greitis: {0}", minpav);
            Console.WriteLine("Programa baigė darbą!");
        }
    }
} 
    //------------------------------------------------------------ 
