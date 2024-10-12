//------------------------------------------------------------ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------------------------------------ 
// Ciklas for 
//------------------------------------------------------------ 
namespace ciklas
{
    class Program
    {
        static void Main(string[] args)
        {
            int pradžia;     //skaičius nuo kurio prasideda ciklas   
            int pabaiga;   // skaičius ties kuriuo užbaigiamas ciklas
            int ciklų_skaičius = 0; //reikalingas suskaičiuoti kiek kartu ciklas prasisuko
            Console.Write("Įveskite ciklo pradžios reikšmę: ");
            pradžia =   int.Parse(Console.ReadLine());
            Console.Write("Įveskite ciklo pabaigos reikšmę ");
            pabaiga = int.Parse(Console.ReadLine());
            Console.WriteLine("Skaičiai nuo {0} iki {1}, jų kvadratai ir kubai:", pradžia, pabaiga);
            for (int i = pradžia; i <= pabaiga; i++)
                { 
            Console.WriteLine(" {0,3:d}    {1,5:d}   {2,7:d}", i, i * i, i * i * i);
            ciklų_skaičius++;
                }
            Console.WriteLine("\n Iš viso buvo skaičiuota {0} kartus/u.", ciklų_skaičius );
        }
        
    }   
}
//------------------------------------------------------------ 