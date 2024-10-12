using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis2
{
    class draugai
    {
        private string Vardas;
        private double Ugis, Svoris;
        private static int draugukiekis = 0; // static reikalingas kad suzinoti kiek objektu yra, nes jis veikia per visus klases parametrus

        public draugai(string Vardas, double ugis, double svoris)
        {
            this.Vardas = Vardas;
            this.Ugis = ugis;
            this.Svoris = svoris;

            draugukiekis++; // panasiai kaip for ciklas, kiek sukurta objektu, tiek ir padideja

        }
        public string Imtivardas()
            { return Vardas; }
        public double Imtiugis()
            { return Ugis; }
        public double Imtisvoris()
            { return Svoris; }
        public static int Imtikieki()  
            { return draugukiekis; }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            draugai d1, d2, d3, d4; // Draugų objektai
            d1 = new draugai("Jonas", 1.65, 78);
            d2 = new draugai("Algis", 1.78, 89);
            d3 = new draugai("Martynas", 1.65, 100);
            d4 = new draugai("Darius", 2.11, 120);

            double vidutinissvoris = (d1.Imtisvoris() + d2.Imtisvoris() + d3.Imtisvoris() + d4.Imtisvoris()) / draugai.Imtikieki() ; // visu svoriu sudejimas ir padalinimas is draugu kiekio
            Console.WriteLine("Vidutinis vaikinų svoris: {0}", vidutinissvoris );                                                   // kiekis nustatomas pagal objektu skaiciu klaseje.
            string zemiausias = d1.Imtivardas(); // priskiriam pirma klaseje esanti objekta ir su juo lyginam kita ir t.t. kol randam reikiama atsakyma.
            double ugis = d1.Imtiugis();
            if (d2.Imtiugis() <= ugis) { zemiausias += " " + d2.Imtivardas(); ugis = d2.Imtiugis(); }
            if (d3.Imtiugis() <= ugis) { zemiausias += " " + d3.Imtivardas(); ugis = d3.Imtiugis(); }
            if (d4.Imtiugis() <= ugis) { zemiausias += " " + d4.Imtivardas(); ugis = d4.Imtiugis(); }
            Console.WriteLine(" ");
            Console.WriteLine("Zemiausi(-as) vaikinai(-as): {0} ", zemiausias );
            Console.WriteLine(" ");

            



        }
    }
}
