using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstracttask
{
    class circle : shape
    {
            private double radius;
             public circle(double r)
        {
            radius = r;
        }

          
        public override double area()
        {
            Console.Write("Area of circle: ");
            double y = Math.PI * radius * radius;
            return y;
        }
    } }

    

