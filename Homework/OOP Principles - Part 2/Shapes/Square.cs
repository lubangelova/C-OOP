using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square:Shape, IShape
    {
        public Square(double width):base(width,width)
        {
            
        }

        public override double CalculateSurface()
        {
            return this.Width*this.Width;
        }
    }
}
