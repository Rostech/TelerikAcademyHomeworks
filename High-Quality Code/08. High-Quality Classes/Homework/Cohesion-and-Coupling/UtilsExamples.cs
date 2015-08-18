namespace CohesionAndCoupling
{
    using System;

    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(FileUtils.GetFileExtension("example"));
            Console.WriteLine(FileUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                DimentionalDistanceUtils.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                DimentionalDistanceUtils.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Cuboid cubloid = new Cuboid(2, 3, 4);

            Console.WriteLine("Volume = {0:f2}", cubloid.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", cubloid.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", cubloid.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", cubloid.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", cubloid.CalcDiagonalYZ());
        }
    }
}
