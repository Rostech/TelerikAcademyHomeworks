namespace DefiningClassesPart2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /*
     4. Path

        Create a class Path to hold a sequence of points in the 3D space.
        Create a static class PathStorage with static methods to save and load paths from a text file.
        Use a file format of your choice.

    */

    class Path
    {
        private List<Point3D> sequenceOfPoints = new List<Point3D>();

        public List<Point3D> SequenceOfPoints
        {
            get
            {
                return this.sequenceOfPoints;
            }
        }

        public void AddPoint(Point3D p)
        {
            sequenceOfPoints.Add(p);
        }



    }
}
