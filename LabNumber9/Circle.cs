using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber9
{
    class Circle
    {
        private double radius;

        public double GetCircumference()
        {

            double circumference = 2 * Math.PI * radius;
            
            return circumference;
        }


        public double GetArea()
        {   
            double area = Math.PI * (radius * radius);
            
            return area;
        }


        

        public double Radius
        {
            set { radius = value; }

            get { return radius; }

        }
    }
}
