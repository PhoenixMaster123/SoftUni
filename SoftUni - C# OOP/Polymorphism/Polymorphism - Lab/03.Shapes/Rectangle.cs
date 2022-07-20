using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public double Width { get;  set; }
        public double Height { get;  set; }
        public override double CalculateArea()
        {
            return this.Width * this.Height;
        }

        public override double CalculatePerimeter()
        {
            return (this.Width * 2 + this.Height * 2);
        }
        public override string Draw()
        {
            return base.Draw() + GetType().Name;
        }

    }
}

