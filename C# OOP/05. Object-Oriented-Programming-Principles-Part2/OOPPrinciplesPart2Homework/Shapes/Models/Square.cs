
namespace Shapes.Models
{
    using System;

    class Square : Shape
    {
        public Square(double widthAndHeight)
            : base (widthAndHeight, widthAndHeight)
        {

        }

        public override double CalculateSurface()
        {
            return Math.Pow(this.Width,2);
        }
    }
}
