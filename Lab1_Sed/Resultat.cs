using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Sed
{
    internal class Resultat
    {
        public double A { get; set; }
        public double B { get; set; }
        public Resultat(double a, double b)
        {
            A = a; B = b; 
        }
        public double Resh()
        {
            return A * A+ B * B;    
    }
    }
    

}
