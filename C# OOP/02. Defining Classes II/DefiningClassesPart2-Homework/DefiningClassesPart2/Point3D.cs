namespace DefiningClassesPart2
{
    using System;

    /*
      1. Structure

        Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
        Implement the ToString() to enable printing a 3D point.

    */

    struct Point3D
    {
        private double x;
        private double y;
        private double z;

        /*
         2. Static read-only field

            Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
            Add a static property to return the point O.

        */

        private static readonly Point3D o = new Point3D(0, 0, 0);

        public Point3D(double x, double y, double z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }
        public double Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }
        public double Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }

        public static Point3D O
        {
            get
            {
                return o;
            }
        }
            
        public override string ToString()
        {
            return string.Format("({0},{1},{2})", this.X, this.Y, this.Z);
        }
    }
}
