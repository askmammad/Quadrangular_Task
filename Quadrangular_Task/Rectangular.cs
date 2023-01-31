using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrangular_Task
{
    public class Rectangular : Quadrangular
    {
        public Rectangular(double a, double b)
            : base(a, b, a, b)
        {
        }
        public override double Area()
        {
            double area = a * b;
            return area;
        }
    }
}
