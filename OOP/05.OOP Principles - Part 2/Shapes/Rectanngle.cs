﻿namespace Shapes
{
    public class Rectanngle : Shape
    {
        public Rectanngle(double width, double height)
            : base(width, height)
        {

        }

        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}
