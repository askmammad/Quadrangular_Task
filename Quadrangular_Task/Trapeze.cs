using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrangular_Task
{
    public class Trapeze : Quadrangular
    {
        private double height;
        public Trapeze(double a, double b, double c, double height)
            :base(a, b, c, b)
        {
            this.height = height;
        }
        public override double Area()
        {
            return ((a + b) / 2) * height;
        }
    }
}
