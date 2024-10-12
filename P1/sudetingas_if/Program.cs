using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//------------------------------------------------------------ 
// Sudėtingas if sakinys 
//------------------------------------------------------------ 
namespace sudetingas_if
{
    class Program
    {
        static void Main(string[] args)
        {
            double fx;
            double x;
            Console.Write(" Įveskite x reikšmę:  ");
            x = double.Parse(Console.ReadLine());
            Console.Clear();                      // Išvalo langą 
            Console.SetCursorPosition(3, 2);      // Nustato pradinę žymeklio padėtį 
            if (x >= -5 && x <= 0)
            {
                fx = Math.Cos(Math.Pow(x, 2));
                Console.WriteLine("f(x) = {0}", fx);
            }
            else if (x > 0 && x < 3) 
            {
                fx = (4 * Math.Pow(x, 2) + 3);
                Console.WriteLine("f(x) = {0}", fx);
            }
            else
            {
                fx = Math.Sqrt(Math.Pow(x, 2) - x - 4);
                Console.WriteLine("Reikšmė x = {0,3:f1}, fx = {1,6:f2}",
                                  x, fx);
            }
        }
    }
}
//------------------------------------------------------------ 