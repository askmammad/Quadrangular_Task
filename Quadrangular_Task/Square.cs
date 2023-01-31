using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Quadrangular_Task
{
    public class Square : Rhomb
    {
        public Square(double a)
            :base(a, 90)
        {
        }
        public override double Area()
        {
            return a * a;
        }


    }
}
