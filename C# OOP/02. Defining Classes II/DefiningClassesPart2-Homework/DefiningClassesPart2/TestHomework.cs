
namespace DefiningClassesPart2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Runtime.InteropServices;

    [Version("1","0.2")]
    class TestHomework
    {
        static void Main(string[] args)
        {
            /*
             11. Version attribute

                Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods and holds a version in the format major.minor (e.g. 2.11).
                Apply the version attribute to a sample class and display its version at runtime.

            */
            Type type = typeof(TestHomework);
            object[] vers = type.GetCustomAttributes(false);
            foreach(VersionAttribute version in vers)
            {
                Console.WriteLine("The version is [{0}.{1}]",
                    version.Version, version.SubVersion);
            }

            /*
             1. Structure

                Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
                Implement the ToString() to enable printing a 3D point.

            */
            Console.WriteLine(new String('-', 73));
            Console.WriteLine();
            Point3D point1 = new Point3D(3, 4, 5);
            Console.WriteLine("Point: " + point1);

            /*
              2. Static read-only field

                Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
                Add a static property to return the point O.

            */
            Console.WriteLine(new String('-', 73));
            Console.WriteLine("Center O : " + Point3D.O);

            /*
             3. Static class

                Write a static class with a static method to calculate the distance between two points in the 3D space.

            */
            Console.WriteLine(new String('-', 73));
            Point3D point2 = new Point3D(5, 4, 3);
            Console.WriteLine("Distance between two points {0} and {1} is {2:F3}",point1, point2,  DistanceBetweenPoints.Distance(point1, point2) );

            /*
             4. Path

                Create a class Path to hold a sequence of points in the 3D space.
                Create a static class PathStorage with static methods to save and load paths from a text file.
                Use a file format of your choice.

            */
            Console.WriteLine(new String('-', 73));
            List<Point3D> path = PathStorage.Load(@"..\..\fileWithPoints_test.txt");
            Console.WriteLine("Path with poinst loaded from a .txt file :");
            foreach(Point3D p in path)
            {
                Console.WriteLine(p);
            }
            PathStorage.Save(@"..\..\TestSavePath.txt", path);
            Console.WriteLine("Those points were saved to ' " + @"..\..\TestSavePath.txt" + " ' ");

            /*
             5. Generic class

                Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
                Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
                Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString().
                Check all input parameters to avoid accessing elements at invalid positions.

            */
            Console.WriteLine(new String('-', 73));

            Console.WriteLine("Creating Generic list");
            GenericList<int> genericListInt = new GenericList<int>(3);
            genericListInt.Add(1);
            genericListInt.Add(2);
            genericListInt.Add(3);
            Console.WriteLine("Added to list : " + genericListInt);
            Console.WriteLine("Element on index [1] is : " + genericListInt[1]);
            genericListInt.RemoveAt(1);
            Console.WriteLine("Removed element on index [1], list is : " + genericListInt);
            genericListInt.InsertAt(1, 100);
            Console.Write("Inserted element '{0}' ot position {1}. ", genericListInt[1], 1);
            Console.WriteLine("List is: " + genericListInt);

            /*
             6. Auto-grow

                Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.

            */
            Console.WriteLine(new String('-', 73));
            Console.WriteLine("Before adding elements list is {0} and has capacity: {1}",
                genericListInt, genericListInt.Capacity);
            genericListInt.Add(101);
            genericListInt.Add(102);
            genericListInt.Add(103);
            genericListInt.Add(104);
            Console.WriteLine("After adding a few elements the list is {0} \nand it's capacity is : {1}",
                genericListInt, genericListInt.Capacity);

            /*
             7. Min and Max

                Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
                You may need to add a generic constraints for the type T.

            */
            Console.WriteLine(new String('-', 73));
            Console.WriteLine("Minimal element is: {0} ", genericListInt.Min());
            Console.WriteLine("Maximal element is: {0} ", genericListInt.Max());
            Console.WriteLine("List before clear: \n" + genericListInt);
            genericListInt.Clear();
            Console.WriteLine("List after clear: \n" + genericListInt + "  it's empty :( ");
            /*
              8. Matrix

                Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).

              9. Matrix indexer

                Implement an indexer this[row, col] to access the inner matrix cells.

             10. Matrix operations

                Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
                Throw an exception when the operation cannot be performed.
                Implement the true operator (check for non-zero elements).

            */

            Console.WriteLine(new String('-', 73));
            Matrix<int> matr1 = new Matrix<int>(3, 2);
            matr1[0, 0] = 1;
            matr1[0, 1] = 1;
            matr1[1, 0] = 1;
            matr1[1, 1] = 1;
            matr1[2, 0] = 1;
            matr1[2, 1] = 1;
            Console.WriteLine("Matrix1 is : \n" + matr1);
            Matrix<int> matr2 = new Matrix<int>(3, 2);
            matr2[0, 0] = 2;
            matr2[0, 1] = 2;
            matr2[1, 0] = 2;
            matr2[1, 1] = 2;
            matr2[2, 0] = 2;
            matr2[2, 1] = 2;
            Console.WriteLine("Matrix2 is : \n" + matr2);
            Console.WriteLine("Matrix1 + Matrix2 : \n" + (matr1 + matr2));
            Console.WriteLine("Matrix1 - Matrix2 : \n" + (matr1 - matr2));
 
            Matrix<int> multMatr = new Matrix<int>(2, 5);
            multMatr[0, 0] = 0;
            multMatr[0, 1] = 0;
            multMatr[0, 2] = 0;
            multMatr[0, 3] = 0;
            multMatr[0, 4] = 0;
            multMatr[1, 0] = 0;
            multMatr[1, 1] = 0;
            multMatr[1, 2] = 0;
            multMatr[1, 3] = 0;
            multMatr[1, 4] = 0;
            Console.WriteLine("Matrix 3 : \n" + multMatr);
            Console.WriteLine("Matrix1 * Matrix3 : ");
            Console.WriteLine(matr1 * multMatr);
            if(matr1 * multMatr)
            {
                Console.WriteLine("The matrix: \n" + (matr1 * multMatr));
                Console.WriteLine("DOES NOT CONTAIN ZERO");
            }
            else
            {
                Console.WriteLine("The matrix: \n" + (matr1 * multMatr));
                Console.WriteLine("CONTAINS ZERO");
            }

        }
    }
}
