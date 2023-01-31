using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrangular_Task
{
    public class Rhomb : Quadrangular
    {
        protected double angle;
        public Rhomb(double a, double angle)
            :base(a, a, a, a)
        {
            this.angle = angle;
        }

        public override double Area()
        {
            double sin = Math.Sin(angle);
            return sin * a * a;
        }

    }
}
