using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dviratis2
{
    class Dviratis
    {
        private int metai;
        // pagaminimo metai 
        private double kaina; // piniginė vertė 
        private int kiek;
        private string pav;
        //   
        /** Dviračio duomenys 
@param metai - nauja metų reikšmė 
@param kaina - nauja kainos reikšmė 
*/
        //  
        public Dviratis(string pav, int kiek, int metai, double kaina) 
        {
            this.metai = metai;
            this.kaina = kaina;
            this.kiek = kiek;
            this.pav = pav;
        }
        /** grąžina metus */
        public int ImtiMetus() { return metai; }
        /** grąžina dviračio reikšmę */
        public double ImtiKainą() { return kaina; }
        public string ImtiPavadinimą() { return pav; }
        public int ImtiKiekį() { return kiek; }
    }


    internal class Program
    {
        const int Cn = 100;
        const string CFd1 = "Nuoma1.txt";
        const string CFd2 = "Nuoma2.txt";
        const string CFrez = "Rezultatai.txt";
        static void Main(string[] args)
        {
            // dviračių skaičius 
            // dviračio tinkamumo naudoti kritinis amžius 
            // Pirmojo dviračių nuomos punkto 
            Dviratis[] D1 = new Dviratis[Cn]; // dviračių duomenys 
            int n1;
            string pav1;
            // dviračių skaičius 
            // nuomos punkto pavadinimas 
            // Antrojo dviračių nuomos punkto 
            Dviratis[] D2 = new Dviratis[Cn]; // dviračių duomenys 
            int n2;
            // dviračių skaičius 
            string pav2;
            // nuomos punkto pavadinimas 
            Skaityti(CFd1, D1, out n1, out pav1);
            //Skaityti(CFd2, D2, out n2, out pav2);

            Console.WriteLine("Pirmas nuomos punktas: {0}", pav1);
            Console.WriteLine("Dviračių kiekis {0}\n", n1);
            Console.WriteLine("Pavadinimas   Kiekis   Pagaminimo metai   Kaina");
            for (int i = 0; i < n1; i++)
            {
                Console.WriteLine("{0,-12} {1,4:d}          {2,3:d}             {3,7:f2}  ",
                    D1[i].ImtiPavadinimą(), D1[i].ImtiKiekį(),
                    D1[i].ImtiMetus(), D1[i].ImtiKainą());
            }
            Console.WriteLine();
            Console.WriteLine("Programa baigė darbą!");
                if (File.Exists(CFrez))
                File.Delete(CFrez);


        }
        static void Skaityti(string Fd, Dviratis[] D, out int n, out string pav)
        {
            using (StreamReader reader = new StreamReader(Fd))
            {
                string eil; int kiekn; int metain; double kainan;
                string line;
                line = reader.ReadLine();
                string[] parts;
                pav = line;
                line = reader.ReadLine();
                n = int.Parse(line);
                for (int i = 0; i < n; i++)
                {
                    line = reader.ReadLine();
                    parts = line.Split(';');
                    eil = parts[0];
                    kiekn = int.Parse(parts[1]);
                    metain = int.Parse(parts[2]);
                    kainan = double.Parse(parts[3]);
                    D[i] = new Dviratis(eil, kiekn, metain, kainan);
                }
            }
        }
        static void SpausdintiDuomenis(string fv, Dviratis[] D, int nkiek, string pav)
        {
            const string virsus =
                "|---------|---------|----------|---------|\r\n "
                + "| Pavadinimas | Kiekis | Pagaminimo | Kaina |\r\n"
                + "|             |        |   metai    | (eurų)|\r\n"
                + "|-------------|--------|------------|-------|\r\n";
                using (var fr = File.AppendText(fv))
            {
                fr.WriteLine("Nuomos firma: {0}", pav);
                fr.WriteLine(virsus);
                Dviratis tarp;
                for (int i = 0; i < nkiek; i++)
                {
                    tarp = D[i];
                    fr.WriteLine("\"| {0,-15} | {1,8} | \r\n{2,5:d}        | {3,7:f2}  |",
                        tarp.ImtiPavadinimą(), tarp.ImtiKiekį(), tarp.ImtiMetus(), tarp.ImtiKainą());

                }
                fr.WriteLine("-------------------------------------------------------------------");
            }
        } 
    }
}
