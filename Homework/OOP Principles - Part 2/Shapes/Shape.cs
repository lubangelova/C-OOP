using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape:IShape
    {
        private double width;
        private double height;
        private const string PositiveNumber = "must be positive number!";

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Heigth = height;

        }
        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value<0)
                {
                    throw new ArgumentException($"The width {PositiveNumber}");
                }
                this.width = value;
            }
        }
        public double Heigth
        {
            get
            {
                return this.height;

            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"The height {PositiveNumber}");
                }
                this.height = value;
            }
        }

       
        public abstract double CalculateSurface();
    }
}
