using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------------------------------------ 
// Sąlygos sakinys 
// Simbolių paskirstymas į eilutes 
//------------------------------------------------------------ 
namespace SalygosSakinys
{
    class Program
    {
        static void Main(string[] args)
        {
            char simbolis;
            int bendras, vienos_eilutės_kiekis; //bendram spausdinamam simbolių kiekiui ir vienos eilutės simbolių kiekiui nustatyti
            Console.Write("Įveskite spausdinamą simbolį: ");
            simbolis = (char)Console.Read();
            Console.ReadLine();  // Būtinas tik tada, jei dar būtų skaitymų!!! 
            Console.Write("Įveskite kiek norite simbolių: ");
            bendras = int.Parse(Console.ReadLine());
            Console.Write("Įveskite kiek vienoje eilutėje norite simbolių, turi būti dalus iš bendro simbolių kiekio: ");
            vienos_eilutės_kiekis = int.Parse(Console.ReadLine());
            int eilutė = bendras / vienos_eilutės_kiekis; //gauname pilna eilute
            int liekana = bendras % vienos_eilutės_kiekis; // gauname liekana, kas liko po praeito ciklo
            Console.WriteLine("");
            for (int i = 1; i <= eilutė; i++) 
            {
                for (int j = 0; j < vienos_eilutės_kiekis; j++)
                { 
                    Console.Write(simbolis);
                }
                Console.WriteLine();
            for (int j = 0; j < liekana; j++)
                {
                    Console.Write(simbolis);
                } 
            }
            Console.WriteLine("");
        }
    }
}
//------------------------------------------------------------