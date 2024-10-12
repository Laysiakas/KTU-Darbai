using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*Žinoma, kiek kuris turistinės grupės narys turi pinigų (eurai, centai). Duomenys tekstiniame faile. Parašykite 
programą, kuri suskaičiuotų, kiek grupė turi pinigų iš viso ir kiek vidutiniškai jų tenka kiekvienam nariui. 
Kiekvienas narys bendroms grupės išlaidoms skiria ketvirtadalį turimų pinigų. Kiek pinigų bus iš viso 
surinkta bendroms grupės išlaidoms? */

namespace Uzduotis1
{
    class Turistai
    {
        private int Eurai;
        private int Centai;

        public Turistai(int eurai, int centai)
        {
            Eurai = eurai;
            Centai = centai;

        }

        public int ImtiEurus() { return Eurai; }

        public int ImtiCentus() { return Centai; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            const int Cn = 100;
            const string CFd = "turistu_pinigai.txt";

            int visipinigai = 0;
            int eur = 0;
            int cnt = 0;


            Turistai[] D = new Turistai[Cn];

            int n = File.ReadAllLines(CFd).Length; // turistu skaicius pagal linijas

            Skaityti(CFd, D, out n);
            SkaiciuotiPinigus(D, n, out eur, out cnt);

            //for (int i = 0; i < n; i++)
            //{
            //    cnt += D[i].ImtiCentus();
            //    eur += D[i].ImtiEurus();
            //}
            visipinigai = eur + (cnt / 100);
            int CentuLikutis = cnt % 100;
            Console.WriteLine(" Visi Pinigai {0} eur ir {1} cnt ", visipinigai, CentuLikutis);
            int vidutiniskai = visipinigai / n; // vidutiniskai tenka kiekvienam
            int ct = visipinigai % 100;
            Console.WriteLine(" Vidutiniskai tenka kiekvienam {0} eur {1} ct ", vidutiniskai, ct);
            double ketvirtadalis = (visipinigai * 100 + CentuLikutis) * 0.25;
            ketvirtadalis = ketvirtadalis / 100;
            Console.WriteLine(" Jeigu visi duoda po ketvirtadali, bendroms išlaidoms lieka: {0, 7:f2} eur", ketvirtadalis);
        }
        static void Skaityti(string fv, Turistai[] D, out int n)
        {
            using (StreamReader reader = new StreamReader(fv))
            {
                n = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(' ');
                    int Eurai = int.Parse(parts[0]);
                    int Centai = int.Parse(parts[1]);
                    D[n++] = new Turistai(Eurai, Centai);


                }
            }
        
        }
        static void SkaiciuotiPinigus(Turistai[] D, int n, out int eurai, out int centai)
        {
            eurai = 0;
            centai = 0;

            for (int i = 0; i < n; i++)
            {
                centai += D[i].ImtiCentus();
                eurai += D[i].ImtiEurus();
            }
        }

    }
}
