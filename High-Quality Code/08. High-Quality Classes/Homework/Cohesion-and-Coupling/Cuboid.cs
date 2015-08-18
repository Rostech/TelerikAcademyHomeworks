namespace CohesionAndCoupling
{
    using System;
    using Abstraction; // Using the NumberValidation class from the previou tasks

    /* Named the class Cuboid because cuboid is a figure that has Width, Height and Depth.
     * I may be wrong, but this was my line of thoughts. :)
     */

    internal class Cuboid 
    {
        private double width;
        private double height;
        private double depth;

        public Cuboid(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (!NumberValidation.IsGreaterThanZero(value))
                {
                    throw new ArgumentException("The width can not be less or equal to zero!");
                }

                this.width = value;
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
                if (!NumberValidation.IsGreaterThanZero(value))
                {
                    throw new ArgumentException("The height can not be less or equal to zero!");
                }

                this.height = value;
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                if (!NumberValidation.IsGreaterThanZero(value))
                {
                    throw new ArgumentException("The depth can not be less or equal to zero!");
                }

                this.depth = value;
            }
        }

        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

        public double CalcDiagonalXYZ()
        {
            double distance = DimentionalDistanceUtils.CalcDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            return distance;
        }

        public double CalcDiagonalXY()
        {
            double distance = DimentionalDistanceUtils.CalcDistance2D(0, 0, this.Width, this.Height);
            return distance;
        }

        public double CalcDiagonalXZ()
        {
            double distance = DimentionalDistanceUtils.CalcDistance2D(0, 0, this.Width, this.Depth);
            return distance;
        }

        public double CalcDiagonalYZ()
        {
            double distance = DimentionalDistanceUtils.CalcDistance2D(0, 0, this.Height, this.Depth);
            return distance;
        }
    }
}
