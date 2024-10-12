using System;
using System.IO;

namespace Uzduotis2
{
    class Pinigai
    {
        private int eur, ct = 0;
        private decimal keitykla;

        public Pinigai(int eur, int ct, decimal keitykla)
        {
            this.eur = eur;
            this.ct = ct;
            this.keitykla = keitykla;
        }

        public int ImtiEurus() { return eur; }
        public int ImtiCentus() { return ct; }
        public decimal ImtiKursa() { return keitykla; }


        public decimal Visieurai()
        {
            return (eur + ct / 100m) * keitykla; 
        }
    }

    class Program
    {
        const int Cn = 100;
        const string CFd1 = "a.txt"; // Anupras
        const string CFd2 = "b.txt"; // Barbora

        static void Main(string[] args)
        {

            Pinigai[] anuprasD = new Pinigai[Cn];
            Pinigai[] barboraD = new Pinigai[Cn];

            int anupras = 0;
            int barbora = 0;


            Skaityti(CFd1, anuprasD, out anupras);
            Skaityti(CFd2, barboraD, out barbora);


            decimal visiAnupras = Apskaiciuoti(anuprasD, anupras);
            decimal visiBarbora = Apskaiciuoti(barboraD, barbora);
            decimal bendrai = visiAnupras + visiBarbora;


            Console.WriteLine($"Anupras bendra suma eurais: {visiAnupras:F2}");
            Console.WriteLine($"Barbora bendra suma eurais: {visiBarbora:F2}");
            Console.WriteLine($"Bendra suma abiems: {bendrai:F2}");
        }


        static void Skaityti(string fv, Pinigai[] D, out int n)
        {
            using (StreamReader reader = new StreamReader(fv))
            {
                reader.ReadLine();
                n = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(' ');
                    int Eurai = int.Parse(parts[0]);
                    int Centai = int.Parse(parts[1]);
                    decimal keitykla = decimal.Parse(parts[2]);
                    D[n++] = new Pinigai(Eurai, Centai, keitykla);
                }
            }
        }

        static decimal Apskaiciuoti(Pinigai[] D, int n)
        {
            decimal viskas = 0;

            for (int i = 0; i < n; i++)
            {
                viskas += D[i].Visieurai();
            }

            return viskas;
        }
    }
}
