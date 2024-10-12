using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*Savarankiško darbo užduotis3. 
 Sukurkite metodą, kuris surastų duotame objektų rinkinyje brangiausią dviratį. 
 Papildykite programą veiksmais, kuriais būtų randama, kuriame dviračių nuomos punkte yra 
brangiausias dviratis ir kokia jo piniginė vertė. 
Modifikuojama 3.3 skyriaus programa. */

class Dviratis
{
    private string modelis; 
    private int metai;      
    private double kaina;    


    public Dviratis(string modelis, int metai, double kaina)
    {
        this.modelis = modelis;
        this.metai = metai;
        this.kaina = kaina;
    }


    public string ImtiModeli() { return modelis; }


    public int ImtiMetus() { return metai; }

    public double ImtiKaina() { return kaina; }
}

class Program
{
    const int Cn = 100;    
    const string CFd1 = "Nuoma1.txt";  
    const string CFd2 = "Nuoma2.txt";  

    static void Main(string[] args)
    {
        Dviratis[] D1 = new Dviratis[Cn];
        Dviratis[] D2 = new Dviratis[Cn];
        int n1, n2;
        string pav1, pav2;

        
        Skaityti(CFd1, D1, out n1, out pav1);
        Skaityti(CFd2, D2, out n2, out pav2);

        
        var brangiausiasDviratis1 = RastiBrangiausiaDvirati(D1, n1);
        var brangiausiasDviratis2 = RastiBrangiausiaDvirati(D2, n2);
        string p;

        
        if (brangiausiasDviratis1.ImtiKaina() > brangiausiasDviratis2.ImtiKaina())
        {
            Console.WriteLine("Brangiausias dviratis yra punkte: {0}, Modelis: {1}, Kaina: {2:F2} EUR", pav1, brangiausiasDviratis1.ImtiModeli(), brangiausiasDviratis1.ImtiKaina());
        }
        else
        {
            Console.WriteLine("Brangiausias dviratis yra punkte: {0}, Modelis: {1}, Kaina: {2:F2} EUR", pav2 = pav2 + " *ir* " + pav1,p = brangiausiasDviratis2.ImtiModeli() + "*ir*"+ brangiausiasDviratis1.ImtiModeli(), brangiausiasDviratis2.ImtiKaina());
        }
    }

    static void Skaityti(string failas, Dviratis[] D, out int n, out string pav)
    {
        using (StreamReader reader = new StreamReader(failas))
        {
            pav = reader.ReadLine();   
            n = int.Parse(reader.ReadLine());  
            for (int i = 0; i < n; i++)
            {
                string[] parts = reader.ReadLine().Split(';');
                string modelis = parts[0];
                int metai = int.Parse(parts[1]);
                double kaina = double.Parse(parts[2]);
                D[i] = new Dviratis(modelis, metai, kaina);
            }
        }
    }

    static Dviratis RastiBrangiausiaDvirati(Dviratis[] D, int n)
    {
        Dviratis brangiausias = D[0];
        for (int i = 1; i < n; i++)
        {
            if (D[i].ImtiKaina() > brangiausias.ImtiKaina())
            {
                brangiausias = D[i];
            }
        }
        return brangiausias;
    }
}
