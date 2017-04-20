using System;
using System.Collections.Generic;
using System.Linq;
using IO=System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    public static class PathStorage
    {
        public static void Save(string fileName, List<Point3D> listPoints)
        {
            string fullFilePath = IO.Path.Combine(@"..\..\Files", $"{fileName.Trim()}.txt");
            using (IO.StreamWriter writer = IO.File.CreateText(fullFilePath))
            {
                foreach (var item in listPoints)
                {
                    writer.WriteLine(item);
                }
             
            }
        }

        public static Path Load(string fileName)
        {
            Path path = new Path();
            string fullFilePath = IO.Path.Combine(@"..\..\Files", $"{fileName.Trim()}.txt");

            try
            {
                using (IO.StreamReader reader = new IO.StreamReader(fullFilePath))
                {
                    string[] points = reader.ReadToEnd()
                        .Split(new string[] { "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var point in points)
                    {
                        double[] coordinates = point.Trim('[', ']', ' ')
                            .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(double.Parse)
                            .ToArray();

                        path.Add(new Point3D(coordinates[0], coordinates[1], coordinates[2]));
                    }
                }
            }
            catch (IO.FileNotFoundException)
            {
                Console.WriteLine($"The file path {fileName} cannot be found");
            }

            return path;
        }

    }
}
