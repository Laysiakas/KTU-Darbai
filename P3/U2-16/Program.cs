using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

/*U3–16. Atmintukai 
  
Atmintukų duomenys yra faile: markė, talpa ir kaina. Pirmoje eilutėje yra savininko pavardė ir vardas. 
Sukurkite klasę Atmintukas vieno atmintuko duomenims saugoti. Raskite kokia pigiausio atmintuko 
talpa ir už kokią pinigų sumą žmogus turi atmintukų. 
  
Papildykite programą veiksmais su dviejų žmonių atmintukų rinkiniais. Kiekvieno rinkinio duomenys 
saugomi atskiruose failuose. Pas kurį žmogų yra didesnės talpos pigiausias atmintukas ir kuris žmogus 
turi atmintukų už didesnę kainą. Surašykite į atskirą rinkinį abiejų sąrašų visus nurodytos markės 
atmintukų duomenis. */
class atmintukas
{
    private string pav;
    private double talpa;
    private decimal kaina;

    public atmintukas(string pav, double talpa, decimal kaina)
    {
        this.pav = pav;
        this.talpa = talpa;
        this.kaina = kaina;
    }
    string ImtiPav() { return pav; }
    double ImtiTalpa() { return talpa; }
    decimal ImtiKaina() { return kaina; }
}
namespace U2_16
{
    internal class Program
    {
        const int cn = 100;
        const string failas = "atmintukas.txt";
        static void Main(string[] args)
        {
            atmintukas[] A = new atmintukas[cn];
            Skaityti(failas, A, out int n, out string VP);
            Console.WriteLine(" {0} {1}", VP, n);
        }
        static void Skaityti(string failas, atmintukas[] A, out int n, out string VP)
        {
            using (StreamReader reader = new StreamReader(failas)) 
            {
                n = 0;
                string line;
                VP = reader.ReadLine();
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(' ');
                    string pav = parts[0];
                    double talpa = double.Parse(parts[1]);
                    decimal kaina = decimal.Parse(parts[2]);
                    A[n++] = new atmintukas(pav, talpa, kaina);
                }

            }
            
        }
    }
}
