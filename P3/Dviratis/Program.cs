using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//   
/** Klasė dviračio duomenims saugoti 
@class Dviratis */
class Dviratis
{
    private int metai;
    // pagaminimo metai 
private double kaina; // piniginė vertė 
                      //   
    /** Dviračio duomenys 
@param metai - nauja metų reikšmė 
@param kaina - nauja kainos reikšmė 
*/
    //  
    public Dviratis(int metai, double kaina)
    {
        this.metai = metai;
        this.kaina = kaina;
    }
    /** grąžina metus */
    public int ImtiMetus() { return metai; }
    /** grąžina dviračio reikšmę */
    public double ImtiKainą() { return kaina; }
}

//   
class Program
{
    //   
    const int Cn = 100;
    const string CFd = "..\\..\\Duom.txt";
    static void Main(string[] args)
    {
        Dviratis[] D = new Dviratis[Cn]; // dviračių duomenys – objektai 
        int n;
        int am;
        // dviračių skaičius 
        // dviračio tinkamumo naudoti kritinis amžius 
        Skaityti(CFd, D, out n, out am);
        Console.WriteLine("Dviračių kiekis {0}\n", n);
        int kiekTinka;
        double sumaTinka;


        Pinigai(D, n, 0, am, 2015, out kiekTinka, out sumaTinka);
        Console.WriteLine("Tinkami naudoti: {0,3:d} {1,7:f2}", kiekTinka, sumaTinka);

        int kiekNetinka;
        double sumaNetinka;
        // Netinkami naudoti dviračiai, kurių amžius didelis, 
        // t.y. intervale nuo m iki begalybės (pvz., 1000 metų) 
        Pinigai(D, n, am + 1, 1000, 2015, out kiekNetinka, out sumaNetinka);
        Console.WriteLine("Netinkami naudoti: {0} {1,7:f2}\n", kiekNetinka,
        sumaNetinka);

        double vidurkisTinka = Vidurkis(D, n, 2015, 0, am);
        if (vidurkisTinka > 0)
            Console.WriteLine("Tinkamų naudoti dviračių vidutinis amžius: {0, 7:f2}", vidurkisTinka );
        else Console.WriteLine("Tinkamų naudoti dviračių nėra");
        double vidurkisNetinka = Vidurkis(D, n, 2015, am + 1, 1000);
        if (vidurkisNetinka > 0)
            Console.WriteLine("Netinkamų naudoti dviračių vidutinis amžius: {0,7:f2}\n",
            vidurkisNetinka);
        else Console.WriteLine("Netinkamų naudoti dviračių nėra\n");
        double VisuKaina = 0;
        double visasamzius = 0;
        double metaispagamintas;
        double miau = 0;


        for (int i = 0; i < n; i++)
        {
            VisuKaina += D[i].ImtiKainą();
           
        }
        Console.WriteLine(" VISU DVIRACIU KAINA {0} ", VisuKaina);

        for (int i = 0;i < n; i++)
        {
            
            visasamzius += D[i].ImtiMetus();
            metaispagamintas = D[i].ImtiMetus();
            if (metaispagamintas == 2012 )
            {
                miau = D[i].ImtiKainą();
                Console.WriteLine("VA KAINA TOKIAIS METAIS TAIP EJO {0}", miau);
            }

        }

        double vidutinisamzius = visasamzius / n;
        Console.WriteLine(" VA SITAS YRA VIDUTINIS AMZIUS DVIRACIU {0}", vidutinisamzius);

        for (int i = 0; i < n; i++)
        {

            visasamzius += D[i].ImtiMetus();
            metaispagamintas = D[i].ImtiMetus();
            if (metaispagamintas == 1000)
            {
                miau = D[i].ImtiKainą();
                Console.WriteLine("VA KAINA TOKIAIS METAIS TAIP EJO ( kalba eina apie 1000metus) {0}", miau);
            }

        }
    }
    //   
    /** Skaičiuoja tinkamo amžiaus dviračių kainų sumą ir kiekį 
@param D – dviračių duomenys 
@param n – dviračių skaičius 
@param amPr – dviračių paieškos amžiaus intervalo pradžia 
@param amPb – dviračių paieškos amžiaus intervalo pabaiga 
@param metai – metai, kurių atžvilgiu skaičiuojamas amžius 
@param kiek – dviračių skaičius duotame amžiaus intervale 
@param suma – duoto amžiaus intervalo dviračių piniginė vertė */
    //   
    static void Pinigai(Dviratis[] D, int n, int amPr, int amPb, int metai,
    out int kiek, out double suma)
    {
        kiek = 0;
        suma = 0;
        int amžius;
        for (int i = 0;i < n; i++)
        {
            amžius = metai - D[i].ImtiMetus();
            if ((amPr <= amžius) && (amžius <= amPb))
            {
                suma = suma + D[i].ImtiKainą();
                kiek++;
            }
        }
    }
    //   
    //   
    /** Skaito duomenis iš failo 
@param fv – failo vardas, kuris nurodomas konstanta CFd 
@param D – objektų rinkinys dviračių duomenims saugoti 
@param n – dviračių skaičius 
@param m – kritinis dviračių naudojimo amžius */
    //  
    static double Vidurkis(Dviratis[] D, int n, int metai, int amPr, int amPb)
    {
        int kiek = 0, suma = 0;
        int amžius;
        for (int i = 0; i < n; i++)
        {
            amžius = metai - D[i].ImtiMetus();
            if ((amPr <= amžius) && (amžius <= amPb))
            {
                suma = suma + amžius;
                kiek++;
            }
        }
        if (kiek > 0) return (double)suma / kiek;
        return 0.0;
    }
    //   
    static void Skaityti(string fv, Dviratis[] D, out int n, out int m)
    {
        //   
        int metai;
        double kaina;
        using (StreamReader reader = new StreamReader(fv))
        {
            string line;
            line = reader.ReadLine();
            string[] parts;
            m = int.Parse(line);
            line = reader.ReadLine();
            n = int.Parse(line);
            for (int i = 0; i < n; i++)
            {
                line = reader.ReadLine();
                parts = line.Split(';');
                metai = int.Parse(parts[0]);
                kaina = double.Parse(parts[1]);
                D[i] = new Dviratis(metai, kaina);
            }
        }
    }
    static void Skaiciavimai(Dviratis[] D, out double miau, out double Visukaina, )
    {
        double VisuKaina = 0;
        double visasamzius = 0;
        double metaispagamintas;
        double miau = 0;


        for (int i = 0; i < n; i++)
        {
            VisuKaina += D[i].ImtiKainą();

        }
        Console.WriteLine(" VISU DVIRACIU KAINA {0} ", VisuKaina);

        for (int i = 0; i < n; i++)
        {

            visasamzius += D[i].ImtiMetus();
            metaispagamintas = D[i].ImtiMetus();
            if (metaispagamintas == 2012)
            {
                miau = D[i].ImtiKainą();
                Console.WriteLine("VA KAINA TOKIAIS METAIS TAIP EJO {0}", miau);
            }

        }

        double vidutinisamzius = visasamzius / n;
        Console.WriteLine(" VA SITAS YRA VIDUTINIS AMZIUS DVIRACIU {0}", vidutinisamzius);

        for (int i = 0; i < n; i++)
        {

            visasamzius += D[i].ImtiMetus();
            metaispagamintas = D[i].ImtiMetus();
            if (metaispagamintas == 1000)
            {
                miau = D[i].ImtiKainą();
                Console.WriteLine("VA KAINA TOKIAIS METAIS TAIP EJO ( kalba eina apie 1000metus) {0}", miau);
            }

        }
    }

}
//   