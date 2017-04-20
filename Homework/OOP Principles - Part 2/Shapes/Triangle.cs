using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle:Shape,IShape
    {
        public Triangle(double width, double height) : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            return (this.Heigth * this.Width) / 2;
        }

        
    }
}
