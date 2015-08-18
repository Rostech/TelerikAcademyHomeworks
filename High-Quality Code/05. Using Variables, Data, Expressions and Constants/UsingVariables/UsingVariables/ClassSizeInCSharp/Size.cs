namespace UsingVariables.ClassSizeInCSharp
{
    using System;

    /*
      Task 1. Class Size in C#

        Refactor the following code to use proper variable naming and simplified expressions:
     */

    public class Size
    {
        private double width;
        private double height;

        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                Double.TryParse(value.ToString(), out this.width); 
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                Double.TryParse(value.ToString(), out this.height);
            }
        }

        public static Size GetRotatedSize(Size size, double rotatedSize)
        {
            double rotatedWidth = (Math.Abs(Math.Cos(rotatedSize)) * size.Width) +
                    (Math.Abs(Math.Sin(rotatedSize)) * size.Height);
            double rotatedHeight = (Math.Abs(Math.Sin(rotatedSize)) * size.Width) +
                    (Math.Abs(Math.Cos(rotatedSize)) * size.Height);

            Size newRotatedSize = new Size(rotatedWidth, rotatedHeight);

            return newRotatedSize;
        }
    }
}
