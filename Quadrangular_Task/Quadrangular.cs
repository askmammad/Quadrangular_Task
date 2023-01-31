using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Quadrangular_Task
{
    public abstract class Quadrangular
    {
        protected double a;
        protected double b;
        protected double c;
        protected double d;

        public Quadrangular(double aSide, double bSide, double cSide, double dSide)
        {
            a = aSide;
            b = bSide;
            c = cSide;
            d = dSide;
        }

        public abstract double Area();

        public double Perimetr()
        {
            return a + b + c + d;
        }
    }
}
