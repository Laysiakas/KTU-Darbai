using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//------------------------------------------------------------ 
// Funkcijos reikšmės skaičiavimas 
//------------------------------------------------------------ 
namespace funkcijos_reiksmes
{
    class Program
    {
        static void Main(string[] args)
        {
            double fx, x,y ;
            Console.Write("Įveskite x reikšmę:  ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Įveskite y reikšmę:  ");
            y = int.Parse(Console.ReadLine());
            if (x * x != y)  //patikrinam ar vardiklis nėra lygus 0
            {
                fx = (Math.Pow(y, 2) - 2 * y * x * Math.Pow(x, 2)) / (Math.Pow(x, 3) - y) ; // Matematinių funkcijų klasė, Pow – kėlimas laipsniu 
                Console.WriteLine(" f(x, y) =  {0}", fx);
            }
            else
                Console.WriteLine("F-ja neegzistuoja");
        }
    }
}
//------------------------------------------------------------ 