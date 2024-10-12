using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis_u2_16
{
    class Saldainiai
    {

        private double kaina, mase;

        public Saldainiai(double svoris, double Value)
        {
            mase = svoris;
            kaina = Value;

        }
        public double ImtiMase() { return mase; }
        public double ImtiKaina() { return kaina; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Saldainiai s1, s2, s3;
            
            s1 = new Saldainiai(1, 2.33);
            s2 = new Saldainiai(1.5, 2.99);
            s3 = new Saldainiai(2, 5);

            double maxsvoris = s1.ImtiMase();
            double maxkainas = s1.ImtiKaina();
            double minsvoris = s2.ImtiMase();
            double minkaina = s2.ImtiKaina();

            if (maxsvoris >
            


        }
    }
}
