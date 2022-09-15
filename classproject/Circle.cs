using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classproject
{
    public class Circle
    {
       public double pi = 3.14, radius, area;

        public Circle( double radius)
        {
          
            this.radius = radius;
            
        }
        public void CalculateArea()
        {
            area = pi*radius*radius;
        }
        public string DisplayValue()
        {
            return $"area of circle is: {area}";
        }
    }
}
