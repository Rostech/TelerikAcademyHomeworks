namespace DefiningClassesPart2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    using System.Text.RegularExpressions;

    /*
     4. Path

        Create a class Path to hold a sequence of points in the 3D space.
        Create a static class PathStorage with static methods to save and load paths from a text file.
        Use a file format of your choice.

    */

    static class PathStorage
    {
        public static void Save(string path, List<Point3D> pointPath)
        {
            try
            {
                StreamWriter write = new StreamWriter(path);
                using (write)
                {
                    foreach (Point3D p in pointPath)
                        write.WriteLine(p);
                }
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Missing argument!");
            }
            catch(Exception)
            {
                Console.WriteLine("Oops. Something went wrong!");
            }
        }

        public static List<Point3D> Load(string path)
        {
            List<Point3D> loading = new List<Point3D>();
            try
            {
                StreamReader load = new StreamReader(path);
                string line = load.ReadLine();
                using (load)
                {
                    while (line != null)
                    {
                        string[] coordinates = line.Trim().Split(new char[] { ',', ' ', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                        loading.Add(new Point3D(Convert.ToDouble(coordinates[0]), Convert.ToDouble(coordinates[1]), Convert.ToDouble(coordinates[2])));
                        line = load.ReadLine();
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file is not found!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Not valid arguments!");
            }
            return loading;
        }

    }
}
